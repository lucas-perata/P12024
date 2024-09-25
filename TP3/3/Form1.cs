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
        List<int> List = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List.Add(Convert.ToInt32(textBox1.Text));

            textBox2.Clear();

            foreach (int i in List) 
            {
                textBox2.Text += i.ToString();
                textBox2.Text += " ";
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            var n = textBox2.Text;
            var sum = 0;

            foreach (int i in List)
            {
                sum += i;
            }

            label1.Text = sum.ToString();
        }
    }
}
