using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Pila
    {
        Contenedor _tope; 

        public Contenedor Tope()
        {
            return _tope; 
        }

        public void Push(Contenedor contenedor)
        {
            if(_tope == null)
            {
                _tope = contenedor; 
            }
            else
            {
                Contenedor aux = _tope;
                _tope = contenedor;
                _tope.Siguiente = aux;
            }
        }

        public Contenedor Pop()
        {
            Contenedor aux = null; 

            if(_tope != null)
            {
                aux = _tope;
                _tope = _tope.Siguiente; 
            }

            return aux; 
        }
    }
}
