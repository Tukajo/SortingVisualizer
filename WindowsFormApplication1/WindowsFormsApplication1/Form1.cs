using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            algorithmComboBox.Items.Add("MergeSort");
            algorithmComboBox.Items.Add("QuickSort");
            algorithmComboBox.Items.Add("BubbleSort");
            dataTypeComboBox1.Items.Add("String, 100");
            dataTypeComboBox1.Items.Add("String, 1,000");
            dataTypeComboBox1.Items.Add("String, 10,000");
            dataTypeComboBox1.Items.Add("Integer, 100");
            dataTypeComboBox1.Items.Add("Integer, 1,000");
            dataTypeComboBox1.Items.Add("Integer, 10,000");
        }

        private void algorithm_Menu_SelectIndexChanged(object Sender, EventArgs e)
        {
       
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
