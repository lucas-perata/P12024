using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas6
{
    internal class ListaDoblementeEnlazada
    {
        public Persona NodoInicial = null; 
        public Persona NodoFinal = null;

        public void AgregarPrincipio(Persona nuevo)
        {
            if (NodoInicial == null)
            {
                NodoInicial = nuevo;
                NodoFinal = nuevo;
            }
            else
            {
                nuevo.Siguiente = NodoInicial;
                NodoInicial.Anterior = nuevo;
                NodoInicial = nuevo;
            }
        }

        public void Actualizar(Persona actualizada)
        {
            Persona nodo = Buscar(NodoInicial, actualizada.Numero);
            if (nodo != null)
            {
                nodo.Edad = actualizada.Edad;
            }
        }

        private Persona Buscar(Persona nodo, int num)
        {
            if (nodo.Numero == num)
            {
                return nodo;
            }
            if (nodo.Siguiente != null)
            {
                return Buscar(nodo.Siguiente, num);
            }
            return null;
        }

        public int ProximoNumero()
        {
            if (NodoInicial == null) return 1;
            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);

            return max + 1;
        }

        private int BuscarMaximo(Persona nodo, int numero)
        {
            int max = nodo.Numero > numero ? nodo.Numero : numero;
            if (nodo.Siguiente != null) 
            {
                return BuscarMaximo(nodo.Siguiente, max);
            }
            else
            {
                return max;
            }
        }

        public void QuitarPosicion(int num)
        {
            if (NodoInicial != null)
            {
                if (NodoInicial.Numero == num)
                {
                    QuitarPrimero();
                }
                else
                {
                    Persona ultimo = BuscarUltimo(NodoInicial);
                    if (ultimo != null && ultimo.Numero == num)
                    {
                        QuitarUltimo();
                    }
                    else
                    {
                        Persona pacienteAnteriorAlSeleccionado = BuscarAnterior(NodoInicial, num);
                        if (pacienteAnteriorAlSeleccionado != null)
                        {
                            pacienteAnteriorAlSeleccionado.Siguiente = pacienteAnteriorAlSeleccionado.Siguiente.Siguiente;
                        }
                    }
                }
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

        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }

        public void QuitarUltimo()
        {
            Persona anteultimo = BuscarAnteultimo(NodoInicial);

            if (anteultimo != null)
            {
                anteultimo.Siguiente = null;
            }
            else
            {
                NodoInicial = null;
            }
        }

        private Persona BuscarAnteultimo(Persona paciente)
        {
            if (paciente is null) return null;

            if (paciente.Siguiente is null) return null;

            if (paciente.Siguiente.Siguiente != null)
                return BuscarAnteultimo(paciente.Siguiente);
            else
                return paciente;
        }

        private Persona BuscarAnterior(Persona paciente, int num)
        {
            if (paciente.Siguiente != null && paciente.Siguiente.Numero == num)
            { return paciente; }

            if (paciente.Siguiente != null)
                return BuscarAnterior(paciente.Siguiente, num);

            return null;
        }


    }
}
