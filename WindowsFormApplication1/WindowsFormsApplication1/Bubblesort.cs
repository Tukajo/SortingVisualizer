using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SortingVisualizer
{
    public class Bubblesort
    {
        Chart chart1;
        public void DoBubbleSort(Chart input)
        {
            chart1 = input;
            Execute(input.Series["Series1"].Points);
        }

        public void Execute(DataPointCollection input)
        {
            // int temp = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                for (int j = 0; j < input.Count() - 1; j++)
                {

                    if (input.ElementAt(j).YValues.First() > input.ElementAt(j + 1).YValues.First())
                    {
                        //Console.WriteLine("Xvalue is " + input.ElementAt(j).XValue + " J is " + j);
                        swapChartIndices(j, j + 1);
                        System.Threading.Thread.Sleep(100);
                    }
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
    }
}
