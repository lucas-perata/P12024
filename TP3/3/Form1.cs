using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> List = new List<string>();

            List.Add(textBox1.Text);

            textBox1.Clear();

            foreach (string i in List) 
            {
                textBox2.Text += i;
                textBox2.Text += " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var n = textBox2.Text;
            var sum = 0; 

            foreach(char i in n)
            {
                sum += Convert.ToInt32(i);
            }

            label1.Text = sum.ToString();
        }
    }
}
