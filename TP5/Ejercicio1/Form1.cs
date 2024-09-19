using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Pila _pila = new Pila();
        Pila _otraPila = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        private void popBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.idNumero.Value);


           

            if (id == _pila.Tope().Id)
            {
                _pila.Pop();
            }
            else
            {
                Eliminar(id);
                _pila.Pop();
            }

            ReApilar();


            MostrarPila(this.listBox1, _pila);
            MostrarPila(this.listBox2, _otraPila);



        }

        private void Eliminar(int id)
        {

            if(_pila.Tope() != null)
            {
                do
                {
                    // Llevar tope a otra pila 
                    Contenedor contenedor = new Contenedor();
                    contenedor.Id = _pila.Pop().Id;
                    _otraPila.Push(contenedor);

                } while (id != _pila.Tope().Id);
            }
        }

        private void ReApilar()
        {
            while(_otraPila.Tope() != null)
            {
                // Llevar tope a otra pila 
                Contenedor contenedor = new Contenedor();
                contenedor.Id = _otraPila.Pop().Id;
                _pila.Push(contenedor);
            }
        }

        private void MostrarPila(ListBox _lista, Pila pila)
        {
            _lista.Items.Clear();

            if(pila.Tope() != null)
            {
                MostrarEnLista(pila.Tope(), _lista);
            }
        }

        void MostrarEnLista(Contenedor contenedor, ListBox _lista)
        {
            _lista.Items.Add(contenedor.Id); 

            if(contenedor.Siguiente != null)
            {
                MostrarEnLista(contenedor.Siguiente, _lista); 
            }
        }

        private void pushBtn_Click(object sender, EventArgs e)
        {
            Contenedor nuevoContenedor = new Contenedor();
            nuevoContenedor.Id = Convert.ToInt32(this.idNumero.Value);

            _pila.Push(nuevoContenedor);
            MostrarPila(this.listBox1, _pila);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPila(this.listBox1, _pila);
            MostrarPila(this.listBox2, _otraPila);
        }
    }
}
