using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value);
            List<int> primos = new List<int>();

            for(int i = a; i < b; i++)
            {
                if(esPrimo(i))
                {
                    primos.Add(i);
                }
            }
            

            foreach(int i in primos)
            {
                listBox1.Items.Add(i);
            }
        }

        public static bool esPrimo(int n)
        {
            if (n <= 1) { return false; }
            if(n == 2) { return true; }

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % 2 == 0) { return false; }
            }

            return true; 
        }
    }
}
