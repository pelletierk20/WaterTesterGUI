using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaterTesterGUI
{
    
    public partial class Form1 : Form
    {
        string ph_hThresh = "15";
        string pH_lThresh = "0";

            
        string temp_lThresh = "40";
        string temp_hThresh = "80";

        string orp_lThresh = "-1500";
        string orp_hThresh= "1500";

        string do_lThresh = "0";
        string do_hThresh= "100";

        Int32 port = 631;
        IPAddress piAddr = IPAddress.Parse("192.168.56.1");
        
        TcpListener listener = null;
        

        DataTable dt = new DataTable();
        private BackgroundWorker _worker = null;

        public Form1()
        {
            InitializeComponent();
            setupDataGridView();

            chart1.Titles.Add("pH vs Time");
            


        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;


            int count = 0;
            //This background worker will go until the stop button is pressed which will send a cancellation pending to break the loop

            //This worker event handler is treated separetly from the rest of the code
            
            _worker.DoWork += new DoWorkEventHandler((state, args) =>
            {

                listener = new TcpListener(piAddr, port);
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                //client.ReceiveTimeout = 10;
                do
                {
                    if (_worker.CancellationPending)
                        break;


                    //Where we will add the actual data
                    String responseData = String.Empty;

                    Byte[] bytes = new Byte[256];
                    String data = null;


                    NetworkStream stream = client.GetStream();
                    
                    int i = 0;

                    // Translate data bytes to a ASCII string.

                    while (i == 0)
                    {


                        try
                        {
                            i = stream.Read(bytes, 0, bytes.Length);
                            Console.WriteLine(i);

                        }
                        catch
                        {
                            Console.WriteLine("Not recieved Data");
                        }

                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                        if (data == String.Empty)
                        {
                            client.Close();
                            stream.Close();
                            listener.Stop();

                            try
                            {
                                listener = new TcpListener(piAddr, port);
                                listener.Start();
                                client = listener.AcceptTcpClient();
                                stream = client.GetStream();// Might not need cause do while will loop back line 69

                            }
                            catch
                            {
                                Console.WriteLine("YOU'RE MAD");

                            }

                        }
                    }

                    // Parse for multiple messages

                    string[] data_vector = data.Split('[', ']');
                    data = data_vector[1];
                    data_vector = data.Split(',');



                    if (data_vector[0] == String.Empty)
                    {
                        continue;
                    }


                    //Parsing for GUI display section no TCP
                    //string time = data_vector[0];
                    double runTime = Convert.ToDouble(data_vector[0]);
                    runTime = Math.Round(runTime, 2);
                    double pH = Convert.ToDouble(data_vector[1]);
                    double temp = Convert.ToDouble(data_vector[2]);
                    double dissolved_oxygen = Convert.ToDouble(data_vector[3]);
                    double orp = Convert.ToDouble(data_vector[4]);
                    string time_of_Day = DateTime.Now.ToString("HH:mm:ss");
                    
                    


                        //allows accesss to controls that are on main thread from the background worker

                        this.Invoke((MethodInvoker)delegate
                        {
                            count++; //count for chart increasing

                            dt.Rows.Add(time_of_Day,
                                        pH,
                                        temp,
                                        dissolved_oxygen,
                                        orp);


                            //Update Threshold grid view start
                            pH_time_text.Text = time_of_Day;
                            temp_time_text.Text = time_of_Day;
                            orp_time_text.Text = time_of_Day;
                            do_time_text.Text = time_of_Day;



                            //Convert string number to actual number for comparison indicator

                            pH_curval_text.Text = pH.ToString();
                            temp_curval_text.Text = temp.ToString();
                            orp_curval_text.Text = orp.ToString();
                            do_curval_text.Text = dissolved_oxygen.ToString();

                            //Ph Threshold Update
                            decimal ph_highThresh = Convert.ToDecimal(ph_hThresh); //global variable: ph_highThreshold
                            decimal ph_lowThresh = Convert.ToDecimal(pH_lThresh);
                            decimal ph_currVal = Convert.ToDecimal(pH_curval_text.Text);

                            update_Threshold(ph_lowThresh, ph_highThresh, ph_currVal, pH_indicator_text);

                            //temp Threshold Update
                            update_Threshold(Convert.ToDecimal(temp_lThresh), Convert.ToDecimal(temp_hThresh),
                                             Convert.ToDecimal(temp_curval_text.Text), temp_indicator_text);

                            //ORP
                            update_Threshold(Convert.ToDecimal(orp_lThresh), Convert.ToDecimal(orp_hThresh),
                                             Convert.ToDecimal(orp_curval_text.Text), orp_indicator_text);

                            //DO
                            update_Threshold(Convert.ToDecimal(do_lThresh), Convert.ToDecimal(do_hThresh),
                                             Convert.ToDecimal(do_curval_text.Text), do_indicator_text);


                            //END

                            chart1.Series["pH"].Points.AddXY(time_of_Day, pH);
                            chart2.Series["Temp"].Points.AddXY(time_of_Day, temp);
                            chart3.Series["DO"].Points.AddXY(time_of_Day, dissolved_oxygen);
                            chart4.Series["ORP"].Points.AddXY(time_of_Day, orp);
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                            LegendItem lit = new LegendItem();
                            lit.Color = Color.Red;
                            lit.SeriesName = "pH";




                            chart1.Series["pH"].Points[count - 1].Color = System.Drawing.Color.Red;
                            chart2.Series["Temp"].Points[count - 1].Color = System.Drawing.Color.Black;
                            chart3.Series["DO"].Points[count - 1].Color = System.Drawing.Color.Yellow;
                            chart4.Series["ORP"].Points[count - 1].Color = System.Drawing.Color.Blue;

                            Console.WriteLine("Count:"+count+"");
                   
                        });


                    } while (true);
            });

            _worker.RunWorkerAsync();

            //Enabel and disable start and stop menu buttons
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            

            

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            _worker.CancelAsync();
            listener.Stop();
            
        }

        private void saveToFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); 
            string time = DateTime.Now.ToString("MM_dd_yy__HH_mm_ss");
            saveFileDialog.FileName = "waterTest_" + time+".csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dt.ToCSV(saveFileDialog.FileName);
            }


        }

        private void setupDataGridView()
        {



            //DataTable
            dt.Columns.Add("Time", typeof(string));
            //dt.Columns.Add("Run Time",typeof(float));
            dt.Columns.Add("pH", typeof(float));
            //dt.Columns.Add("Turbidity", typeof(float));
            dt.Columns.Add("Temp", typeof(float));
            dt.Columns.Add("Dissolved Oxygen", typeof(float));
            dt.Columns.Add("Oxygen Reduction Potential", typeof(float));

            dataGridView1.DataSource = dt;

            
            this.Text = "Water Quality Testing Software "+ DateTime.Now.ToString("MM/dd/yy");
            
            
            //Setting up thresholds to be global versions for initial changes            
            //ph 0-15
            pH_lThresh_text.Text = pH_lThresh;
            pH_hThresh_text.Text = ph_hThresh;


            //temp 40-80
            temp_lThresh_text.Text = temp_lThresh;
            temp_hThresh_text.Text = temp_hThresh;

            //orp -1500 1500
            orp_lThresh_text.Text = orp_lThresh;
            orp_hThresh_text.Text = orp_hThresh;

            //DO 0 100%
            do_lThresh_text.Text = do_lThresh;
            do_hThresh_text.Text = do_hThresh;
        }


        private void update_Threshold(decimal low, decimal high, decimal current, System.Windows.Forms.TextBox indicator_text)
        {
            if (current >= low && current <= high)
            {   //within bounds
                indicator_text.Text = "Good";
                indicator_text.ForeColor = Color.White;
                indicator_text.BackColor = Color.Green;
            }
            else if (current > high)
            {
                indicator_text.Text = "High";
                indicator_text.ForeColor = Color.Black;
                indicator_text.BackColor = Color.Red;
            }
            else if (current < low)
            {
                indicator_text.Text = "Low";
                indicator_text.ForeColor = Color.Black;
                indicator_text.BackColor = Color.Red;
            }
        }

        //Threshold Leave EVENTS

        private void ph_hThresh_Leave(object sender, EventArgs e)
        {
            
            try
            {
                //Try float conversion
                Convert.ToInt32(pH_hThresh_text.Text);
                ph_hThresh   = pH_hThresh_text.Text; //setting global variable to change when set
            }
            catch 
            {
                MessageBox.Show("Enter a valid number");
                pH_hThresh_text.Text = "15";
            }
        }

        private void ph_lThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(pH_lThresh_text.Text);
                pH_lThresh = pH_lThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                pH_lThresh_text.Text = "0";
            }
        }

        private void temp_hThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(temp_hThresh_text.Text);
                temp_hThresh = temp_hThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                temp_hThresh_text.Text = "80";
            }
        }

        private void temp_lThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(temp_lThresh_text.Text);
                temp_lThresh = temp_lThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                temp_lThresh_text.Text = "40";
            }
        }

        private void do_hThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(do_hThresh_text.Text);
                do_hThresh = do_hThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                do_hThresh_text.Text = "100";
            }
        }

        private void do_lThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(do_lThresh_text.Text);
                do_lThresh = do_lThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                do_lThresh_text.Text = "0";
            }
        }

        private void orp_hThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(orp_hThresh_text.Text);
                orp_hThresh = orp_hThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                orp_hThresh_text.Text = "1500";
            }
        }

        private void orp_lThresh_Leave(object sender, EventArgs e)
        {
            try
            {
                //Try float conversion
                Convert.ToInt32(orp_lThresh_text.Text);
                orp_lThresh = orp_lThresh_text.Text; //setting global variable to change when set
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                orp_lThresh_text.Text = "-1500";
            }
        }
    }


    //This utility takes datatable and writes it to a csv file
    public static class CSVUtlity
    {

        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

    }
}
