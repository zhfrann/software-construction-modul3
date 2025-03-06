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
            numbers.Add(1);

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
            numbers.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numbers.Add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numbers.Add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numbers.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbers.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbers.Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbers.Add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbers.Add(9);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "")
            {
                lblOutput.Text = "0";
            }
        }
    }
}
