using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Cola
    {
        Persona _inicio;

        public void Enqueue(Persona persona)
        {
            if (_inicio == null)
            {
                _inicio = persona;
            }
            else
            {
                Persona aux = BuscarUltimo(_inicio);
                aux.Siguiente = persona;
            }
        }

        public int ProximoNumero()
        {
            if (_inicio == null) return 1;
            int max = BuscarMaximo(_inicio, _inicio.Numero);
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
            if (persona.Siguiente == null)
            {
                return persona;
            }
            else
            {
                return BuscarUltimo(persona.Siguiente);
            }
        }

        public Persona Dequeue()
        {
            Persona aux = null; 

            if(!Vacia())
            {
                aux = _inicio; 
                _inicio = _inicio.Siguiente;
            }

            return aux; 
        }

        public Persona Inicio
        {
            get { return _inicio; }
        }

        public void LimpiarQueue()
        {
            do
            {
                this.Dequeue();
            } while (!this.Vacia());
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
