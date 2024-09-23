using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        Caja caja1 = new Caja()
        {
            Abierta = true
        };
        Caja caja2 = new Caja()
        {
            Abierta = true
        };
        Caja caja3 = new Caja()
        {
            Abierta = true
        };



        Cola cola1 = new Cola();
        Cola cola2 = new Cola();
        Cola cola3 = new Cola();

        int clientesCaja1 = 0;
        int clientesCaja2 = 0;
        int clientesCaja3 = 0;

        int totalCaja1 = 0;
        int totalCaja2 = 0;
        int totalCaja3 = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarCaja1_Click(object sender, EventArgs e)
        {
            if (caja1.Abierta)
            {
                CerrarCaja(abrirCaja1, cerrarCaja1, caja1);
            }

            DistribuirCajaCerrada(cola1);
          
        }

        private void DistribuirCajaCerrada(Cola _cola)
        {
            if(!caja1.Abierta && !caja2.Abierta && !caja3.Abierta)
            {
                MessageBox.Show("No se puede cerrar la caja sin perder los clientes");
            }
            else
            {
                while (_cola.Inicio != null)

                {
                    Cliente cliente = new Cliente();
                    cliente.Total = _cola.Desencolar().Total;
                    Distribuir(cliente);
                }
            }

        }

        private void abrirCaja1_Click(object sender, EventArgs e)
        {
            if (!caja1.Abierta)
            {
                AbrirCaja(abrirCaja1, cerrarCaja1, caja1);
            }
        }

        private void CerrarCaja(Button _abrir, Button _cerrar, Caja caja)
        {
           
                _cerrar.Enabled = false;
                _abrir.Enabled = true;
                caja.Abierta = false;
            
        }

        private void AbrirCaja(Button _abrir, Button _cerrar, Caja caja)
        {
           _cerrar.Enabled = true;
           _abrir.Enabled = false;
            caja.Abierta = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (caja1.Abierta)
            {
                this.cerrarCaja1.Enabled = true;
                this.abrirCaja1.Enabled = false;
            }

            if (caja2.Abierta)
            {
                this.cerrarCaja2.Enabled = true;
                this.abrirCaja2.Enabled = false;
            }

            if (caja3.Abierta)
            {
                this.cerrarCaja3.Enabled = true;
                this.abrirCaja3.Enabled = false;
            }

          

            colaCaja1.Text = cola1.ContarClientesEnCola().ToString();
            colaCaja2.Text = cola2.ContarClientesEnCola().ToString();
            colaCaja3.Text = cola3.ContarClientesEnCola().ToString();
        }

        private void nuevoClienteBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 100);

            Cliente cliente = new Cliente();
            cliente.Total = random;

            Distribuir(cliente);



            ContarClientes();
            OrganizarCobros();     

        }


        private void ContarClientes()
        {
            clientesCaja1 = cola1.ContarClientesEnCola();
            clientesCaja2 = cola2.ContarClientesEnCola();
            clientesCaja3 = cola3.ContarClientesEnCola();

            colaCaja1.Text = clientesCaja1.ToString();
            colaCaja2.Text = clientesCaja2.ToString();
            colaCaja3.Text = clientesCaja3.ToString();
        }

        private void OrganizarCobros()
        {
            cobroCaja1.Text = cola1.Inicio != null ? cola1.Inicio.Total.ToString() : "";
            cobroCaja2.Text = cola2.Inicio != null ? cola2.Inicio.Total.ToString() : "";
            cobroCaja3.Text = cola3.Inicio != null ? cola3.Inicio.Total.ToString() : "";
        }

        private void Distribuir(Cliente cliente)
        {

            ContarClientes();
            
           
            if(!caja1.Abierta && !caja2.Abierta && !caja3.Abierta)
            {
                MessageBox.Show("No hay cajas abiertas");
                return; 
            } 
            else
            {
                if (caja1.Abierta &&
                (clientesCaja1 <= clientesCaja2 && clientesCaja1 <= clientesCaja3))
                {
                    cola1.Encolar(cliente);
                    return;
                }
                else if (caja2.Abierta &&
                    (clientesCaja2 <= clientesCaja3 && clientesCaja2 < clientesCaja1))
                {
                    cola2.Encolar(cliente);
                    return;
                }
                else if ((caja2.Abierta && !caja3.Abierta && caja1.Abierta) && (clientesCaja1 <= clientesCaja2))
                {
                    cola1.Encolar(cliente);
                }
                else if ((caja2.Abierta && !caja3.Abierta && caja1.Abierta) && (clientesCaja1 > clientesCaja2))
                {
                    cola2.Encolar(cliente);
                }
                else if ((caja2.Abierta && caja3.Abierta && !caja1.Abierta) && (clientesCaja2 <= clientesCaja3))
                {
                    cola2.Encolar(cliente);
                }
                else if ((!caja2.Abierta && caja3.Abierta && caja1.Abierta) && (clientesCaja1 <= clientesCaja3))
                {
                    cola1.Encolar(cliente);
                }
                else if(caja1.Abierta && !caja2.Abierta && !caja3.Abierta)
                {
                    cola1.Encolar(cliente);
                }
                else if (!caja1.Abierta && caja2.Abierta && !caja3.Abierta)
                {
                    cola2.Encolar(cliente);
                }
                else if (!caja1.Abierta && !caja2.Abierta && caja3.Abierta)
                {
                    cola3.Encolar(cliente);
                }
                else
                {
                    cola3.Encolar(cliente);
                }

                ContarClientes();
                OrganizarCobros();
            }
        }


        private void cerrarCaja2_Click(object sender, EventArgs e)
        {
            CerrarCaja(abrirCaja2, cerrarCaja2, caja2);
            DistribuirCajaCerrada(cola2);

        }

        private void abrirCaja2_Click(object sender, EventArgs e)
        {
            AbrirCaja(abrirCaja2, cerrarCaja2, caja2);
        }

        private void cerrarCaja3_Click(object sender, EventArgs e)
        {
            CerrarCaja(abrirCaja3, cerrarCaja3, caja3);
            DistribuirCajaCerrada(cola3);
        }

        private void abrirCaja3_Click(object sender, EventArgs e)
        {
            AbrirCaja(abrirCaja3, cerrarCaja3, caja3);
        }

        private void cobrarCaja1_Click(object sender, EventArgs e)
        {
            if(clientesCaja1 > 0)
            {
                totalCaja1 += Convert.ToInt32(cobroCaja1.Text);
                caja1Total.Text = totalCaja1.ToString();

                cola1.Desencolar();

                OrganizarCobros();
                ContarClientes();
            }

        }

        private void cobrarCaja2_Click(object sender, EventArgs e)
        {
            if (clientesCaja2 > 0)
            {
                totalCaja2 += Convert.ToInt32(cobroCaja2.Text);
                caja2Total.Text = totalCaja2.ToString();

                cola2.Desencolar();

                OrganizarCobros();
                ContarClientes();
            }
        }

        private void cobrarCaja3_Click(object sender, EventArgs e)
        {
            if (clientesCaja3 > 0)
            {
                totalCaja3 += Convert.ToInt32(cobroCaja3.Text);
                caja3Total.Text = totalCaja3.ToString();
                cola3.Desencolar();

                OrganizarCobros();
                ContarClientes();
            }
        }

        private void cerrarCajasBtn_Click(object sender, EventArgs e)
        {
            CerrarCaja(abrirCaja1, cerrarCaja1, caja1);
            CerrarCaja(abrirCaja2, cerrarCaja2, caja2);
            CerrarCaja(abrirCaja3, cerrarCaja3, caja3);

            cola1.VaciarCola();
            cola2.VaciarCola();
            cola3.VaciarCola();

            OrganizarCobros();
            ContarClientes();

        }
    }
}