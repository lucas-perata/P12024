using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        ListaEnlazadaSimple Pacientes = new ListaEnlazadaSimple();
        Paciente nodoSeleccionado; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_load(object sender, EventArgs e)
        {
            GenerarLista();
        }

        private void GenerarLista()
        {
            this.listaPacientes.Items.Clear();  
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
