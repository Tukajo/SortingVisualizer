using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingVisualizer
{
    public class QuickSort2
    {
        Chart chart1;
        Label previousLabel;

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
                HighlightLabel(Form1.ps1);
                while (input.ElementAt(left).YValues.First() < pivot)
                {
                    HighlightLabel(Form1.ps2);
                    left++;
                    HighlightLabel(Form1.ps3);
                }

                while (input.ElementAt(right).YValues.First() > pivot)
                {
                    HighlightLabel(Form1.ps4);
                    right--;
                    HighlightLabel(Form1.ps5);
                }

                if (left < right)
                {
                    HighlightLabel(Form1.ps6);
                    swapChartIndices(right, left);
                    HighlightLabel(Form1.ps7);
                    HighlightLabel(Form1.ps8);
                }
                else
                {
                    HighlightLabel(Form1.ps9);
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
                {
                    HighlightLabel(Form1.ps10);
                    QuickSortRecursive(input, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    HighlightLabel(Form1.ps11);
                    QuickSortRecursive(input, pivot + 1, right);
                }
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

        void HighlightLabel(Label label)
        {
            if (previousLabel != null)
            {
                previousLabel.BackColor = SystemColors.InactiveCaption;
                previousLabel.Refresh();
                System.Threading.Thread.Sleep(10);
            }

            label.BackColor = System.Drawing.Color.Yellow;
            label.Refresh();
            previousLabel = label;
            System.Threading.Thread.Sleep(30);
        }
    }
}
