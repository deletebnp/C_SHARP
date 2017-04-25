/// Tommie Terrell
/// SDEV 240
/// multiplication table



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)/// this button  takes the input from txtInput
        {
            int num;
            
            
            num = Convert.ToInt32(txtInput.Text); /// User inputs number
            multiplicationTable(num); /// Sends variable to multiplication method

        }

        private void multiplicationTable(int num) /// multiplicationTable  calculates multiples of inputed number
        {
            string table = " ";
            for (int i = 2; i <= 10; i++)
            {
                table += String.Format("{0}x{1,-2}={2}\r\n", num, i, num * i);
            }
            label1.Text +=(table); /// displays answer in label for user
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
