using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Pila
    {
        Expediente _tope; 

        public Expediente Tope()
        {
            return _tope;
        }

        public void Push(Expediente expediente)
        {
            if(_tope == null)
            {
                _tope = expediente;
            }
            else
            {
                Expediente aux = _tope;
                _tope = expediente;
                _tope.Siguiente = aux; 
            }
        }

        public Expediente Pop()
        {
            Expediente aux = null; 

            if(_tope != null)
            {
                aux = _tope;
                _tope = _tope.Siguiente; 
            }

            return aux; 
        }

    }
}
