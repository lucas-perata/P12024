using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Persona
    {
        public string Genero { get; set; }
        public int Numero { get; set; }
        public Persona Siguiente { get; set;}

        public override string ToString()
        {
            return $"Posición: {Numero} - Género: {Genero}";
        }

    }
}
