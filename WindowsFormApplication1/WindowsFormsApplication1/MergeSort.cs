using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace SortingVisualizer
{
    public class MergeSort
    {
        Chart chart1;
        public void DoMergeSort(Chart chartRef, int[] input)
        {
            chart1 = chartRef;
            Execute(input);
        }
         public void DoMerge(int[] numbers, int left, int middle, int right)
        {
            System.Threading.Thread.Sleep(100);

            int[] temp = new int[numbers.Count()];
            int i, leftEnd, numberElements, tempPosition;

            leftEnd = (middle - 1);
            tempPosition = left;
            numberElements = (right - left + 1);

            while ((left <= leftEnd) && (middle <= right))
            {
                if (numbers[left] <= numbers[middle])
                    temp[tempPosition++] = numbers[left++];
                else
                    temp[tempPosition++] = numbers[middle++];
            }

            while (left <= leftEnd)
                temp[tempPosition++] = numbers[left++];

            while (middle <= right)
                temp[tempPosition++] = numbers[middle++];

            for (i = 0; i < numberElements; i++)
            {

                numbers[right] = temp[right];
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
    }
}
