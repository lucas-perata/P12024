using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Cola
    {
        Pasajero _inicio; 

        public void Encolar(Pasajero pasajero)
        {
            if(_inicio == null)
            {
                _inicio = pasajero;
            } 
            else
            {
                Pasajero aux = BuscarUltimo(_inicio);
                aux.Siguiente = pasajero; 
            }
        }

        private Pasajero BuscarUltimo(Pasajero pasajero)
        {
            if(pasajero.Siguiente == null)
            {
                return pasajero; 
            }
            else
            {
                return BuscarUltimo(pasajero.Siguiente);
            }
        }

        public Pasajero Desencolar()
        {
            Pasajero aux = _inicio;
            _inicio = _inicio.Siguiente;

            return aux; 
        }

        public Pasajero Inicio
        {
            get { return _inicio; }
        }

        public bool Vacia()
        {
            return _inicio == null; 
        } 

        public int ContarPasajeros()
        {
            int count = 0;
            Pasajero aux = _inicio;

            do
            {
                if (this.Vacia()) break;
                count++;
                aux = aux.Siguiente;
            } while (aux != null);

            return count; 
        }
    }
}
