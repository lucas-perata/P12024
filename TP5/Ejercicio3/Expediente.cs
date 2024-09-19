using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Expediente
    {
        public DateTime Fecha {  get; set; }
        public int Numero { get; set; }
        public string Caratula { get; set; }
        public Expediente Siguiente { get; set;}

        public override string ToString()
        {
            return $"Expediente nro: {Numero} - fecha: {Fecha} - carátula {Caratula}";
        }

        public int Comparar(Expediente otro)
        {
            int fechaComparison = this.Fecha.CompareTo(otro.Fecha);
            if (fechaComparison == 0)
            {
                return this.Numero.CompareTo(otro.Numero);
            }
            return fechaComparison;
        }
    }
}
