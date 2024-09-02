using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);

            foreach(int num in fibo(n))
            {
                listView1.Items.Add(num.ToString());
            }

        }

        public static int[] fibo(int n)
        {
            int[] nums = new int[n]; nums[0] = 0; nums[1] = 1;

            for(int i = 2; i < n; i++)
            {
               nums[i] = nums[i-1] + nums[i-2];
            }

            return nums;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
