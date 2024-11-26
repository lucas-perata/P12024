using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_2
{
    public partial class Form1 : Form
    {
        GestorArchivos gestor = new GestorArchivos();
        GestorPedidos gestorPedidos = new GestorPedidos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pedido[] pedidos = gestor.LeerPedidos();
            StockModelo[] modelos = gestor.LeerStockModelo();
            Composicion[] composiciones = gestor.LeerComposicion();
            StockPieza[] stockPiezas = gestor.LeerStockPieza();

            dataGridView1.DataSource = composiciones;
            stockModelosData.DataSource = modelos;
            stockPiezasData.DataSource = stockPiezas;
            pedidosData.DataSource = pedidos;
            pedidosModeloData.DataSource = gestorPedidos.CalcularPedidosPorModelo(pedidos, modelos);
            pedidosPiezasData.DataSource = gestorPedidos.CalcularPedidoPieza(composiciones, stockPiezas);
        }

    }
}
