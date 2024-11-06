using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_B
{
    internal class Nota
    {

        public int DNI { get; set; }
        public DateTime Fecha { get; set; }
        public int ValorNota { get; set; }

        public Nota(string linea)
        {
            var datos = linea.Split(";");
            DNI = int.Parse(datos[0]);
            Fecha = DateTime.Parse(datos[1]);
            ValorNota = int.Parse(datos[2]);
        }

        public Nota(int dni, DateTime fecha, int valorNota)
        {
            DNI = dni; 
            Fecha = fecha;
            ValorNota = valorNota;
        }

        public string ObtenerRegistro()
        {
            return String.Format("{0};{1};{2}", DNI, Fecha, ValorNota);
        }

    }
}
