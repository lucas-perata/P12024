using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        ColaConPrioridad _cola = new ColaConPrioridad();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            listCola.Items.Clear();
            MostrarEnPantalla(_cola.Inicio);
        }

        private void MostrarEnPantalla(Cliente cliente)
        {
            if(cliente != null)
            {
                listCola.Items.Add(cliente);

                if(cliente.Siguiente != null)
                {
                    MostrarEnPantalla(cliente.Siguiente);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Prioridad = Convert.ToInt32(this.numericUpDown1.Value);
            _cola.Encolar(cliente);
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cola.Desencolar();
            Mostrar();
        }
    }
}
