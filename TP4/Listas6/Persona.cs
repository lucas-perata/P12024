using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas6
{
    internal class Persona
    {
        public int Edad;
        public int Numero; 
        public Persona Siguiente;
        public Persona Anterior;

        public override string ToString()
        {
            return $"Posición: {Numero}, Edad: {Edad}";
        }
    }
}
