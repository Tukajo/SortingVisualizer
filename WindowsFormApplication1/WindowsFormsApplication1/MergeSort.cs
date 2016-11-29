using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizeer
{
    public class MergeSort
    {
        static public void DoMerge(int[] numbers, int left, int middle, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, numberElements, tempPosition;

            leftEnd = (middle - 1);
            tempPosition = left;
            numberElements = (right - left + 1);

            while((left <= leftEnd) && (middle <= right))
            {
                if(numbers[left] <= numbers[middle])
                {
                    temp[tempPosition++] = numbers[left++];
                }
                else
                {
                    temp[tempPosition++] = numbers[middle++];
                }
            }

            while(left <= leftEnd)
            {
                temp[tempPosition++] = numbers[left++];
            }

            while(middle <= right)
            {
                temp[tempPosition++] = numbers[middle++];
            }

            for(i = 0; i < numberElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int middle;

            if(right > left)
            {
                middle = (right + left) / 2;
                MergeSortRecursive(numbers, left, middle);
                MergeSortRecursive(numbers, (middle + 1), right);

                DoMerge(numbers, left, (middle + 1), right);
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] numbers = { 4, 6, 0, 7, 1, 2, 6, 3, 8 };
        //    int length = 9;

        //    Console.WriteLine("Mergesort: ");
        //    MergeSortRecursive(numbers, 0, length - 1);

        //    for(int i = 0; i < length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
    }
}
