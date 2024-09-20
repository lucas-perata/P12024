using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class ColaConPrioridad
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
                // Colocar según prioridad 
                Prioridad(cliente); 

            }
        }

        private void Prioridad(Cliente cliente)
        {
            if (cliente.Prioridad < _inicio.Prioridad)
            {
                Cliente aux = _inicio;
                _inicio = cliente;
                _inicio.Siguiente = aux;
            }
            else
            {
                Cliente actual = _inicio;
                while (actual.Siguiente != null && actual.Siguiente.Prioridad <= cliente.Prioridad)
                {
                    actual = actual.Siguiente;
                }
                cliente.Siguiente = actual.Siguiente;
                actual.Siguiente = cliente;
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

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente; 
        }

        public Cliente Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
