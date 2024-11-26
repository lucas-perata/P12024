using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class PedidoModelo
    {
        public int Modelo { get; set; }
        public int StockInicial { get; set; }
        public int CantidadPedida { get; set; }
        public int StockFinal { get; set; }
        public int Pendientes { get; set; }
        public int Deuda { get; set; }

        public PedidoModelo()
        {
            Modelo = Modelo;
            StockInicial = StockInicial;
            CantidadPedida = CantidadPedida;
            StockFinal = StockFinal;
            Pendientes = Pendientes;
            Deuda = Deuda; 
        }

        public PedidoModelo(string linea)
        {
            var datos = linea.Split(';');
            Modelo = int.Parse(datos[0]);
            StockInicial = int.Parse(datos[1]);
            CantidadPedida = int.Parse(datos[2]);
            StockFinal = int.Parse(datos[3]);
            Pendientes = int.Parse(datos[4]);
            Deuda = int.Parse(datos[5]);
        }
    }
}
