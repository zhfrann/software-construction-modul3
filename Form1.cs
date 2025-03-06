using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022330008
{
    public partial class Form1 : Form
    {
        ArrayList numbers = new ArrayList();
        //int[] numbers = new int[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            //numbers.Add(1);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "1";
            } else
            {
                lblOutput.Text += "1";
            }

            //if (numbers.Length == 0)
            //{
            //    numbers[0] = 1;
            //} else if (numbers.Length == 1)
            //{
            //    numbers[1] = 1;
            //} else if (numbers.Length == 2)
            //{
            //    numbers[2] = 1;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //numbers.Add(2);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "2";
            }
            else
            {
                lblOutput.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //numbers.Add(3);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "3";
            }
            else
            {
                lblOutput.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //numbers.Add(4);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "4";
            }
            else
            {
                lblOutput.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //numbers.Add(5);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "5";
            }
            else
            {
                lblOutput.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //numbers.Add(6);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "6";
            }
            else
            {
                lblOutput.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //numbers.Add(7);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "7";
            }
            else
            {
                lblOutput.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //numbers.Add(8);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "8";
            }
            else
            {
                lblOutput.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //numbers.Add(9);
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "9";
            }
            else
            {
                lblOutput.Text += "9";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text.Length > 0)
            {
                int num = Int32.Parse(lblOutput.Text);
                numbers.Add(num);
                lblOutput.Text = "";
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            numbers.Add(lblOutput.Text);
            int result = 0;
            foreach (var item in numbers)
            {
                result += Convert.ToInt32(item);
            }
            lblOutput.Text = "Hasil : " + result.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text.Length == 0)
            {
                lblOutput.Text = "0";
            }
            else
            {
                lblOutput.Text += "0";
            }
        }
    }
}
