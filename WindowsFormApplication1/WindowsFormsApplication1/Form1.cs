using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingVisualizer
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public int[] randomizedArray;
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
            randomizedArray = new int[dataSizeTrackBar.Value];
            for (int i = 0; i < dataSizeTrackBar.Value;i++)
            {
                randomizedArray[i] = i;
                
            }
            Shuffle(randomizedArray);
            for(int i = 0; i < randomizedArray.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, randomizedArray[i]);
            }
        }

        public void swapChartIndices(int o, int n)
        {
            DataPoint temp1, temp2;
            temp1 = chart1.Series["Series1"].Points.ElementAt(o);
            temp2 = chart1.Series["Series1"].Points.ElementAt(n);
            //Remove both
            chart1.Series["Series1"].Points.RemoveAt(o);
            chart1.Series["Series1"].Points.RemoveAt(n);
            //Swap both
            chart1.Series["Series1"].Points.AddXY(temp1.XValue, temp2.YValues.GetValue(0));
            chart1.Series["Series1"].Points.AddXY(temp2.XValue, temp1.YValues.GetValue(0));
            chart1.Invalidate();

        }

        static void Shuffle(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(rnd.NextDouble() * (n - i));
                int t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        private void runButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedIndex == 0)
            {

            }
            else if (selectedIndex == 1)
            {

            }
            else if (selectedIndex == 2)
            {
                Bubblesort.Execute(randomizedArray);
            }
            else if (selectedIndex == 3)
            {
                Heapsort.Execute(randomizedArray);
            }
            else
            {
                MessageBox.Show("Please select an algorithm to visualize");
            }
        }
    }

}
