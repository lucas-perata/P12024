using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas5
{
    public partial class Ejercicio5 : Form
    {
        ListaDoblementeEnlazada pacientes = new ListaDoblementeEnlazada();
        Paciente nodoSeleccionado;
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (paciente != null)
            {
                dataGridView1.Rows[0].Cells[0].Value = paciente.Codigo.ToString();
                dataGridView1.Rows[0].Cells[1].Value = paciente.Nombre;
                dataGridView1.Rows[0].Cells[2].Value = paciente.Apellido;
                dataGridView1.Rows[0].Cells[4].Value = paciente.Telefono;
                dataGridView1.Rows[0].Cells[3].Value = paciente.Direccion;

                if (paciente.Siguiente != null)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = paciente.Codigo.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = paciente.Nombre;
                    dataGridView1.Rows[n].Cells[2].Value = paciente.Apellido;
                    dataGridView1.Rows[n].Cells[4].Value = paciente.Telefono;
                    dataGridView1.Rows[n].Cells[3].Value = paciente.Direccion;

                    Listar(paciente.Siguiente);
                }
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente();
            nuevoPaciente.Nombre = this.nombre.Text;
            nuevoPaciente.Apellido = this.apellido.Text; 
            nuevoPaciente.Direccion = this.direccion.Text;
            nuevoPaciente.Telefono = Convert.ToInt32(this.telefono.Value);
            nuevoPaciente.Codigo = Convert.ToInt32(this.codigo.Value);

            pacientes.AgregarPrincipio(nuevoPaciente);
            GenerarLista();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(this.codigoAux.Text);

            pacientes.Eliminar(cod);

            GenerarLista(); 
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Nombre = this.nombre.Text;
            paciente.Apellido = this.apellido.Text;
            paciente.Telefono = Convert.ToInt32(this.telefono.Value);
            paciente.Direccion = this.direccion.Text;

            pacientes.Actualizar(Convert.ToInt32(this.codigo.Value), paciente);

            GenerarLista(); 
        }
    }
}
