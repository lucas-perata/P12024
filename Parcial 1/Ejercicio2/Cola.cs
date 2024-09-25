using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cola
    {
        Cliente _inicio; 

        public void Encolar(Cliente cliente)
        {
            if(_inicio == null)
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
            if(cliente.Siguiente == null)
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
    }
}
