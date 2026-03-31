using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            double degrees = 0.0;
            double result = 0.0;
            if (!double.TryParse(textBox1.Text, out degrees))
            {
                label1.Text = "Ошибка ввода числа";
                return;
            }
            double radians = degrees * Math.PI / 180.0;
            string item = listBox1.SelectedItem.ToString();
            if (item == "tg")
            {
                result = Math.Tan(radians);
            }
            else if (item == "sin")
            {
                result = Math.Sin(radians);
            }
            else if (item == "log")
            {
                result = Math.Log(degrees);
            }
            label1.Text = result.ToString();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
