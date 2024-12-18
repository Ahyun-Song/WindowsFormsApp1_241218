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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            bool userInput = true;
            bool result = PlayGame(userInput);

            textBox_print.Text = "승리";
            textBox_print.Text = "패배";
        }

        public bool PlayGame(bool userInput)
        {
            Random random = new Random();
            int coinTossResult = random.Next(2);
            bool randomBool = (coinTossResult == 1);

            if(userInput == randomBool)
            {
               // textBox_print.Text = "승리";
            }
            else
            {
               // textBox_print.Text = "패배";
            }

            return userInput == randomBool;
        }
    }
}
