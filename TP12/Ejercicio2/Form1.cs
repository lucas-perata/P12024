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
            Listar(canciones.NodoInicial); 

        }

        private void Listar(Cancion cancion)
        {
              this.cancionesList.Items.Add(cancion);

              if(cancion.Siguiente != null)
              {
                  Listar(cancion.Siguiente); 
              }
        }

        private void agregarFinalBtn_Click(object sender, EventArgs e)
        {
            Cancion cancion = new Cancion();

            cancion.Duracion = this.duracionInt.Value;
            cancion.Nombre = this.nombreText.Text;

            canciones.AgregarFinal(cancion);

            this.cancionesList.Items.Clear();
            Listar(canciones.NodoInicial);

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
            lblActual.Text = seleccionado[0].ToString();
            canciones.QuitarPosicion(Convert.ToInt32(seleccionado[0]));
            this.cancionesList.Items.Clear();
            Listar(canciones.NodoInicial); 
        }
    }
}
