using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OxyPlot;

namespace SortingVisualizer
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool hasSelectedAlgorithm;
        int selectedIndex;

        public Form1()
        {
            InitializeComponent();

            chart1.Series.Add("Series1");
            chart1.Series["Series1"].SetDefault(true);
            chart1.Series["Series1"].Enabled = true;
            chart1.Visible = true;

            for (int q = 0; q < 10; q++)
            {
                int first = rnd.Next(1, 15);
                int second = rnd.Next(1, 15);
                chart1.Series["Series1"].Points.AddXY(first, second);
            }
            chart1.Show();
            Controls.Add(chart1);
            chart1.Show();

            algorithmComboBox.Items.Add("MergeSort");
            algorithmComboBox.Items.Add("QuickSort");
            algorithmComboBox.Items.Add("BubbleSort");
            algorithmComboBox.Items.Add("HeapSort");
        }

        private void algorithm_Menu_SelectIndexChanged(object Sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)Sender;
            selectedIndex = cmb.SelectedIndex;
            MessageBox.Show("ss " + selectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            for (int i = 0; i < dataSizeTrackBar.Value;i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, i);
            }
        }

        private void runButton_MouseClick(object sender, MouseEventArgs e)
        {
            int[] numbers = { 4, 6, 0, 7, 1, 2, 6, 3, 8 };

            if (selectedIndex == 0)
            {

            }
            else if(selectedIndex == 1)
            {

            }
            else if(selectedIndex == 2)
            {
                Bubblesort.Execute(numbers);
            }
            else if(selectedIndex == 3)
            {
                Heapsort.Execute(numbers);
            }
            else
            {
                MessageBox.Show("Please select an algorithm to visualize");
            }
        }
    }
}
