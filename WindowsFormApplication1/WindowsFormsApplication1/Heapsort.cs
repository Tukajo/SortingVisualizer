using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class Heapsort
    {
        public static void Execute(int[] input)
        {
            int heapSize = input.Length;
            for(int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                HeapsortMax(input, heapSize, i);
            }

            for(int i = input.Length - 1; i > 0; i--)
            {
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                HeapsortMax(input, heapSize, 0);
            }
        }

        static void HeapsortMax(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if(largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                HeapsortMax(input, heapSize, largest);
            }
        }
    }
}
