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
            chart1 = input;
            QuickSortRecursive(input.Series["Series1"].Points, 0, input.Series["Series1"].Points.Count() - 1);
        }

        public int Quicksort(DataPointCollection input, int left, int right)
        {
            var pivot = input.ElementAt(left).YValues.First();
            while (true)
            {
                while (input.ElementAt(left).YValues.First() < pivot)
                    left++;

                while (input.ElementAt(right).YValues.First() > pivot)
                    right--;

                if (left < right)
                {
                    swapChartIndices(right, left);

                    System.Threading.Thread.Sleep(50);
                }
                else
                {
                    return right;
                }
            }
        }

        public void QuickSortRecursive(DataPointCollection input, int left, int right)
        {
            if (left < right)
            {
                int pivot = Quicksort(input, left, right);

                if (pivot > 1)
                    QuickSortRecursive(input, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSortRecursive(input, pivot + 1, right);
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
