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
    public class Bubblesort
    {
        Chart chart1;
        Label previousLabel;

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
                HighlightLabel(Form1.ps1);
                for (int j = 0; j < input.Count() - 1; j++)
                {
                    HighlightLabel(Form1.ps2);
                    if (input.ElementAt(j).YValues.First() > input.ElementAt(j + 1).YValues.First())
                    {
                        HighlightLabel(Form1.ps3);
                        swapChartIndices(j, j + 1);
                        HighlightLabel(Form1.ps4);
                    }
                    HighlightLabel(Form1.ps5);
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
