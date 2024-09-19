using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Pila _pila = new Pila();
        Pila _otraPila = new Pila();
        Pila pilaAuxiliar = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarPila(ListBox _lista, Pila pila)
        {
            _lista.Items.Clear();

            if (pila.Tope() != null)
            {
                MostrarEnLista(pila.Tope(), _lista);
            }
        }

        private void MostrarEnLista(Expediente expediente, ListBox _lista)
        {
            _lista.Items.Add(expediente);

            if (expediente.Siguiente != null)
            {
                MostrarEnLista(expediente.Siguiente, _lista);
            }
        }

        private void pushBtn_Click(object sender, EventArgs e)
        {
            Expediente nuevoExp = new Expediente();
            nuevoExp.Caratula = this.caratula.Text;
            nuevoExp.Fecha = this.fecha.Value;
            nuevoExp.Numero = Convert.ToInt32(this.numero.Value);

            _pila.Push(nuevoExp);

            MostrarPila(this.expedientesBox, _pila);
        }

        private void ordenarBtn_Click(object sender, EventArgs e)
        {

            OrdenarPorFechaYNumero();
            MostrarPila(this.ordenadosBox, _pila);
        }

        public void OrdenarPorFechaYNumero()
        {

            while (_pila.Tope() != null)
            {
                Expediente tmp = _pila.Pop();

                Expediente expTemp = new Expediente()
                {
                    Caratula = tmp.Caratula,
                    Fecha = tmp.Fecha,
                    Numero = tmp.Numero,
                };

                while (pilaAuxiliar.Tope() != null && pilaAuxiliar.Tope().Comparar(expTemp) > 0)
                {
                    Expediente xtemp = pilaAuxiliar.Pop();
                    Expediente expTempB = new Expediente
                    {
                        Caratula = xtemp.Caratula,
                        Fecha = xtemp.Fecha,
                        Numero = xtemp.Numero,
                    };

                    _pila.Push(expTempB);
                }

                pilaAuxiliar.Push(expTemp);
            }

            while (pilaAuxiliar.Tope() != null)
            {
                Expediente tpm = pilaAuxiliar.Pop();
                Expediente expTemp = new Expediente()
                {
                    Caratula = tpm.Caratula,
                    Fecha = tpm.Fecha,
                    Numero = tpm.Numero,
                };

                _pila.Push(expTemp);

            }
        }
    }
}