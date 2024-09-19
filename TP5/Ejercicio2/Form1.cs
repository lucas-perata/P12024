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
        Pila _pila = new Pila(); 
        Pila _otraPila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarPila(ListBox _lista, Pila pila)
        {
            _lista.Items.Clear();

            if(pila.Tope() != null)
            {
                MostrarEnLista(pila.Tope(), _lista);
            }
        }

        private void MostrarEnLista(Pueblo pueblo, ListBox _lista)
        {
            _lista.Items.Add(pueblo.Nombre); 

            if(pueblo.Siguiente != null)
            {
                MostrarEnLista(pueblo.Siguiente, _lista);
            }
        }

        private void pushBtn_Click(object sender, EventArgs e)
        {
            Pueblo nuevoPueblo = new Pueblo();
            nuevoPueblo.Nombre = this.textBox1.Text;

            _pila.Push(nuevoPueblo);

            MostrarPila(this.pueblosList, _pila);
        }

        private void idaBtn_Click(object sender, EventArgs e)
        {
            if(_pila.Tope() == null)
            {
                viajeIda();

                MostrarPila(this.viajesList, _pila);


            }
            else
            {
                MostrarPila(this.viajesList, _pila);

            }
        }

        private void vueltaBtn_Click(object sender, EventArgs e)
        {
            viajeVuelta();
            MostrarPila(this.viajesList, _otraPila);
        }

        private void viajeVuelta()
        {
            while(_pila.Tope() != null)
            {
                Pueblo nuevoPueblo = new Pueblo();
                nuevoPueblo.Nombre = _pila.Pop().Nombre;
                _otraPila.Push(nuevoPueblo);
            }
        }

        private void viajeIda()
        {
            while (_otraPila.Tope() != null)
            {
                Pueblo nuevoPueblo = new Pueblo();
                nuevoPueblo.Nombre = _otraPila.Pop().Nombre;
                _pila.Push(nuevoPueblo);
            }
        }
    }
}
