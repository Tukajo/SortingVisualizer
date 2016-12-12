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
            foreach(DataPoint p in chart1.Series["Series1"].Points)
            {
                Console.WriteLine(p);
            }
            chart1.Series["Series1"].Points.
        }

        public void swapChartIndices(int o, int n)
        {
            DataPoint temp;
            temp = chart1.Series["Series1"].Points.ElementAt(o);
            chart1.Series["Series1"].Points.RemoveAt(o) 
            //chart1.Series["Series1"].Points.InsertXY(n,)
                
                chart1.Series["Series1"].Points.ElementAt(n);

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
    }
}
