using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_B
{
    internal class Alumno
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno(string linea)
        {
            var datos = linea.Split(";");
            DNI = int.Parse(datos[0]);
            Nombre = datos[1];
            Apellido = datos[2];
        }

        public Alumno(int dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string ObtenerRegistro()
        {
            return String.Format("{0};{1};{2}", DNI, Nombre, Apellido);
        }
    }
}
