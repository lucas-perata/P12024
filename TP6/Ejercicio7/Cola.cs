using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Cola
    {
        Cliente _inicio;
        public void Encolar(Cliente cliente)
        {
            if (_inicio == null)
            {
                _inicio = cliente;
            }
            else
            {
                Cliente aux = BuscarUltimo(_inicio);
                aux.Siguiente = cliente;
            }
        }

        private Cliente BuscarUltimo(Cliente cliente)
        {
            if (cliente.Siguiente == null)
            {
                return cliente;
            }
            else
            {
                return BuscarUltimo(cliente.Siguiente);
            }
        }

        public Cliente Desencolar()
        {
            Cliente aux = _inicio; 
            _inicio = _inicio.Siguiente;

            return aux; 
        }

        public Cliente Inicio
        {
            get { return _inicio; }
        }

        public bool Vacia()
        {
            return _inicio == null;
        }

        public int ContarClientesEnCola()
        {
            int count = 0; 
            Cliente aux = _inicio;

            do
            {
                if (this.Vacia()) break; 
                count++;
                aux = aux.Siguiente;
            } while (aux != null);

            return count;
        }

        public void VaciarCola()
        {
            while(!this.Vacia())
            {
                this.Desencolar();
            };
        }

    }
}