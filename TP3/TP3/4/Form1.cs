﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0; 
            int a = 0;  
            int resultado = 0;
            a = tx1.Text == "" ? 0 : Convert.ToInt32(tx1.Text);
            b = textBox2.Text == "" ? 0 : Convert.ToInt32(textBox2.Text);

      


            if (radioButton1.Checked)
            {
                resultado = a + b;
            }
            else if (radioButton2.Checked)
            {
                resultado = a - b;
            }
            else if (radioButton3.Checked)
            {
                resultado = a * b;
            }
            else if (radioButton4.Checked)
            {
                resultado = a / b;
            }
            else if (radioButton5.Checked) {
                resultado = b * b; 
            }
            else if (radioButton6.Checked)
            {
                resultado = b / 2;
            }

            textBox3.Text = resultado.ToString(); 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true) { tx1.Enabled = false; }
            else { tx1.Enabled = true; }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) { tx1.Enabled = false; }
            else { tx1.Enabled = true; }
        }
    }
}