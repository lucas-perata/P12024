using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int segundos = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            segundos = hScrollBar1.Value;
            timerLabel.Text = segundos.ToString();
        }

        private void activarBtn_Click(object sender, EventArgs e)
        {
            if (segundos > 0)  
                timer1.Enabled = true;  
            else 
                MessageBox.Show("Seleccione un tiempo mayor a 0"); 

        }

        private int RandomGenerator()
        {
           return rnd.Next(0 , 500);      
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tiempoRestanteLabel.Text = segundos.ToString();
            numerosLabel.Text = RandomGenerator().ToString();

            if (segundos == 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                segundos--;
            }
        }
    }
}
