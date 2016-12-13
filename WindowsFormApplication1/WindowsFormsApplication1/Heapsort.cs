using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingVisualizer
{
    public class Heapsort
    {
        Chart chart1;

        public void DoHeapSort(Chart input)
        {
            chart1 = input;
            Execute(input.Series["Series1"].Points);
        }

        //public static void Execute(int[] input)
        //{
        //    int heapSize = input.Length;
        //    for(int i = (heapSize - 1) / 2; i >= 0; i--)
        //    {
        //        HeapsortMax(input, heapSize, i);
        //    }

        //    for(int i = input.Length - 1; i > 0; i--)
        //    {
        //        int temp = input[i];
        //        input[i] = input[0];
        //        input[0] = temp;

        //        heapSize--;
        //        HeapsortMax(input, heapSize, 0);

        //        Console.WriteLine("i: " + input[i]);
        //        MessageBox.Show("i " + input[i]);
        //    }
        //}

        public void Execute(DataPointCollection input)
        {
            int heapSize = input.Count();
            for (int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                HeapsortMax(input, heapSize, i);
            }

            for (int i = input.Count() - 1; i > 0; i--)
            {
                //int temp = input[i];
                //input[i] = input[0];
                //input[0] = temp;
                swapChartIndices(i, 0);

                heapSize--;
                HeapsortMax(input, heapSize, 0);

                //Console.WriteLine("i: " + input[i]);
                //MessageBox.Show("i " + input[i]);
            }
        }

        //static void HeapsortMax(int[] input, int heapSize, int index)
        //{
        //    int left = (index + 1) * 2 - 1;
        //    int right = (index + 1) * 2;
        //    int largest = 0;

        //    if (left < heapSize && input[left] > input[index])
        //        largest = left;
        //    else
        //        largest = index;

        //    if (right < heapSize && input[right] > input[largest])
        //        largest = right;

        //    if(largest != index)
        //    {
        //        int temp = input[index];
        //        input[index] = input[largest];
        //        input[largest] = temp;

        //        HeapsortMax(input, heapSize, largest);
        //    }
        //}

        void HeapsortMax(DataPointCollection input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input.ElementAt(left).YValues.First() > input.ElementAt(index).YValues.First())
                largest = left;
            else
                largest = index;

            if (right < heapSize && input.ElementAt(right).YValues.First() > input.ElementAt(largest).YValues.First())
                largest = right;

            if (largest != index)
            {
                //int temp = input[index];
                //input[index] = input[largest];
                //input[largest] = temp;
                swapChartIndices(index, largest);

                HeapsortMax(input, heapSize, largest);
            }
        }

        public void swapChartIndices(int o, int n)
        {
            DataPoint temp1, temp2;
            temp1 = chart1.Series["Series1"].Points.ElementAt(o);
            temp2 = chart1.Series["Series1"].Points.ElementAt(n);
            double y1, y2;
            y1 = temp2.YValues.First();
            y2 = temp1.YValues.First();
            //Remove both
            chart1.Series["Series1"].Points.ElementAt(o).SetValueY(y1);
            chart1.Series["Series1"].Points.ElementAt(n).SetValueY(y2);
            //Swap both

            chart1.Refresh();
        }
    }
}
