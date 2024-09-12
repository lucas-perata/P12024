using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public int tiradas = 0;
        public int uno = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); 
            int dado1 = rnd.Next(1, 7);
            int dado2 = rnd.Next(1, 7);
            tiradas++;

            if(dado1 == 1 || dado2==1) { uno++; }
            if (dado1 == 2 || dado2 == 2) { dos++; }
            if (dado1 == 3 || dado2 == 3) { tres++; }
            if (dado1 == 4 || dado2 == 4) { cuatro++; }
            if (dado1 == 5 || dado2 == 5) { cinco++; }
            if (dado1 == 6 || dado2 == 6) { seis++; }

            

            if(tiradas == 1) { dataGridView1.Rows.Add(); }

            dataGridView1.Rows[0].Cells[0].Value = uno;
            dataGridView1.Rows[0].Cells[1].Value = dos;
            dataGridView1.Rows[0].Cells[2].Value = tres;
            dataGridView1.Rows[0].Cells[3].Value = cuatro;
            dataGridView1.Rows[0].Cells[4].Value = cinco;
            dataGridView1.Rows[0].Cells[5].Value = seis;

            dataGridView1.Rows[1].Cells[0].Value = (100 * uno) / tiradas;
            dataGridView1.Rows[1].Cells[1].Value = (100 * dos) / tiradas;
            dataGridView1.Rows[1].Cells[2].Value = (100 * tres) / tiradas;
            dataGridView1.Rows[1].Cells[3].Value = (100 * cuatro) / tiradas;
            dataGridView1.Rows[1].Cells[4].Value = (100 * cinco) / tiradas;
            dataGridView1.Rows[1].Cells[5].Value = (100 * seis) / tiradas;

            label1.Text = dado1.ToString();
            label2.Text = dado2.ToString();
            label3.Text = tiradas.ToString();

        }
    }
}
