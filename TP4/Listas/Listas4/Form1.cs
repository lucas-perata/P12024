using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas4
{
    public partial class Ejercicio4 : Form
    {
        ListaEnlazadaCircular alumnos = new ListaEnlazadaCircular();
        Alumno nodoSeleccionado; 
        public Ejercicio4()
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
            Listar();
        }

        private void Listar()
        {
           if(alumnos.NodoInicial != null)
            {
                Alumno actual = alumnos.NodoInicial;

                do
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = actual.Nombre;
                    dataGridView1.Rows[n].Cells[1].Value = actual.Apellido;
                    dataGridView1.Rows[n].Cells[2].Value = actual.Edad;
                    dataGridView1.Rows[n].Cells[3].Value = actual.DNI;

                    actual = actual.Siguiente; 

                } while (actual != alumnos.NodoInicial);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.apellido.Text; 
            alumno.Edad = Convert.ToInt32(this.edad.Value);
            alumno.DNI = Convert.ToInt32(this.dni.Value); 

            alumnos.AgregarPrimero(alumno);

            GenerarLista();
        }

        private void btnAgregarUltimo_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.apellido.Text;
            alumno.Edad = Convert.ToInt32(this.edad.Value);
            alumno.DNI = Convert.ToInt32(this.dni.Value);

            alumnos.AgregarFinal(alumno);

            GenerarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(this.dniAux.Value);

            alumnos.Eliminar(dni);

            GenerarLista(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.apellido.Text;
            alumno.Edad = Convert.ToInt32(this.edad.Value);
            alumno.DNI = Convert.ToInt32(this.dni.Value);

            alumnos.ActualizarAlumno(alumno);

            GenerarLista();
        }
    }
}
