using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monto = Convert.ToInt32(textBox1.Text);
            int tna = Convert.ToInt32(textBox2.Text);
            int dias = Convert.ToInt32(textBox3.Text);
            int intereses = (monto * tna * dias) / 36500;

            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = monto;
            dataGridView1.Rows[n].Cells[1].Value = tna;
            dataGridView1.Rows[n].Cells[2].Value = dias;
            dataGridView1.Rows[n].Cells[3].Value = intereses;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
