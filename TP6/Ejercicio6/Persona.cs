using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Persona
    {
        public int Prioridad { get; set; }
        public bool Ticket { get; set; }
        public Persona Siguiente { get; set; }

        public override string ToString()
        {
            return $"Prioridad {Prioridad} - Ticket {Ticket}";
        }
    }

 
}
