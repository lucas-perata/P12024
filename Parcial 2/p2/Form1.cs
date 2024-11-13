using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        // Vectores ya ordenados 
        string[] datosAlumnos = {
                "1001;Juan;Pérez",
                "1002;Ana;Gómez",
                "1003;Carlos;Sosa",
                "1004;María;López",
                "1005;Pedro;Martínez"
            };

        string[] datosNotas = {
                "1001;2024-11-01;Matemáticas;8",
                "1001;2024-10-01;Historia;3",
                "1002;2024-03-03;Programación;10",
                "1002;2024-11-02;Historia;9",
                "1003;2024-11-03;Ciencias;7",
                "1003;2024-05-05;Sistemas;4",
                "1004;2024-11-04;Lengua;8",
                "1004;2024-04-04;Historia;6",
                "1005;2024-11-05;Geografía;9",
                "1005;2024-11-03;Física;8",
            };

        GestorPromedio gestorPromedios;
        public Form1()
        {
            InitializeComponent();
            gestorPromedios = new GestorPromedio();
            this.alumnosGrid.DataSource = ListarAlumnos();
            this.notasGrid.DataSource = ListarNotas();
        }

        private Nota[] ListarNotas()
        {
            List<Nota> notas = new List<Nota>(); 

            foreach(string dato in datosNotas)
            {
                string[] linea = dato.Split(';');

                Nota nota = new Nota()
                {
                    Legajo = int.Parse(linea[0]),
                    Fecha = DateTime.Parse(linea[1]),
                    Materia = linea[2],
                    Valor = int.Parse(linea[3])
                }; 

                notas.Add(nota);
            }

            return notas.ToArray();
        }

        private Alumno[] ListarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            foreach (string dato in datosAlumnos)
            {
                string[] linea = dato.Split(';');
                Alumno alumno = new Alumno()
                {
                    Legajo = int.Parse(linea[0]),
                    Nombre = linea[1],
                    Apellido = linea[2],
                };

                alumnos.Add(alumno);
            }

            return alumnos.ToArray();
        }

        private Promedio[] ListarPromedios()
        {
            List<Promedio> promedios = new List<Promedio>();

            return promedios.ToArray();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Promedio[] promedios = gestorPromedios.ObtenerPromedios(ListarAlumnos(), ListarNotas());
            this.promediosGrid.DataSource = promedios;
            this.mayorPromedioLabel.Text = gestorPromedios.ObtenerMejorPromedio(promedios).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
