﻿namespace SortingVisualizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmMenuLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pseudocodeLabel1 = new System.Windows.Forms.Label();
            this.psuedocodeLabel2 = new System.Windows.Forms.Label();
            this.psuedocodeLabel3 = new System.Windows.Forms.Label();
            this.psuedocodeLabel4 = new System.Windows.Forms.Label();
            this.psuedocodeLabel5 = new System.Windows.Forms.Label();
            this.psuedocodeLabel6 = new System.Windows.Forms.Label();
            this.psuedocodeLabel7 = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.pseudocodeLabel8 = new System.Windows.Forms.Label();
            this.pseudocodeLabel9 = new System.Windows.Forms.Label();
            this.pseudocodeLabel10 = new System.Windows.Forms.Label();
            this.pseudocodeLabel11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSizeTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Location = new System.Drawing.Point(12, 34);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(172, 21);
            this.algorithmComboBox.TabIndex = 0;
            this.algorithmComboBox.Text = "-- Select Item --";
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithm_Menu_SelectIndexChanged);
            // 
            // algorithmMenuLabel
            // 
            this.algorithmMenuLabel.AutoSize = true;
            this.algorithmMenuLabel.Location = new System.Drawing.Point(12, 9);
            this.algorithmMenuLabel.Name = "algorithmMenuLabel";
            this.algorithmMenuLabel.Size = new System.Drawing.Size(83, 13);
            this.algorithmMenuLabel.TabIndex = 1;
            this.algorithmMenuLabel.Text = "Select Algorithm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Psuedocode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Data Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Statistics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Graph";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(335, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(497, 508);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataSizeTrackBar
            // 
            this.dataSizeTrackBar.Location = new System.Drawing.Point(12, 87);
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
            this.runButton.Location = new System.Drawing.Point(12, 151);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(179, 92);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "Run!";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.runButton_MouseClick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 249);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(179, 49);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.Location = new System.Drawing.Point(211, 34);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(118, 264);
            this.statisticsLabel.TabIndex = 12;
            this.statisticsLabel.Text = "No stats yet!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pseudocodeLabel10);
            this.panel1.Controls.Add(this.pseudocodeLabel9);
            this.panel1.Controls.Add(this.pseudocodeLabel8);
            this.panel1.Controls.Add(this.algorithmLabel);
            this.panel1.Controls.Add(this.psuedocodeLabel7);
            this.panel1.Controls.Add(this.psuedocodeLabel6);
            this.panel1.Controls.Add(this.psuedocodeLabel5);
            this.panel1.Controls.Add(this.psuedocodeLabel4);
            this.panel1.Controls.Add(this.psuedocodeLabel3);
            this.panel1.Controls.Add(this.psuedocodeLabel2);
            this.panel1.Controls.Add(this.pseudocodeLabel1);
            this.panel1.Location = new System.Drawing.Point(838, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 508);
            this.panel1.TabIndex = 13;
            // 
            // pseudocodeLabel1
            // 
            this.pseudocodeLabel1.Location = new System.Drawing.Point(0, 37);
            this.pseudocodeLabel1.Name = "pseudocodeLabel1";
            this.pseudocodeLabel1.Size = new System.Drawing.Size(261, 43);
            this.pseudocodeLabel1.TabIndex = 0;
            this.pseudocodeLabel1.Text = "label";
            // 
            // psuedocodeLabel2
            // 
            this.psuedocodeLabel2.Location = new System.Drawing.Point(0, 80);
            this.psuedocodeLabel2.Name = "psuedocodeLabel2";
            this.psuedocodeLabel2.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel2.TabIndex = 1;
            this.psuedocodeLabel2.Text = "label";
            // 
            // psuedocodeLabel3
            // 
            this.psuedocodeLabel3.Location = new System.Drawing.Point(2, 123);
            this.psuedocodeLabel3.Name = "psuedocodeLabel3";
            this.psuedocodeLabel3.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel3.TabIndex = 2;
            this.psuedocodeLabel3.Text = "label";
            // 
            // psuedocodeLabel4
            // 
            this.psuedocodeLabel4.Location = new System.Drawing.Point(2, 166);
            this.psuedocodeLabel4.Name = "psuedocodeLabel4";
            this.psuedocodeLabel4.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel4.TabIndex = 3;
            this.psuedocodeLabel4.Text = "label";
            // 
            // psuedocodeLabel5
            // 
            this.psuedocodeLabel5.Location = new System.Drawing.Point(2, 209);
            this.psuedocodeLabel5.Name = "psuedocodeLabel5";
            this.psuedocodeLabel5.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel5.TabIndex = 4;
            this.psuedocodeLabel5.Text = "label";
            // 
            // psuedocodeLabel6
            // 
            this.psuedocodeLabel6.Location = new System.Drawing.Point(0, 252);
            this.psuedocodeLabel6.Name = "psuedocodeLabel6";
            this.psuedocodeLabel6.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel6.TabIndex = 5;
            this.psuedocodeLabel6.Text = "label";
            // 
            // psuedocodeLabel7
            // 
            this.psuedocodeLabel7.Location = new System.Drawing.Point(2, 295);
            this.psuedocodeLabel7.Name = "psuedocodeLabel7";
            this.psuedocodeLabel7.Size = new System.Drawing.Size(261, 43);
            this.psuedocodeLabel7.TabIndex = 6;
            this.psuedocodeLabel7.Text = "label";
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.Location = new System.Drawing.Point(-2, 0);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(261, 21);
            this.algorithmLabel.TabIndex = 7;
            this.algorithmLabel.Text = "Select an Algorithm";
            // 
            // pseudocodeLabel8
            // 
            this.pseudocodeLabel8.Location = new System.Drawing.Point(3, 338);
            this.pseudocodeLabel8.Name = "pseudocodeLabel8";
            this.pseudocodeLabel8.Size = new System.Drawing.Size(261, 43);
            this.pseudocodeLabel8.TabIndex = 8;
            this.pseudocodeLabel8.Text = "label";
            // 
            // pseudocodeLabel9
            // 
            this.pseudocodeLabel9.Location = new System.Drawing.Point(3, 381);
            this.pseudocodeLabel9.Name = "pseudocodeLabel9";
            this.pseudocodeLabel9.Size = new System.Drawing.Size(261, 43);
            this.pseudocodeLabel9.TabIndex = 9;
            this.pseudocodeLabel9.Text = "label";
            // 
            // pseudocodeLabel10
            // 
            this.pseudocodeLabel10.Location = new System.Drawing.Point(2, 424);
            this.pseudocodeLabel10.Name = "pseudocodeLabel10";
            this.pseudocodeLabel10.Size = new System.Drawing.Size(261, 43);
            this.pseudocodeLabel10.TabIndex = 10;
            this.pseudocodeLabel10.Text = "label";
            // 
            // pseudocodeLabel11
            // 
            this.pseudocodeLabel11.Location = new System.Drawing.Point(839, 501);
            this.pseudocodeLabel11.Name = "pseudocodeLabel11";
            this.pseudocodeLabel11.Size = new System.Drawing.Size(261, 43);
            this.pseudocodeLabel11.TabIndex = 11;
            this.pseudocodeLabel11.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 584);
            this.Controls.Add(this.pseudocodeLabel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dataSizeTrackBar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algorithmMenuLabel);
            this.Controls.Add(this.algorithmComboBox);
            this.Name = "Form1";
            this.Text = "Sorting Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSizeTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label psuedocodeLabel7;
        private System.Windows.Forms.Label psuedocodeLabel6;
        private System.Windows.Forms.Label psuedocodeLabel5;
        private System.Windows.Forms.Label psuedocodeLabel4;
        private System.Windows.Forms.Label psuedocodeLabel3;
        private System.Windows.Forms.Label psuedocodeLabel2;
        private System.Windows.Forms.Label pseudocodeLabel1;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label pseudocodeLabel10;
        private System.Windows.Forms.Label pseudocodeLabel9;
        private System.Windows.Forms.Label pseudocodeLabel8;
        private System.Windows.Forms.Label pseudocodeLabel11;
    }
}

