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
                statisticsLabel.Text = "MERGESORT" + "\n\nBig-O Notation" + "\nAverage: O(n log(n))" + "\n\nWorst: O(n log(n))" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + 0;

                algorithmLabel.Text = "MERGESORT";
                ps1.Text = "While length(left) > 0 and length(right) > 0 \n         if first(left) = first(right)";
                ps2.Text = "                append first(left) to result \n                 left = rest(left)";
                ps3.Text = "            else \n             append first(right) to result";
                ps4.Text = "            right = rest(right)";
                ps5.Text = "if length(left) > 0 /n          append left to result";
                ps6.Text = "if length(right) > 0 /n         append right to result";
                ps7.Text = "return result";
                ps8.Text = "if length(m) = 1 \n             return m";
                ps9.Text = "else \n                         middle = length(m) / 2";
                ps10.Text = "               for each x in m up to middle \n             add x to the left";
                ps11.Text = "for each x in m after middle \n                add x to the right";
            }
            else if (selectedIndex == 1)
            {
                statisticsLabel.Text = "QUICKSORT" + "\n\nBig-O Notation" + "\nAverage. O: O(n log(n))" + "\n\nWorst: O(n^2)" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + 0;

                algorithmLabel.Text = "QUICKSORT";
                ps1.Text = "while i <= j";
                ps2.Text = "   while elements[i].isCompared(pivot) < 0";
                ps3.Text = "            i++";
                ps4.Text = "   while elements[j].isCompared(pivot) > 0";
                ps5.Text = "            j--";
                ps6.Text = "   If i <= j";
                ps7.Text = "        comparable temp = elements[i]";
                ps8.Text = "        elements[i] = elements[j] \n        elements[j] = temp";
                ps9.Text = "          i++ \n          j++";
                ps10.Text = "  If left < j \n               Quicksort(elements,left,j)";
                ps11.Text = "  If i < right \n              Quicksort(elements,i,right)";
            }
            else if (selectedIndex == 2)
            {
                statisticsLabel.Text = "BUBBLESORT" + "\n\nBig-O Notation" + "\nAverage: O(n^2)" + "\n\nWorst: O(n^2)" + "\n\nBest: O(n)" + "\n\nComparisons: " + 0;

                algorithmLabel.Text = "BUBBLESORT";
                ps1.Text = "loop = list.count";
                ps2.Text = "For i = 0 to loop - 1 \n        swapped = false";
                ps3.Text = "For j = 0 to loop - 1 \n        if list[j] > list[j+1] then";
                ps4.Text = "                swap(list[j], list[j+1]) \n                 swapped = true";
                ps5.Text = "if not swapped \n       break";
                ps6.Text = "";
                ps7.Text = "";
                ps8.Text = "";
                ps9.Text = "";
                ps10.Text = "";
                ps11.Text = "";
            }
            else if (selectedIndex == 3)
            {
                statisticsLabel.Text = "HEAPSORT" + "\n\nBig-O Notation" + "\nAverage: O(n log(n))" + "\n\nWorst: O(n log(n))" + "\n\nBest: O(n log(n))" + "\n\nComparisons: " + 0;

                algorithmLabel.Text = "HEAPSORT";
                ps1.Text = "if left < sizeofheap and input[left] > input[index] \n          largest = left";
                ps2.Text = "else";
                ps3.Text = "       largest = index";
                ps4.Text = "if right < sizeofheap and input[right] > input[largest] \n      largest = index";
                ps5.Text = "if largest != index \n          int temp = input[index]";
                ps6.Text = "            input[index] = input[largest] \n            input[largest] = temp";
                ps7.Text = "            heapsortmax(input, heapsize, largest)";
                ps8.Text = "";
                ps9.Text = "";
                ps10.Text = "";
                ps11.Text = "";
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
                int[] numbers = { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                //Bubblesort.Execute(randomizedArray);
                Bubblesort.Execute(numbers);
            }
            else if (selectedIndex == 3)
            {
                Heapsort.Execute(randomizedArray);

            }
            else
            {
                MessageBox.Show("Please select an algorithm to visualize.");
                return;
            }
        }
    }

}
