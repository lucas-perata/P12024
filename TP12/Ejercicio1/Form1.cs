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

        Cola cola = new Cola();
        int count = 0; 
        public Form1()
        {
            InitializeComponent();
            this.label6.Text = "En espera - Próximo destino: Puerto Madero";
            Listar(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pasajero pasajero = new Pasajero()
            {
                Nombre = this.textBox1.Text
            };

            cola.Encolar(pasajero);

            Listar();

            this.textBox1.Text = String.Empty; 
        }

        private void Listar()
        {
            this.listBox1.Items.Clear();

            MostrarEnPantalla(cola.Inicio, this.listBox1);
        }

        private void MostrarEnPantalla(Pasajero _pasajero, ListBox _lista)
        {
            if(_pasajero != null)
            {
                _lista.Items.Add(_pasajero.Nombre);

                if(_pasajero.Siguiente != null)
                {
                    MostrarEnPantalla(_pasajero.Siguiente, _lista);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cola.ContarPasajeros() >= 1)
            {
                cola.Desencolar();
                count++;
                this.label4.Text = count.ToString();
                Listar(); 
            }
          
            if(count == 2)
            {
                this.label6.Text = "En camino";
                MessageBox.Show("Combi llena - Parte hacia ...");
                this.button1.Enabled = false; 
            }
        }
    }
    
}
