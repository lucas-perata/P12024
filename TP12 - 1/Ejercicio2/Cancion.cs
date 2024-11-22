using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cancion
    {

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public decimal Duracion { get; set; }
        public Cancion Siguiente { get; set; }
        public Cancion Anterior { get; set; }

        public override string ToString()
        {
            return $"{Numero} - {Nombre} - {Duracion}";
        }
    }
}
