using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class ColaConPrioridad
    {
        Persona _inicio; 

        public void Encolar(Persona persona)
        {
            if(_inicio == null)
            {
                _inicio = persona; 
            }
            else
            {
                Prioridad(persona);
            }
        }

        private void Prioridad(Persona persona)
        {
            if(persona.Prioridad < _inicio.Prioridad)
            {
                Persona aux = _inicio;
                _inicio = persona;
                _inicio.Siguiente = aux; 
            }
            else
            {
                Persona actual = _inicio; 

                while(actual.Siguiente != null && actual.Siguiente.Prioridad <= persona.Prioridad)
                {
                    actual = actual.Siguiente;
                }

                persona.Siguiente = actual.Siguiente;
                actual.Siguiente = persona;
            }
        }

        private Persona BuscarUltimo(Persona persona)
        {
            if(persona.Siguiente == null)
            {
                return persona; 
            } 
            else
            {
                return BuscarUltimo(persona.Siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente; 
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }

        public Persona Inicio
        {
            get {
                return _inicio; 
            }
        }
    }
}
