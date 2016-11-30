using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class QuickSort
    {
        static public void Execute()
        {

            //User input for number of characters to use in sort
            Console.WriteLine("Input the number of characters or strings you wish to sort: ");
            int numChar = Convert.ToInt32(Console.ReadLine());

            // Create an unsorted array of string elements            
            string[] unsorted = new string[numChar];

            //User input characters into array
            for (int i = 0; i < numChar; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Enter another Character or String: ");
                    unsorted[i] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter a character or String: ");
                    unsorted[i] = Console.ReadLine();
                }

            }

            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
