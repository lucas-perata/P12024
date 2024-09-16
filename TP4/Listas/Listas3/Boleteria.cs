using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas3
{
    internal class Boleteria
    {
        public ListaEnlazada Persona = new ListaEnlazada();
        public void GenerarFila()
        {
            Random random = new Random(); 
            int cantidad = random.Next(1 , 50);

            for(int i = 0; i < cantidad; i++)
            {
                Persona persona = new Persona();
                persona.Edad = random.Next(5, 60);
                persona.Posicion = i;


                Persona.AgregarPrimero(persona);
            }

        }

        public int CalcularEntrada(Persona persona)
        {
            if(persona != null)
            {
                if(persona.Edad < 10)
                {
                    return 10; 
                }
                else
                {
                    return 15; 
                }
            }

            return 0; 
        }

    }
}
