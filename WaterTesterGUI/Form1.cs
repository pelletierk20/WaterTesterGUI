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

namespace WaterTesterGUI
{
    public partial class Form1 : Form
    {
        
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
                do
                {
                    if (_worker.CancellationPending)
                        break;

                    //Where we will add the actual data
                    String responseData = String.Empty;

                    Int32 port = 631;
                    IPAddress piAddr = IPAddress.Parse("192.168.56.1");

                    TcpListener listener = new TcpListener(piAddr,port);
                    listener.Start();

                    Byte[] bytes = new Byte[256];
                    String data = null;

                    TcpClient client = listener.AcceptTcpClient();

                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                        string[] data_vector = data.Split('[', ']');
                        data = data_vector[1];
                        data_vector = data.Split(','); //ph:0 turb:1 temp:2
                        //Console.WriteLine("Received: {0}", data);




                        //Parsing for GUI display section no TCP
                        double pH = Convert.ToDouble(data_vector[0]);
                        double turbidity = Convert.ToDouble(data_vector[1]);
                        double temp = Convert.ToDouble(data_vector[2]);

                        //Thread.Sleep(100); //delay for false data

                        string time = DateTime.Now.ToString("HH:mm:ss");
                        Random r = new Random();

                        //allows accesss to controls that are on main thread from the background worker

                        this.Invoke((MethodInvoker)delegate
                        {
                            count++; //count for chart increasing
                            
                            dt.Rows.Add(time,
                                        pH,
                                        turbidity,
                                        temp,
                                        Math.Round(r.NextDouble(), 2),
                                        Math.Round(r.NextDouble(), 2));

                            chart1.Series["ph"].Points.AddXY(count, pH);
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        });


                    }






















                    

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
            dt.Columns.Add("Time",typeof(string));
            dt.Columns.Add("pH", typeof(float));
            dt.Columns.Add("Turbidity", typeof(float));
            dt.Columns.Add("Temp", typeof(float));
            dt.Columns.Add("Dissolved Oxygen", typeof(float));
            dt.Columns.Add("Oxygen Reduction Potential", typeof(float));

            dataGridView1.DataSource = dt;
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
