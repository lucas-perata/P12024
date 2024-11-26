using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class Pedido
    {
        public int NroModelo { get; set; }
        public int NroConcesionaria { get; set; }
        public int CantidadPedida { get; set; }

        public Pedido(string linea)
        {
            var datos = linea.Split(';');
            NroModelo = int.Parse(datos[0]);
            NroConcesionaria = int.Parse(datos[1]);
            CantidadPedida = int.Parse(datos[2]); 
        }
    }
}
