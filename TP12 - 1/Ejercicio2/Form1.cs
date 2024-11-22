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
        Lista canciones = new Lista();
        Cancion nodoSeleccionado; 
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarPrincipioBtn_Click(object sender, EventArgs e)
        {
            Cancion cancion = new Cancion();

            cancion.Duracion = this.duracionInt.Value;
            cancion.Nombre = this.nombreText.Text;

            canciones.AgregarPrincipio(cancion);

            this.cancionesList.Items.Clear(); 
            Listar(); 

        }

        private void Listar()
        {
            if (canciones.NodoInicial == null)
                return;

            Cancion actual = canciones.NodoInicial;
            do
            {
                this.cancionesList.Items.Add(actual);
                actual = actual.Siguiente;
            } while (actual != canciones.NodoInicial); 

            lblTotalCanciones.Text = (canciones.ProximoNumero() - 1).ToString(); 
        }

        private void agregarFinalBtn_Click(object sender, EventArgs e)
        {
            Cancion cancion = new Cancion();

            cancion.Duracion = this.duracionInt.Value;
            cancion.Nombre = this.nombreText.Text;

            canciones.AgregarFinal(cancion);

            this.cancionesList.Items.Clear();
            Listar();

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            lblActual.Text = canciones.NodoInicial.Nombre + " " + canciones.NodoInicial.Duracion;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            canciones.NodoInicial = canciones.NodoInicial.Siguiente;
            lblActual.Text = canciones.NodoInicial.Nombre + " " + canciones.NodoInicial.Duracion;
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            canciones.NodoInicial = canciones.NodoInicial.Anterior;
            lblActual.Text = canciones.NodoInicial.Nombre + " " + canciones.NodoInicial.Duracion;
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            string seleccionado = this.cancionesList.SelectedItem.ToString();
            int num = int.Parse(seleccionado.Split('-')[0].Trim());
            canciones.QuitarPosicion(num);
            this.cancionesList.Items.Clear();
            Listar(); 
        }

        private void intercambiarBtn_Click(object sender, EventArgs e)
        {
            string seleccionado = this.cancionesList.SelectedItem.ToString();
            int num = int.Parse(seleccionado.Split('-')[0].Trim());
            canciones.IntercambiarDerecha(num);
            this.cancionesList.Items.Clear();
            Listar();
        }

        private void posicionBtn_Click(object sender, EventArgs e)
        {
            Cancion cancion = new Cancion();

            cancion.Duracion = this.duracionInt.Value;
            cancion.Nombre = this.nombreText.Text;

            canciones.AgregarPosition((int)this.numPosicion.Value ,cancion);

            this.cancionesList.Items.Clear();
            Listar();
        }
    }
}
