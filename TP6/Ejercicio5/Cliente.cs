using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Cliente
    {
        public int Prioridad { get; set; }
        public Cliente Siguiente { get; set; }
        public Cliente Anterior { get; set; }   

        public override string ToString()
        {
            return $"Prioridad {Prioridad}";
        }
    }
}
