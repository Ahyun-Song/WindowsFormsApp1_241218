using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_241218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int num1 = 10;
            int num2 = 3;

            int[] result = GetQuotientAndRemainder(num1, num2);

            textBox_print.Text = result[0].ToString() + "\r\n";
            textBox_print.Text += result[1].ToString();
        }

        int[] GetQuotientAndRemainder(int num1, int num2)
        {
            if (num2 == 0)
            {
                return new int[] { 0, 0 };
            }

            return new int[] { num1 / num2, num1 % num2 };
        }


    }
}
