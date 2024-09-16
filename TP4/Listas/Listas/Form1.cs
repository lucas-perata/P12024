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
        ListaEnlazadaSimple pacientes = new ListaEnlazadaSimple();
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
            this.dataGridView1.Rows.Clear();
            Listar(pacientes.NodoInicial);
        }

        private void Listar(Paciente paciente)
        {
            if(paciente != null)
            {
                dataGridView1.Rows[0].Cells[0].Value = paciente.Codigo.ToString();
                dataGridView1.Rows[0].Cells[1].Value = paciente.Nombre;
                dataGridView1.Rows[0].Cells[2].Value = paciente.Apellido;
                dataGridView1.Rows[0].Cells[3].Value = paciente.Telefono;
                dataGridView1.Rows[0].Cells[4].Value = paciente.Direccion;

                if (paciente.Siguiente != null)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = paciente.Codigo.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = paciente.Nombre;
                    dataGridView1.Rows[n].Cells[2].Value = paciente.Apellido;
                    dataGridView1.Rows[n].Cells[3].Value = paciente.Telefono;
                    dataGridView1.Rows[n].Cells[4].Value = paciente.Direccion;

                    Listar(paciente.Siguiente);
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            pacientes.AgregarAlPrincipio(this.nombre.Text, Convert.ToInt32(this.codigo.Text), this.apellidoText.Text, this.direccion.Text, Convert.ToInt32(this.telefono.Text));
            GenerarLista();
            nombre.Text = "";
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            GenerarLista();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(this.posicion.Value);

            pacientes.QuitarPosicion(n);

            GenerarLista();
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(this.codigo.Value);

            pacientes.ActualizarPaciente(cod, this.nombre.Text, this.apellidoText.Text, 
                this.direccion.Text, Convert.ToInt32(this.telefono.Value));

            GenerarLista();
        }
    }
}
