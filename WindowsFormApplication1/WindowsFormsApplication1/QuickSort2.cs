using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingVisualizer
{
    public class QuickSort2
    {
        Chart chart1;

        public void DoQuickSort(Chart input)
        {
            //string[] unsorted = { "a", "e", "g", "z", "k", "l", "w", "p", "h" };

            //Console.WriteLine("Before Sort: ");

            // Print the unsorted array
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    Console.Write(unsorted[i] + " ");
            //}

            // Sort the array
            chart1 = input;
            //Quicksort(input, 0, input.Series["Series1"].Points.Count() - 1);
            Quicksort(input.Series["Series1"].Points, 0, input.Series["Series1"].Points.Count() - 1);

            //Console.WriteLine("\n\nAfter Sort: ");

            // Print the sorted array
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    Console.Write(unsorted[i] + " ");
            //}

            //Console.ReadLine();
        }

        public void Quicksort(DataPointCollection input, int left, int right)
        {
            int i = left, j = right;
            var pivot = input[(left + right) / 2];

            while (i <= j)
            {
                //while (input[i].CompareTo(pivot) < 0)
                //{
                //    i++;
                //}

                //while (input[j].CompareTo(pivot) > 0)
                //{
                //    j--;
                //}

                while (input[i].YValues.First() < pivot.YValues.First())
                {
                    i++;
                }

                while (input[j].YValues.First() > pivot.YValues.First())
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    //IComparable tmp = input[i];
                    //input[i] = input[j];
                    //input[j] = tmp;
                    swapChartIndices(i, j);

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(input, left, j);
            }

            if (i < right)
            {
                Quicksort(input, i, right);
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
