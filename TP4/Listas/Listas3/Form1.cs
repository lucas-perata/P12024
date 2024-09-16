using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas3
{
    public partial class Ejercicio3 : Form
    {
        public int recaudacion = 0; 
        ListaEnlazada personas = new ListaEnlazada();
        Boleteria boleteria = new Boleteria();
        Persona nodoSeleccionado; 
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularRecaudacion(Persona persona)
        {
            if(persona != null)
            {
                recaudacion += boleteria.CalcularEntrada(persona);

                if(persona.Siguiente != null)
                {
                    recaudacion += boleteria.CalcularEntrada(persona);
                    CalcularRecaudacion(persona.Siguiente); 
                }
            }
        }

        private void Recaudar()
        {
            CalcularRecaudacion(personas.NodoInicial);
            CalcularRecaudacion(boleteria.Persona.NodoInicial);
        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            boleteria.GenerarFila();
            GenerarLista();

        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            GenerarLista();
        }
        private void GenerarLista()
        {
            dataGridView1.Rows.Clear();
            Listar(boleteria.Persona.NodoInicial);
            Listar(personas.NodoInicial);
        }

        private void Listar(Persona persona)
        {
            if(persona != null)
            {
                dataGridView1.Rows[0].Cells[0].Value = persona.Edad;
                dataGridView1.Rows[0].Cells[1].Value = persona.Posicion;

                if(persona.Siguiente != null)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = persona.Edad;
                    dataGridView1.Rows[n].Cells[1].Value = persona.Posicion;


                    Listar(persona.Siguiente);
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(this.posicionA.Value);

            Persona nuevaPersona = new Persona();

            nuevaPersona.Edad = Convert.ToInt32(this.edad.Value);
            nuevaPersona.Posicion = n;

            boleteria.Persona.AgregarPosicion(nuevaPersona, n);

            GenerarLista();
        }

        private void recaudacionBtn_Click(object sender, EventArgs e)
        {
            Recaudar();
            this.totalRecaudado.Text = recaudacion.ToString();
            recaudacion = 0; 
        }
    }
}
