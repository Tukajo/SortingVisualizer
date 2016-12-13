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

        public static Label ps1;
        public static Label ps2;
        public static Label ps3;
        public static Label ps4;
        public static Label ps5;
        public static Label ps6;
        public static Label ps7;
        public static Label ps8;
        public static Label ps9;
        public static Label ps10;
        public static Label ps11;

        public static int comparisonsCount;

        public Form1()
        {
            InitializeComponent();

            ps1 = pseudocodeLabel1;
            ps2 = pseudocodeLabel2;
            ps3 = pseudocodeLabel3;
            ps4 = pseudocodeLabel4;
            ps5 = pseudocodeLabel5;
            ps6 = pseudocodeLabel6;
            ps7 = pseudocodeLabel7;
            ps8 = pseudocodeLabel8;
            ps9 = pseudocodeLabel9;
            ps10 = pseudocodeLabel10;
            ps11 = pseudocodeLabel11;

            comparisonsCount = 0;

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

            if (selectedIndex == 0)
            {
                statisticsLabel.Text = "MERGESORT" + "\n\nBig-O Notation" + "\nAverage: O(n log(n))" + 
                    "\n\nWorst: O(n log(n))" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + comparisonsCount;

                algorithmLabel.Text = "MERGESORT";
                ps1.Text = "Start";
                ps2.Text = "   For";
                ps3.Text = "       If";
                ps4.Text = "           Do";
                ps5.Text = "       Else";
                ps6.Text = "      If";
                ps7.Text = "   If";
                ps8.Text = "   Else";
                ps9.Text = "   If";
                ps10.Text = "  For";
                ps11.Text = "End";
            }
            else if (selectedIndex == 1)
            {
                statisticsLabel.Text = "QUICKSORT" + "\n\nBig-O Notation" + "\nAverage. O: O(n log(n))" + 
                    "\n\nWorst: O(n^2)" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + comparisonsCount;

                algorithmLabel.Text = "QUICKSORT";
                ps1.Text = "Start";
                ps2.Text = "   For";
                ps3.Text = "       If";
                ps4.Text = "           Do";
                ps5.Text = "       Else";
                ps6.Text = "      If";
                ps7.Text = "   If";
                ps8.Text = "   Else";
                ps9.Text = "   If";
                ps10.Text = "  For";
                ps11.Text = "End";
            }
            else if (selectedIndex == 2)
            {
                statisticsLabel.Text = "BUBBLESORT" + "\n\nBig-O Notation" + "\nAverage: O(n^2)" + 
                    "\n\nWorst: O(n^2)" + "\n\nBest: O(n)" + "\n\nComparisons: " + comparisonsCount;

                algorithmLabel.Text = "BUBBLESORT";
                ps1.Text = "Start";
                ps2.Text = "   For";
                ps3.Text = "       If";
                ps4.Text = "           Do";
                ps5.Text = "       Else";
                ps6.Text = "      If";
                ps7.Text = "   If";
                ps8.Text = "   Else";
                ps9.Text = "   If";
                ps10.Text = "  For";
                ps11.Text = "End";
            }
            else if (selectedIndex == 3)
            {
                statisticsLabel.Text = "HEAPSORT" + "\n\nBig-O Notation" + "\nAverage: O(n log(n))" + 
                    "\n\nWorst: O(n log(n))" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + comparisonsCount;

                algorithmLabel.Text = "BUBBELSORT";
                ps1.Text = "Start";
                ps2.Text = "   For";
                ps3.Text = "       If";
                ps4.Text = "           Do";
                ps5.Text = "       Else";
                ps6.Text = "      If";
                ps7.Text = "   If";
                ps8.Text = "   Else";
                ps9.Text = "   If";
                ps10.Text = "  For";
                ps11.Text = "End";
            }
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
            for(int i = 0; i < randomizedArray.Count(); i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, randomizedArray[i]);
            }
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
                new MergeSort().DoMergeSort(chart1,randomizedArray);   
            }
            else if (selectedIndex == 1)
            {
                new QuickSort2().DoQuickSort(chart1);
            }
            else if (selectedIndex == 2)
            {
                new Bubblesort().DoBubbleSort(chart1);
            }
            else if (selectedIndex == 3)
            {
                //Heapsort.Execute(randomizedArray);
                new Heapsort().DoHeapSort(chart1);
            }
            else
            {
                MessageBox.Show("Please select an algorithm to visualize.");
                return;
            }
        }
    }

}
