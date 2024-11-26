using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class GestorPedidos
    {
        string archivoPedidos = "pedidos-por-modelo.txt";
        string archivoPiezas = "pedidos-por-pieza.txt";
        public PedidoModelo[] CalcularPedidosPorModelo(Pedido[] pedidos, StockModelo[] modelos)
        {
            FileStream fs = new FileStream(archivoPedidos, FileMode.Truncate);
            fs.Close();
            List<PedidoModelo> pedidosPorModelos = new List<PedidoModelo>();

            foreach (var pedido in pedidos)
            {
                var pedidoExistente = pedidosPorModelos.FirstOrDefault(p => p.Modelo == pedido.NroModelo);

                if (pedidoExistente == null)
                {
                    pedidoExistente = new PedidoModelo
                    {
                        Modelo = pedido.NroModelo,
                        CantidadPedida = 0,
                        StockInicial = 0
                    };
                    pedidosPorModelos.Add(pedidoExistente);
                }

                pedidoExistente.CantidadPedida += pedido.CantidadPedida;
            }

            foreach (var modelo in modelos)
            {
                var pedidoExistente = pedidosPorModelos.FirstOrDefault(p => p.Modelo == modelo.NroModelo);
                if (pedidoExistente != null)
                {
                    pedidoExistente.StockInicial += modelo.StockActual;

                    int resta = pedidoExistente.StockInicial - pedidoExistente.CantidadPedida;
                    pedidoExistente.StockFinal = resta;
                    pedidoExistente.Deuda = Math.Max(0, -resta); 
                    pedidoExistente.Pendientes = Math.Max(0, -resta);
                }
            }

            var resultado = pedidosPorModelos.ToArray();

            GuardarPedidosPorModelo(pedidosPorModelos.ToArray());

            return resultado;
        }

        private void GuardarPedidosPorModelo(PedidoModelo[] pedidos)
        {

            FileStream fs = new FileStream(archivoPedidos, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach (PedidoModelo p in pedidos)
            {
                sw.WriteLine(string.Format("{0};{1};{2};{3};{4};{5}", p.Modelo, p.StockInicial, p.CantidadPedida, p.StockFinal, p.Pendientes, p.Deuda));
            }

            sw.Close();
        }

        public PedidoModelo[] LeerPedidoModelo()
        {
            List<PedidoModelo> pedidosModelos = new List<PedidoModelo>();
            FileStream fs = new FileStream(archivoPedidos, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while (linea != null)
            {
                pedidosModelos.Add(new PedidoModelo(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return pedidosModelos.ToArray();
        }

        public PedidoPieza[] CalcularPedidoPieza(Composicion[] composiciones,  StockPieza[] piezas)
        {
            List<PedidoPieza> pedidosPorPieza = new List<PedidoPieza>();
            PedidoModelo[] pedidos = LeerPedidoModelo();

            for (int i = 0; i < pedidos.Length; i++)
            {
                if (pedidos[i].Deuda > 0)
                {
                    for (int j = 0; j < composiciones.Length; j++)
                    {
                        if (pedidos[i].Modelo == composiciones[j].NroModelo)
                        {
                            int nroPieza = composiciones[j].NroPieza;
                            int cantidadUsar = composiciones[j].CantidadUsar * pedidos[i].Deuda;

                            PedidoPieza piezaExistente = pedidosPorPieza.FirstOrDefault(p => p.Pieza == nroPieza);

                            if (piezaExistente != null)
                            {
                                piezaExistente.CantidadMinima += cantidadUsar;
                                piezaExistente.StockFinal -= cantidadUsar;
                            }
                            else
                            {
                                PedidoPieza nuevaPieza = new PedidoPieza
                                {
                                    Pieza = nroPieza,
                                    CantidadMinima = cantidadUsar,
                                    StockInicial = piezas.FirstOrDefault(pz => pz.NroPieza == nroPieza)?.StockActual ?? 0
                                };

                                nuevaPieza.StockFinal = nuevaPieza.StockInicial - nuevaPieza.CantidadMinima;

                                pedidosPorPieza.Add(nuevaPieza);
                            }
                        }
                    }
                }
            }

            return pedidosPorPieza.ToArray();
        }
    }
}
