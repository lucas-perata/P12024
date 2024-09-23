using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        ColaConPrioridad _colaMain = new ColaConPrioridad();
        ColaConPrioridad _colaSec = new ColaConPrioridad();
        ColaConPrioridad _colaTer = new ColaConPrioridad();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar(ColaConPrioridad _cola, ListBox _list)
        {
            listBox1.Items.Clear();
            MostrarEnPantalla(_cola.Inicio, _list);
        }

        private void MostrarEnPantalla(Persona persona, ListBox _list)
        {
            if(persona != null)
            {
                _list.Items.Add(persona);

                if(persona.Siguiente != null)
                {
                    MostrarEnPantalla(persona.Siguiente, _list);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Prioridad = Convert.ToInt32(numericUpDown1.Value);
            persona.Ticket = checkBox1.Checked ? true : false; 

            _colaMain.Encolar(persona);

            Mostrar(_colaMain, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_colaMain.Inicio != null) 
                Ordenar();

            Mostrar(_colaSec, listBox2);
            Mostrar(_colaMain, listBox1);
            Mostrar(_colaTer, listBox3);

        }

        private void Ordenar()
        {
            Persona main = _colaMain.Inicio;



            while(!_colaMain.Vacia())
            {
                Persona siguiente = main.Siguiente;

                Persona persona1 = new Persona();
                persona1.Prioridad = main.Prioridad;
                persona1.Ticket = main.Ticket;


                _colaMain.Desencolar();
                

                if (main.Ticket)
                {
                    _colaSec.Encolar(persona1);
                }
                else

                {
                    _colaTer.Encolar(persona1);
                }
          

                main = siguiente; 
            }


        }
    }
}
