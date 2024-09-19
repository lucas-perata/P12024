using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas6
{
    public partial class Ejercicio6 : Form
    {
        ListaDoblementeEnlazada personas = new ListaDoblementeEnlazada();
        Persona nodoSeleccionado; 
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarLista(); 
        }

        private void GenerarLista()
        {
            this.listaPersonas.Items.Clear();
            Listar(personas.NodoInicial);
        }

        private void Listar(Persona nodo)
        {
            if (nodo != null)
            {
                listaPersonas.Items.Add(nodo);
                if (nodo.Siguiente != null)
                    Listar(nodo.Siguiente);
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            nuevaPersona.Numero = personas.ProximoNumero();

            if (edadBtn.Checked)
            {
                Random rnd = new Random();
                nuevaPersona.Edad = rnd.Next(5, 60);
            }
            else
            {
                nuevaPersona.Edad = Convert.ToInt32(edad.Text);
            }

            personas.AgregarPrincipio(nuevaPersona);
            GenerarLista();
        }

        private void edadBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (edadBtn.Checked)
            {
                edad.Enabled = false;
            }
            else
            {
                edad.Enabled = true;
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                personas.QuitarPosicion(nodoSeleccionado.Numero);
                GenerarLista();
            }
            else
                MessageBox.Show("Seleccionar un nodo.");
        }

        private void listaPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Persona) this.listaPersonas.SelectedItem;
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            if(nodoSeleccionado != null)
            {
                Persona actualizada = new Persona();
                actualizada.Numero = nodoSeleccionado.Numero;
                actualizada.Edad = Convert.ToInt32(edad.Text);
                personas.Actualizar(actualizada);
                GenerarLista();
            }
        }
    }
}
