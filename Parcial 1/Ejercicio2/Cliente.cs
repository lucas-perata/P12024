using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cliente
    {
        public double Importe { get; set; }
        public string Nombre { get; set; }
        public Cliente Siguiente { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Nombre} - Total: {Importe}";
        }
    }
}
