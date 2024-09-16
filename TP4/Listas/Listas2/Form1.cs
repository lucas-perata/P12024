using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas2
{
    public partial class Ejercicio2 : Form
    {

        ListaEnlazada alumnos = new ListaEnlazada();
        Alumno nodoSeleccionado;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            GenerarLista();
        }

        private void GenerarLista() 
        {
            this.dataGridView1.Rows.Clear();
            Listar(alumnos.NodoInicial);
        }

        private void Listar(Alumno alumno)
        {
            if(alumno != null)
            {
                dataGridView1.Rows[0].Cells[0].Value = alumno.Nombre;
                dataGridView1.Rows[0].Cells[1].Value = alumno.Apellido;
                dataGridView1.Rows[0].Cells[2].Value = alumno.DNI;
                dataGridView1.Rows[0].Cells[3].Value = alumno.FechaNacimiento;
                dataGridView1.Rows[0].Cells[4].Value = alumno.Direccion;
                dataGridView1.Rows[0].Cells[5].Value = alumno.Telefono; 

                if (alumno.Siguiente != null)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = alumno.Nombre;
                    dataGridView1.Rows[n].Cells[1].Value = alumno.Apellido;
                    dataGridView1.Rows[n].Cells[2].Value = alumno.DNI;
                    dataGridView1.Rows[n].Cells[3].Value = alumno.FechaNacimiento;
                    dataGridView1.Rows[n].Cells[4].Value = alumno.Direccion;
                    dataGridView1.Rows[n].Cells[5].Value = alumno.Telefono;

                    Listar(alumno.Siguiente);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.nombre.Text;
            alumno.Direccion = this.direccion.Text;
            alumno.DNI = Convert.ToInt32(this.dni.Value);
            alumno.Telefono = Convert.ToInt32(this.telefono.Text);

            int dni = Convert.ToInt32(this.dniAux.Value);

            alumnos.AgregarAntesSeleccionado(dni, alumno);
            GenerarLista();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.nombre.Text;
            alumno.Direccion = this.direccion.Text;
            alumno.DNI = Convert.ToInt32(this.dni.Value);
            alumno.Telefono = Convert.ToInt32(this.telefono.Text);

            int dni = Convert.ToInt32(this.dniAux.Value);


            alumnos.AgregarDespuesSeleccionado(dni,alumno);
            GenerarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.nombre.Text; 
            alumno.Direccion = this.direccion.Text;
            alumno.DNI = Convert.ToInt32(this.dni.Value);
            alumno.Telefono = Convert.ToInt32(this.telefono.Text);

            alumnos.AgregarAlPrincipio(alumno);
            GenerarLista();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            alumnos.EliminarAlumno(Convert.ToInt32(this.dniAux.Value));
            GenerarLista(); 
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = this.nombre.Text;
            alumno.Apellido = this.apellido.Text;
            alumno.Direccion = this.direccion.Text;
            alumno.DNI = Convert.ToInt32(this.dni.Value);
            alumno.Telefono = Convert.ToInt32(this.telefono.Text);

            alumnos.ActualizarAlumno(alumno);
            GenerarLista(); 
        }
    }
}
