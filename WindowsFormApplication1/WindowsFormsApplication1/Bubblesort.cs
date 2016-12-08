using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class Bubblesort
    {
        public static void Execute(int[] input)
        {
            int temp = 0;

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input.Length - 1; j++)
                {
                    if(input[j] > input[j + 1])
                    {
                        temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                }

                Console.WriteLine(input[i]);
            }
        }
    }
}
