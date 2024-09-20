using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        Cola _queueMujeres = new Cola();
        Cola _queueHombres = new Cola();
        Cola _queueMain = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarQueue(Cola _queue, ListBox _lista)
        {
            _lista.Items.Clear();
            MostrarPersona(_queue.Inicio, _lista);
        }

        private void MostrarPersona(Persona persona, ListBox _lista)
        {
            if(persona != null)
            {
                _lista.Items.Add(persona); 

                if(persona.Siguiente != null)
                {
                    MostrarPersona(persona.Siguiente, _lista);
                }
            }
        }

        private void mujerBtn_Click(object sender, EventArgs e)
        {
            Persona mujer = new Persona()
            {
                Genero = "Femenino",
                Numero = _queueMain.ProximoNumero()
            };

            _queueMain.Enqueue(mujer);
            MostrarQueue(_queueMain, mainList);
        }

        private void hombreBtn_Click(object sender, EventArgs e)
        {
            Persona hombre = new Persona()
            {
                Genero = "Masculino",
                Numero = _queueMain.ProximoNumero(),
            };

            _queueMain.Enqueue(hombre);
            MostrarQueue(_queueMain, mainList);
        }

        private void separarBtn_Click(object sender, EventArgs e)
        {
            SepararColaPorUno();
            MostrarQueue(_queueMain, mainList);
            MostrarQueue(_queueHombres, hombresList);
            MostrarQueue(_queueMujeres, mujeresList);
        }

        private void SepararColaPorUno()
        {
            Persona aux = new Persona();

            if (!_queueMain.Vacia())
            {
                if(_queueMain.Inicio.Genero == "Masculino")
                {
                    aux.Genero = _queueMain.Dequeue().Genero;
                    aux.Numero = _queueHombres.ProximoNumero(); 
                    _queueHombres.Enqueue(aux);
                }
                else if (_queueMain.Inicio.Genero == "Femenino")
                {
                    aux.Genero = _queueMain.Dequeue().Genero;
                    aux.Numero = _queueMujeres.ProximoNumero();
                    _queueMujeres.Enqueue(aux);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SepararColaTodoJunto(_queueMain.Inicio);
            MostrarQueue(_queueMain, mainList);
            MostrarQueue(_queueHombres, hombresList);
            MostrarQueue(_queueMujeres, mujeresList);
        }

        private void SepararColaTodoJunto(Persona persona)
        {
            Persona auxA = new Persona();
            Persona auxB = new Persona();

            if (!_queueMain.Vacia())
            {
                if (persona.Genero == "Masculino")
                {
                    auxA.Genero = _queueMain.Dequeue().Genero;
                    auxA.Numero = _queueHombres.ProximoNumero();
                    _queueHombres.Enqueue(auxA);
                }
                 
                else if (persona.Genero == "Femenino")
                {
                    auxB.Genero = _queueMain.Dequeue().Genero;
                    auxB.Numero = _queueMujeres.ProximoNumero();
                    _queueMujeres.Enqueue(auxB);
                }

                SepararColaTodoJunto(persona.Siguiente);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            _queueMain.LimpiarQueue();
            _queueHombres.LimpiarQueue();
            _queueMujeres.LimpiarQueue();

            MostrarQueue(_queueMain, mainList);
            MostrarQueue(_queueHombres, hombresList);
            MostrarQueue(_queueMujeres, mujeresList);
        }
    }
}
