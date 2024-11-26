using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class Composicion
    {
        public int NroModelo { get; set; }
        public int NroPieza { get; set; }
        public int CantidadUsar { get; set; }

        public Composicion(string linea)
        {
            var datos = linea.Split(';');
            NroModelo = int.Parse(datos[0]);
            NroPieza = int.Parse(datos[1]);
            CantidadUsar = int.Parse(datos[2]); 
        }

    }
}
