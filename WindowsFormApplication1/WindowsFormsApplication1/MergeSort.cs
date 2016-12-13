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
    public class MergeSort
    {
        Chart chart1;
        Label previousLabel;

        public void DoMergeSort(Chart chartRef, int[] input)
        {
            chart1 = chartRef;
            Execute(input);
        }
         public void DoMerge(int[] numbers, int left, int middle, int right)
        {

            int[] temp = new int[numbers.Count()];
            int i, leftEnd, numberElements, tempPosition;

            leftEnd = (middle - 1);
            tempPosition = left;
            numberElements = (right - left + 1);

            HighlightLabel(Form1.ps1);
            while ((left <= leftEnd) && (middle <= right))
            {
                HighlightLabel(Form1.ps2);
                if (numbers[left] <= numbers[middle])
                {
                    HighlightLabel(Form1.ps8);
                    temp[tempPosition++] = numbers[left++];
                }
                else
                {
                    HighlightLabel(Form1.ps9);
                    temp[tempPosition++] = numbers[middle++];
                }
            }

            while (left <= leftEnd)
            {
                HighlightLabel(Form1.ps5);
                temp[tempPosition++] = numbers[left++];
            }

            while (middle <= right)
            {
                HighlightLabel(Form1.ps6);
                temp[tempPosition++] = numbers[middle++];
            }

            for (i = 0; i < numberElements; i++)
            {
                HighlightLabel(Form1.ps10);
                numbers[right] = temp[right];
                HighlightLabel(Form1.ps11);
                reconstructChart(numbers);
                right--;
            }
        }

         public void MergeSortRecursive(int[] input, int left, int right)
        {

            int middle;

            if(right > left)
            {
                middle = (right + left) / 2;
                MergeSortRecursive(input, left, middle);
                MergeSortRecursive(input, (middle + 1), right);
                HighlightLabel(Form1.ps7);
                DoMerge(input, left, (middle + 1), right);
            }
        }

        public void reconstructChart(int[] input)
        {

            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < input.Count(); i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, input[i]);
            }
            chart1.Refresh();

        }

        public void Execute(int[] input)
        {
            MergeSortRecursive(input, 0, input.Length - 1);
        }

        void HighlightLabel(Label label)
        {
            if (previousLabel != null)
            {
                previousLabel.BackColor = SystemColors.Control;
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
