using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class StockModelo
    {
        public int NroModelo { get; set; }
        public string Descripcion { get; set; }
        public int StockActual { get; set; }

        public StockModelo(string linea)
        {
            var datos = linea.Split(';');
            NroModelo = int.Parse(datos[0]);
            Descripcion = datos[1];
            StockActual = int.Parse(datos[2]);
        }

    }
}
