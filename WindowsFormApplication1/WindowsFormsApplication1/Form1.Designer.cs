namespace SortingVisualizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmMenuLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.runButton = new System.Windows.Forms.Button();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pseudocodeLabel10 = new System.Windows.Forms.Label();
            this.pseudocodeLabel9 = new System.Windows.Forms.Label();
            this.pseudocodeLabel8 = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.pseudocodeLabel7 = new System.Windows.Forms.Label();
            this.pseudocodeLabel6 = new System.Windows.Forms.Label();
            this.pseudocodeLabel5 = new System.Windows.Forms.Label();
            this.pseudocodeLabel4 = new System.Windows.Forms.Label();
            this.pseudocodeLabel3 = new System.Windows.Forms.Label();
            this.pseudocodeLabel2 = new System.Windows.Forms.Label();
            this.pseudocodeLabel1 = new System.Windows.Forms.Label();
            this.pseudocodeLabel11 = new System.Windows.Forms.Label();
            this.speedTrackbar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSizeTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Location = new System.Drawing.Point(12, 42);
            this.algorithmComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(172, 24);
            this.algorithmComboBox.TabIndex = 0;
            this.algorithmComboBox.Text = "-- Select Item --";
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithm_Menu_SelectIndexChanged);
            // 
            // algorithmMenuLabel
            // 
            this.algorithmMenuLabel.AutoSize = true;
            this.algorithmMenuLabel.Location = new System.Drawing.Point(12, 11);
            this.algorithmMenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algorithmMenuLabel.Name = "algorithmMenuLabel";
            this.algorithmMenuLabel.Size = new System.Drawing.Size(82, 16);
            this.algorithmMenuLabel.TabIndex = 1;
            this.algorithmMenuLabel.Text = "Select Algorithm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Psuedocode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Data Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Statistics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Graph";
            // 
            // chart1
            // 
            chartArea17.Name = "ChartArea1";
            chartArea18.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea17);
            this.chart1.ChartAreas.Add(chartArea18);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(335, 42);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(497, 625);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataSizeTrackBar
            // 
            this.dataSizeTrackBar.Location = new System.Drawing.Point(12, 107);
            this.dataSizeTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataSizeTrackBar.Maximum = 35;
            this.dataSizeTrackBar.Minimum = 1;
            this.dataSizeTrackBar.Name = "dataSizeTrackBar";
            this.dataSizeTrackBar.Size = new System.Drawing.Size(172, 45);
            this.dataSizeTrackBar.TabIndex = 9;
            this.dataSizeTrackBar.TickFrequency = 50;
            this.dataSizeTrackBar.Value = 10;
            this.dataSizeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(15, 254);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(179, 113);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "Run!";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.runButton_MouseClick);
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.Location = new System.Drawing.Point(211, 42);
            this.statisticsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(118, 325);
            this.statisticsLabel.TabIndex = 12;
            this.statisticsLabel.Text = "No stats yet!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pseudocodeLabel10);
            this.panel1.Controls.Add(this.pseudocodeLabel9);
            this.panel1.Controls.Add(this.pseudocodeLabel8);
            this.panel1.Controls.Add(this.algorithmLabel);
            this.panel1.Controls.Add(this.pseudocodeLabel7);
            this.panel1.Controls.Add(this.pseudocodeLabel6);
            this.panel1.Controls.Add(this.pseudocodeLabel5);
            this.panel1.Controls.Add(this.pseudocodeLabel4);
            this.panel1.Controls.Add(this.pseudocodeLabel3);
            this.panel1.Controls.Add(this.pseudocodeLabel2);
            this.panel1.Controls.Add(this.pseudocodeLabel1);
            this.panel1.Location = new System.Drawing.Point(838, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 625);
            this.panel1.TabIndex = 13;
            // 
            // pseudocodeLabel10
            // 
            this.pseudocodeLabel10.Location = new System.Drawing.Point(2, 522);
            this.pseudocodeLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel10.Name = "pseudocodeLabel10";
            this.pseudocodeLabel10.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel10.TabIndex = 10;
            // 
            // pseudocodeLabel9
            // 
            this.pseudocodeLabel9.Location = new System.Drawing.Point(2, 469);
            this.pseudocodeLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel9.Name = "pseudocodeLabel9";
            this.pseudocodeLabel9.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel9.TabIndex = 9;
            // 
            // pseudocodeLabel8
            // 
            this.pseudocodeLabel8.Location = new System.Drawing.Point(2, 416);
            this.pseudocodeLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel8.Name = "pseudocodeLabel8";
            this.pseudocodeLabel8.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel8.TabIndex = 8;
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.Location = new System.Drawing.Point(-2, 0);
            this.algorithmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(260, 26);
            this.algorithmLabel.TabIndex = 7;
            this.algorithmLabel.Text = "Select an Algorithm";
            // 
            // pseudocodeLabel7
            // 
            this.pseudocodeLabel7.Location = new System.Drawing.Point(2, 363);
            this.pseudocodeLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel7.Name = "pseudocodeLabel7";
            this.pseudocodeLabel7.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel7.TabIndex = 6;
            // 
            // pseudocodeLabel6
            // 
            this.pseudocodeLabel6.Location = new System.Drawing.Point(0, 310);
            this.pseudocodeLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel6.Name = "pseudocodeLabel6";
            this.pseudocodeLabel6.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel6.TabIndex = 5;
            // 
            // pseudocodeLabel5
            // 
            this.pseudocodeLabel5.Location = new System.Drawing.Point(2, 257);
            this.pseudocodeLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel5.Name = "pseudocodeLabel5";
            this.pseudocodeLabel5.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel5.TabIndex = 4;
            // 
            // pseudocodeLabel4
            // 
            this.pseudocodeLabel4.Location = new System.Drawing.Point(2, 205);
            this.pseudocodeLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel4.Name = "pseudocodeLabel4";
            this.pseudocodeLabel4.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel4.TabIndex = 3;
            // 
            // pseudocodeLabel3
            // 
            this.pseudocodeLabel3.Location = new System.Drawing.Point(2, 151);
            this.pseudocodeLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel3.Name = "pseudocodeLabel3";
            this.pseudocodeLabel3.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel3.TabIndex = 2;
            // 
            // pseudocodeLabel2
            // 
            this.pseudocodeLabel2.Location = new System.Drawing.Point(0, 98);
            this.pseudocodeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel2.Name = "pseudocodeLabel2";
            this.pseudocodeLabel2.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel2.TabIndex = 1;
            // 
            // pseudocodeLabel1
            // 
            this.pseudocodeLabel1.Location = new System.Drawing.Point(0, 46);
            this.pseudocodeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel1.Name = "pseudocodeLabel1";
            this.pseudocodeLabel1.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel1.TabIndex = 0;
            // 
            // pseudocodeLabel11
            // 
            this.pseudocodeLabel11.Location = new System.Drawing.Point(839, 617);
            this.pseudocodeLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pseudocodeLabel11.Name = "pseudocodeLabel11";
            this.pseudocodeLabel11.Size = new System.Drawing.Size(260, 53);
            this.pseudocodeLabel11.TabIndex = 11;
            // 
            // speedTrackbar
            // 
            this.speedTrackbar.Location = new System.Drawing.Point(12, 177);
            this.speedTrackbar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.speedTrackbar.Minimum = 1;
            this.speedTrackbar.Name = "speedTrackbar";
            this.speedTrackbar.Size = new System.Drawing.Size(172, 45);
            this.speedTrackbar.TabIndex = 10;
            this.speedTrackbar.TickFrequency = 50;
            this.speedTrackbar.Value = 5;
            this.speedTrackbar.Scroll += new System.EventHandler(this.speedTrackbar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Increment Pause";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "1 sec Sleep";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 719);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speedTrackbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pseudocodeLabel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dataSizeTrackBar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algorithmMenuLabel);
            this.Controls.Add(this.algorithmComboBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Sorting Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSizeTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Label algorithmMenuLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar dataSizeTrackBar;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pseudocodeLabel7;
        private System.Windows.Forms.Label pseudocodeLabel6;
        private System.Windows.Forms.Label pseudocodeLabel5;
        private System.Windows.Forms.Label pseudocodeLabel4;
        private System.Windows.Forms.Label pseudocodeLabel3;
        private System.Windows.Forms.Label pseudocodeLabel2;
        private System.Windows.Forms.Label pseudocodeLabel1;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label pseudocodeLabel10;
        private System.Windows.Forms.Label pseudocodeLabel9;
        private System.Windows.Forms.Label pseudocodeLabel8;
        private System.Windows.Forms.Label pseudocodeLabel11;
        private System.Windows.Forms.TrackBar speedTrackbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

