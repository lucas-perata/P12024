using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Pila
    {
        Pueblo _tope;

        public Pueblo Tope()
        {
            return _tope;
        }

        public void Push(Pueblo pueblo)
        {
            if (_tope == null)
            {
                _tope = pueblo;
            }
            else
            {
                Pueblo aux = _tope;
                _tope = pueblo;
                _tope.Siguiente = aux;
            }
        }

        public Pueblo Pop()
        {
            Pueblo aux = null;

            if (_tope != null)
            {
                aux = _tope;
                _tope = _tope.Siguiente;
            }

            return aux;
        }
    }
}
