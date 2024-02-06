using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_to_int
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < textBox1.Text.Length; i++) 
            {
                total *= 10;
                total += textBox1.Text[i] - 48;
            }
            label1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = Regex.Replace(textBox1.Text, "[A-Za-z ]", "");
            double parsedValue = double.Parse(value);
            label1.Text = parsedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 0; i < textBox1.Text.Length;i++)
            {
                if (textBox1.Text[i] >= 48 && textBox1.Text[i] <= 57)
                {
                    total *= 10;
                    total += textBox1.Text[i] - 48;
                }
                else
                {
                    break;
                }
            }   
            label1.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] >= 48 && textBox1.Text[i] <= 57)
                {
                    total *= 10;
                    total += textBox1.Text[i] - 48;
                }
                else
                {
                    total = 0;
                    break;
                }
            }
            label1.Text = total.ToString();





        }
    }
}
