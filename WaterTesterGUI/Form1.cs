using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            chart1.Titles.Add("Ph vs Time");



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

                    Thread.Sleep(100); //delay for false data

                    string time = DateTime.Now.ToString("HH:mm:ss");
                    Random r = new Random();

                    //allows accesss to controls that are on main thread from the background worker

                    this.Invoke((MethodInvoker)delegate
                    {
                        count++; //count for chart increasing
                        double ph = Math.Round(r.NextDouble(), 2);

                        dt.Rows.Add(time, ph,
                                      Math.Round(r.NextDouble(), 2),
                                      Math.Round(r.NextDouble(), 2),
                                      Math.Round(r.NextDouble(), 2));

                        chart1.Series["ph"].Points.AddXY(count, ph);
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
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
            dt.Columns.Add("ph", typeof(float));
            dt.Columns.Add("Temp", typeof(float));
            dt.Columns.Add("Water Pressure", typeof(float));
            dt.Columns.Add("Turbidity", typeof(float));

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
