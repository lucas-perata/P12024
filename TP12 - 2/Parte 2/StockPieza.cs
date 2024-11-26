using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class StockPieza
    {
        public int NroPieza { get; set; }
        public string Descripcion { get; set; }
        public int StockActual { get; set; }

        public StockPieza(string linea)
        {
            var datos = linea.Split(';');
            NroPieza = int.Parse(datos[0]);
            Descripcion = datos[1];
            StockActual = int.Parse(datos[2]); 
        }

    }
}
