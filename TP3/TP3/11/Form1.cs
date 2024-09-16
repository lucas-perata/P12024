using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        private int turn = 1;
        private bool play = false;
        private string ganador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            play = true;
        }

        public void Play()
        {
            labelTurnos.Text = turn.ToString();
            label3.Text = ganador;
            if (CheckEndGame()) { label3.Text = ganador; }
        }

        public bool TieGame()
        {
            foreach (var control in this.Controls.OfType<Button>())
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckEndGame()
        {
            if(b1.Text.Equals("X")  && b2.Text.Equals("X") && b3.Text.Equals("X")) 
            { play = false; ganador = "Ganador Jugador X" ; return true; }
            else if (b1.Text.Equals("O") && b2.Text.Equals("O") && b3.Text.Equals("O")) 
            { play = false;ganador = "Ganador Jugador O"; return true; }

            if (b4.Text.Equals("X") && b5.Text.Equals("X") && b6.Text.Equals("X")) 
            { play = false; ganador = "Ganador Jugador X"; return true; }
            else if (b4.Text.Equals("O") && b5.Text.Equals("O") && b6.Text.Equals("O")) 
            { play = false; ganador = "Ganador Jugador O"; return true; }

            if (b7.Text.Equals("X") && b8.Text.Equals("X") && b9.Text.Equals("X")) 
            { play = false; ganador = "Ganador Jugador X"; return true; }
            else if (b7.Text.Equals("O") && b8.Text.Equals("O") && b9.Text.Equals("O")) 
            { play = false; ganador = "Ganador Jugador O"; return true; }


            if (b1.Text.Equals("X") && b5.Text.Equals("X") && b9.Text.Equals("X")) 
            { play = false; ganador = "Jugador X"; return true; }
            else if (b1.Text.Equals("O") && b5.Text.Equals("O") && b9.Text.Equals("O")) 
            { play = false; ganador = "Jugador X"; return true; }
            
            if (b7.Text.Equals("X") && b5.Text.Equals("X") && b3.Text.Equals("X")) 
            { play = false; ganador = "Jugador X"; return true; }
            else if (b7.Text.Equals("O") && b5.Text.Equals("O") && b3.Text.Equals("O")) 
            { play = false; ganador = "Jugador O"; return true; }


            if (b1.Text.Equals("X") && b4.Text.Equals("X") && b7.Text.Equals("X"))
            { play = false; ganador = "Ganador Jugador X"; return true; }
            else if (b1.Text.Equals("O") && b4.Text.Equals("O") && b7.Text.Equals("O"))
            { play = false; ganador = "Ganador Jugador O"; return true; }

            if (b2.Text.Equals("X") && b5.Text.Equals("X") && b8.Text.Equals("X"))
            { play = false; ganador = "Ganador Jugador X"; return true; }
            else if (b2.Text.Equals("O") && b5.Text.Equals("O") && b8.Text.Equals("O"))
            { play = false; ganador = "Ganador Jugador O"; return true; }

            if (b3.Text.Equals("X") && b6.Text.Equals("X") && b9.Text.Equals("X"))
            { play = false; ganador = "Ganador Jugador X"; return true; }
            else if (b3.Text.Equals("O") && b6.Text.Equals("O") && b9.Text.Equals("O"))
            { play = false; ganador = "Ganador Jugador O"; return true; }


            if(TieGame()) { play = false; ganador = "Empate"; return true; }

            return false; 

        }

        private void button_Click(object sender, EventArgs e)
        {

            if (!CheckEndGame() && play)
            {
                Play();
                Button button = (Button)sender;
                if (turn % 2 == 0)
                { button.Text = "X"; turn++; }
                else
                { button.Text = "O"; turn++; }

                button.Enabled = false;

                CheckEndGame();
                Play();
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            play = true;
            turn = 1;
            label3.Text = " ";
            ganador = "";

            b1.Text = " ";
            b1.Enabled = true;
            b2.Text = " ";
            b2.Enabled = true;
            b3.Text = " ";
            b3.Enabled = true;
            b4.Text = " ";
            b4.Enabled = true;
            b5.Text = " ";
            b5.Enabled = true;
            b6.Text = " ";
            b6.Enabled = true;
            b7.Text = " ";
            b7.Enabled = true;
            b8.Text = " ";
            b8.Enabled = true;
            b9.Text = " ";
            b9.Enabled = true;

            CheckEndGame();

        }
    }
}
