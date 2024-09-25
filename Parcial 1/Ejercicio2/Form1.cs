using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Cola _cola = new Cola();
        double total = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            clientesList.Items.Clear();
            MostrarEnLista(_cola.Inicio);
        }

        private void MostrarEnLista(Cliente cliente)
        {
            if(cliente != null)
            {
                clientesList.Items.Add(cliente); 

                if(cliente.Siguiente != null)
                {
                    MostrarEnLista(cliente.Siguiente); 
                }
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if(importeCliente.Value > 0 && nombreCliente.Text != String.Empty)
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Importe = Convert.ToDouble(importeCliente.Value);
                nuevoCliente.Nombre = nombreCliente.Text;

                _cola.Encolar(nuevoCliente);
                LimpiarInput();
                Mostrar();
            }
            else
            {
                MessageBox.Show("Falta agregar datos del cliente");
            }

        }

        private void cobrarBtn_Click(object sender, EventArgs e)
        {
            if(_cola.Inicio != null)
            {
                total += _cola.Desencolar().Importe;
                totalCobradoLabel.Text = total.ToString();

                Mostrar();
            }
            else
            {
                MessageBox.Show("No hay clientes para cobrar");
            }
        }

        private void LimpiarInput()
        {
            this.nombreCliente.Text = "";
            this.importeCliente.Text = "";
        }
    }
}
