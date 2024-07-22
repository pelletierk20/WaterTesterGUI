namespace WaterTesterGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orp_indicator_text = new System.Windows.Forms.TextBox();
            this.orp_lThresh_text = new System.Windows.Forms.TextBox();
            this.orp_hThresh_text = new System.Windows.Forms.TextBox();
            this.orp_curval_text = new System.Windows.Forms.TextBox();
            this.orp_time_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.do_indicator_text = new System.Windows.Forms.TextBox();
            this.do_lThresh_text = new System.Windows.Forms.TextBox();
            this.do_hThresh_text = new System.Windows.Forms.TextBox();
            this.do_curval_text = new System.Windows.Forms.TextBox();
            this.do_time_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.temp_indicator_text = new System.Windows.Forms.TextBox();
            this.temp_lThresh_text = new System.Windows.Forms.TextBox();
            this.temp_hThresh_text = new System.Windows.Forms.TextBox();
            this.temp_curval_text = new System.Windows.Forms.TextBox();
            this.temp_time_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pH_indicator_text = new System.Windows.Forms.TextBox();
            this.pH_lThresh_text = new System.Windows.Forms.TextBox();
            this.pH_hThresh_text = new System.Windows.Forms.TextBox();
            this.pH_time_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pH_curval_text = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testOptionsToolStripMenuItem
            // 
            this.testOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.saveToFileToolStripMenuItem1});
            this.testOptionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.testOptionsToolStripMenuItem.Name = "testOptionsToolStripMenuItem";
            this.testOptionsToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.testOptionsToolStripMenuItem.Text = "Test Options";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            this.saveToFileToolStripMenuItem1.Size = new System.Drawing.Size(179, 30);
            this.saveToFileToolStripMenuItem1.Text = "Save to File";
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(614, 423);
            this.dataGridView1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea25.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea25);
            legend25.Name = "Legend1";
            this.chart1.Legends.Add(legend25);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Legend = "Legend1";
            series25.Name = "pH";
            this.chart1.Series.Add(series25);
            this.chart1.Size = new System.Drawing.Size(484, 231);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 507);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.orp_indicator_text, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.orp_lThresh_text, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.orp_hThresh_text, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.orp_curval_text, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.orp_time_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.do_indicator_text, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.do_lThresh_text, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.do_hThresh_text, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.do_curval_text, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.do_time_text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.temp_indicator_text, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_lThresh_text, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_hThresh_text, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_curval_text, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_time_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pH_indicator_text, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.pH_lThresh_text, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pH_hThresh_text, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pH_time_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pH_curval_text, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 423);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // orp_indicator_text
            // 
            this.orp_indicator_text.Location = new System.Drawing.Point(433, 339);
            this.orp_indicator_text.Name = "orp_indicator_text";
            this.orp_indicator_text.ReadOnly = true;
            this.orp_indicator_text.Size = new System.Drawing.Size(80, 23);
            this.orp_indicator_text.TabIndex = 29;
            // 
            // orp_lThresh_text
            // 
            this.orp_lThresh_text.Location = new System.Drawing.Point(347, 339);
            this.orp_lThresh_text.Name = "orp_lThresh_text";
            this.orp_lThresh_text.Size = new System.Drawing.Size(80, 23);
            this.orp_lThresh_text.TabIndex = 28;
            this.orp_lThresh_text.Leave += new System.EventHandler(this.orp_lThresh_Leave);
            // 
            // orp_hThresh_text
            // 
            this.orp_hThresh_text.Location = new System.Drawing.Point(261, 339);
            this.orp_hThresh_text.Name = "orp_hThresh_text";
            this.orp_hThresh_text.Size = new System.Drawing.Size(80, 23);
            this.orp_hThresh_text.TabIndex = 27;
            this.orp_hThresh_text.Leave += new System.EventHandler(this.orp_hThresh_Leave);
            // 
            // orp_curval_text
            // 
            this.orp_curval_text.Location = new System.Drawing.Point(175, 339);
            this.orp_curval_text.Name = "orp_curval_text";
            this.orp_curval_text.ReadOnly = true;
            this.orp_curval_text.Size = new System.Drawing.Size(80, 23);
            this.orp_curval_text.TabIndex = 26;
            // 
            // orp_time_text
            // 
            this.orp_time_text.Location = new System.Drawing.Point(89, 339);
            this.orp_time_text.Name = "orp_time_text";
            this.orp_time_text.ReadOnly = true;
            this.orp_time_text.Size = new System.Drawing.Size(80, 23);
            this.orp_time_text.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 51);
            this.label10.TabIndex = 24;
            this.label10.Text = "Oxygen Reduction Potential";
            // 
            // do_indicator_text
            // 
            this.do_indicator_text.Location = new System.Drawing.Point(433, 255);
            this.do_indicator_text.Name = "do_indicator_text";
            this.do_indicator_text.ReadOnly = true;
            this.do_indicator_text.Size = new System.Drawing.Size(80, 23);
            this.do_indicator_text.TabIndex = 23;
            // 
            // do_lThresh_text
            // 
            this.do_lThresh_text.Location = new System.Drawing.Point(347, 255);
            this.do_lThresh_text.Name = "do_lThresh_text";
            this.do_lThresh_text.Size = new System.Drawing.Size(80, 23);
            this.do_lThresh_text.TabIndex = 22;
            this.do_lThresh_text.Leave += new System.EventHandler(this.do_lThresh_Leave);
            // 
            // do_hThresh_text
            // 
            this.do_hThresh_text.Location = new System.Drawing.Point(261, 255);
            this.do_hThresh_text.Name = "do_hThresh_text";
            this.do_hThresh_text.Size = new System.Drawing.Size(80, 23);
            this.do_hThresh_text.TabIndex = 21;
            this.do_hThresh_text.Leave += new System.EventHandler(this.do_hThresh_Leave);
            // 
            // do_curval_text
            // 
            this.do_curval_text.Location = new System.Drawing.Point(175, 255);
            this.do_curval_text.Name = "do_curval_text";
            this.do_curval_text.ReadOnly = true;
            this.do_curval_text.Size = new System.Drawing.Size(80, 23);
            this.do_curval_text.TabIndex = 20;
            // 
            // do_time_text
            // 
            this.do_time_text.Location = new System.Drawing.Point(89, 255);
            this.do_time_text.Name = "do_time_text";
            this.do_time_text.ReadOnly = true;
            this.do_time_text.Size = new System.Drawing.Size(80, 23);
            this.do_time_text.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dissolved Oxygen";
            // 
            // temp_indicator_text
            // 
            this.temp_indicator_text.Location = new System.Drawing.Point(433, 171);
            this.temp_indicator_text.Name = "temp_indicator_text";
            this.temp_indicator_text.ReadOnly = true;
            this.temp_indicator_text.Size = new System.Drawing.Size(80, 23);
            this.temp_indicator_text.TabIndex = 17;
            // 
            // temp_lThresh_text
            // 
            this.temp_lThresh_text.Location = new System.Drawing.Point(347, 171);
            this.temp_lThresh_text.Name = "temp_lThresh_text";
            this.temp_lThresh_text.Size = new System.Drawing.Size(80, 23);
            this.temp_lThresh_text.TabIndex = 16;
            this.temp_lThresh_text.Leave += new System.EventHandler(this.temp_lThresh_Leave);
            // 
            // temp_hThresh_text
            // 
            this.temp_hThresh_text.Location = new System.Drawing.Point(261, 171);
            this.temp_hThresh_text.Name = "temp_hThresh_text";
            this.temp_hThresh_text.Size = new System.Drawing.Size(80, 23);
            this.temp_hThresh_text.TabIndex = 15;
            this.temp_hThresh_text.Leave += new System.EventHandler(this.temp_hThresh_Leave);
            // 
            // temp_curval_text
            // 
            this.temp_curval_text.Location = new System.Drawing.Point(175, 171);
            this.temp_curval_text.Name = "temp_curval_text";
            this.temp_curval_text.ReadOnly = true;
            this.temp_curval_text.Size = new System.Drawing.Size(80, 23);
            this.temp_curval_text.TabIndex = 14;
            // 
            // temp_time_text
            // 
            this.temp_time_text.Location = new System.Drawing.Point(89, 171);
            this.temp_time_text.Name = "temp_time_text";
            this.temp_time_text.ReadOnly = true;
            this.temp_time_text.Size = new System.Drawing.Size(80, 23);
            this.temp_time_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Temp";
            // 
            // pH_indicator_text
            // 
            this.pH_indicator_text.Location = new System.Drawing.Point(433, 87);
            this.pH_indicator_text.Name = "pH_indicator_text";
            this.pH_indicator_text.ReadOnly = true;
            this.pH_indicator_text.Size = new System.Drawing.Size(80, 23);
            this.pH_indicator_text.TabIndex = 11;
            // 
            // pH_lThresh_text
            // 
            this.pH_lThresh_text.Location = new System.Drawing.Point(347, 87);
            this.pH_lThresh_text.Name = "pH_lThresh_text";
            this.pH_lThresh_text.Size = new System.Drawing.Size(80, 23);
            this.pH_lThresh_text.TabIndex = 10;
            this.pH_lThresh_text.Leave += new System.EventHandler(this.ph_lThresh_Leave);
            // 
            // pH_hThresh_text
            // 
            this.pH_hThresh_text.Location = new System.Drawing.Point(261, 87);
            this.pH_hThresh_text.Name = "pH_hThresh_text";
            this.pH_hThresh_text.Size = new System.Drawing.Size(80, 23);
            this.pH_hThresh_text.TabIndex = 9;
            this.pH_hThresh_text.Leave += new System.EventHandler(this.ph_hThresh_Leave);
            // 
            // pH_time_text
            // 
            this.pH_time_text.Location = new System.Drawing.Point(89, 87);
            this.pH_time_text.Name = "pH_time_text";
            this.pH_time_text.ReadOnly = true;
            this.pH_time_text.Size = new System.Drawing.Size(80, 23);
            this.pH_time_text.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "pH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Indicator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Low Thresh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "High Thresh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // pH_curval_text
            // 
            this.pH_curval_text.Location = new System.Drawing.Point(175, 87);
            this.pH_curval_text.Name = "pH_curval_text";
            this.pH_curval_text.ReadOnly = true;
            this.pH_curval_text.Size = new System.Drawing.Size(80, 23);
            this.pH_curval_text.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart4);
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart4
            // 
            chartArea26.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea26);
            legend26.Name = "Legend1";
            this.chart4.Legends.Add(legend26);
            this.chart4.Location = new System.Drawing.Point(603, 244);
            this.chart4.Name = "chart4";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Legend = "Legend1";
            series26.Name = "ORP";
            this.chart4.Series.Add(series26);
            this.chart4.Size = new System.Drawing.Size(484, 231);
            this.chart4.TabIndex = 5;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            chartArea27.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea27);
            legend27.Name = "Legend1";
            this.chart3.Legends.Add(legend27);
            this.chart3.Location = new System.Drawing.Point(6, 244);
            this.chart3.Name = "chart3";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.Name = "DissolvedOxygen";
            this.chart3.Series.Add(series27);
            this.chart3.Size = new System.Drawing.Size(484, 231);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea28.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea28);
            legend28.Name = "Legend1";
            this.chart2.Legends.Add(legend28);
            this.chart2.Location = new System.Drawing.Point(603, 6);
            this.chart2.Name = "chart2";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "Temp";
            this.chart2.Series.Add(series28);
            this.chart2.Size = new System.Drawing.Size(484, 231);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Water Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox orp_indicator_text;
        private System.Windows.Forms.TextBox orp_lThresh_text;
        private System.Windows.Forms.TextBox orp_hThresh_text;
        private System.Windows.Forms.TextBox orp_curval_text;
        private System.Windows.Forms.TextBox orp_time_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox do_indicator_text;
        private System.Windows.Forms.TextBox do_lThresh_text;
        private System.Windows.Forms.TextBox do_hThresh_text;
        private System.Windows.Forms.TextBox do_curval_text;
        private System.Windows.Forms.TextBox do_time_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox temp_indicator_text;
        private System.Windows.Forms.TextBox temp_lThresh_text;
        private System.Windows.Forms.TextBox temp_hThresh_text;
        private System.Windows.Forms.TextBox temp_curval_text;
        private System.Windows.Forms.TextBox temp_time_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pH_indicator_text;
        private System.Windows.Forms.TextBox pH_lThresh_text;
        private System.Windows.Forms.TextBox pH_hThresh_text;
        private System.Windows.Forms.TextBox pH_time_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pH_curval_text;
    }
}

