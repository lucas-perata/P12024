using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas3
{
    internal class ListaEnlazada
    {
        public Persona NodoInicial = null;

        public void AgregarPrimero(Persona persona)
        {
            if (NodoInicial == null)
            {
                NodoInicial = persona;
            }
            else
            {
                Persona aux = NodoInicial;
                NodoInicial = persona;
                NodoInicial.Siguiente = aux;
            }
        }

        public void AgregarFinal(Persona persona)
        {
            persona.Numero = ProximoNumero();

            Persona ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = persona;
        }

        public int ProximoNumero()
        {
            if (NodoInicial == null) return 1;
            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);
            return max + 1;
        }

        private int BuscarMaximo(Persona persona, int num)
        {
            int max = persona.Numero > num ? persona.Numero : num;

            if (persona.Siguiente != null)
            {
                return BuscarMaximo(persona.Siguiente, max);
            }
            else
            {
                return max;
            }
        }

        private Persona BuscarUltimo(Persona persona)
        {
            if (persona == null) return null;

            if (persona.Siguiente != null)
            {
                return BuscarUltimo(persona.Siguiente);
            }
            else
            {
                return persona;
            }
        }

        private Persona BuscarAnterior(Persona persona, int num)
        {
            if(persona.Siguiente != null && persona.Siguiente.Numero == num)
            {
                return persona; 
            }

            if (persona.Siguiente != null)
                return BuscarAnterior(persona.Siguiente, num);

            return null; 
        }

        public void AgregarPosicion(Persona persona, int posicion)
        {
            if (posicion <= 1)
            {
                AgregarPrimero(persona);
                ReordenarPosiciones(NodoInicial, 1); 
            }
            else
            {
                Persona actual = NodoInicial;
                int contador = 1;

                while (actual != null && contador < posicion - 1)
                {
                    actual = actual.Siguiente;
                    contador++;
                }

                if (actual == null)
                {
                    AgregarFinal(persona);
                }
                else
                {
                    Persona siguiente = actual.Siguiente;
                    actual.Siguiente = persona;
                    persona.Siguiente = siguiente;
                    persona.Posicion = posicion;
                    ReordenarPosiciones(persona.Siguiente, posicion + 1);
                }
            }
        }

        private void ReordenarPosiciones(Persona persona, int nuevaPosicion)
        {
            while(persona != null)
            {
                persona.Posicion = nuevaPosicion;
                nuevaPosicion++;
                persona = persona.Siguiente; 
            }
        }


    }
}
