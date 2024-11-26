using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    internal class GestorArchivos
    {
        string archivoComposición = "composición.txt";
        string archivoPedidos = "pedidos.txt";
        string archivoStockModelos = "stock-modelos.txt";
        string archivoStockPiezas = "stock-piezas.txt";

        public Composicion[] LeerComposicion()
        {
            List<Composicion> composiciones = new List<Composicion>();
            FileStream fs = new FileStream(archivoComposición, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while(linea != null)
            {
                composiciones.Add(new Composicion(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            return composiciones.ToArray();
        }

        public Pedido[] LeerPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            FileStream fs = new FileStream(archivoPedidos, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while(linea != null)
            {
                pedidos.Add(new Pedido(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return pedidos.ToArray();
        }

        public StockModelo[] LeerStockModelo()
        {
            List<StockModelo> stockModelos = new List<StockModelo>();
            FileStream fs = new FileStream(archivoStockModelos, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while(linea != null)
            {
                stockModelos.Add(new StockModelo(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return stockModelos.ToArray();
        }

        public StockPieza[] LeerStockPieza()
        {
            List<StockPieza> stockPiezas = new List<StockPieza>();
            FileStream fs = new FileStream(archivoStockPiezas, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while(linea != null)
            {
                stockPiezas.Add(new StockPieza(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return stockPiezas.ToArray();
        }
    }
}
