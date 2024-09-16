using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas5
{
    internal class ListaDoblementeEnlazada
    {
        public Paciente NodoInicial = null;
        public Paciente NodoFinal = null; 

        public void AgregarPrincipio(Paciente paciente)
        {
            if(NodoInicial == null)
            {
                NodoInicial = paciente;
                NodoFinal = paciente; 
            }
            else
            {
                paciente.Siguiente = NodoInicial;
                NodoInicial.Anterior = paciente;
                NodoInicial = paciente; 
            }
        }

        public void AgregarFinal(Paciente paciente)
        {
            if (NodoInicial == null)
            {
                AgregarPrincipio(paciente);
            }
            else
            {
                NodoFinal.Siguiente = paciente;
                paciente.Anterior = NodoFinal;
                NodoFinal = paciente;
            }
        }

        public void AgregarPosicion(Paciente paciente, int posicion)
        {
            if (posicion <= 1)
            {
                AgregarPrincipio(paciente);
            }
            else
            {
                Paciente actual = NodoInicial;
                int contador = 1;

                while (actual != null && contador < posicion - 1)
                {
                    actual = actual.Siguiente;
                    contador++;
                }

                if (actual == null || actual.Siguiente == null)
                {
                    AgregarFinal(paciente);
                }
                else
                {
                    Paciente siguiente = actual.Siguiente;
                    actual.Siguiente = paciente;
                    paciente.Anterior = actual;
                    paciente.Siguiente = siguiente;
                    siguiente.Anterior = paciente;
                }
            }
        }

        private Paciente BuscarPacienteCodigo(int cod)
        {
            Paciente actual = NodoInicial; 

            while(actual != null)
            {
                if(actual.Codigo == cod)
                {
                    return actual; 
                }

                actual = actual.Siguiente; 
            }

            return null; 
        }

        public void Actualizar(int cod, Paciente actualizado)
        {
            Paciente paciente = BuscarPacienteCodigo(cod); 

            if(paciente != null)
            {
                paciente.Nombre = actualizado.Nombre;
                paciente.Apellido = actualizado.Apellido;
                paciente.Telefono = actualizado .Telefono;
                paciente.Direccion = actualizado.Direccion;
            }
        }


        public void Eliminar(int cod)
        {
            Paciente paciente = BuscarPacienteCodigo(cod);

            if (paciente == NodoInicial)
            {
                NodoInicial = NodoInicial.Siguiente;
                if (NodoInicial != null)
                {
                    NodoInicial.Anterior = null;
                }
                else
                {
                    NodoFinal = null; 
                }
            }
            else if (paciente == NodoFinal)
            {
                NodoFinal = NodoFinal.Anterior;
                if (NodoFinal != null)
                {
                    NodoFinal.Siguiente = null;
                }
                else
                {
                    NodoInicial = null;  
                }
            }
            else
            {
                Paciente anterior = paciente.Anterior;
                Paciente siguiente = paciente.Siguiente;

                if (anterior != null)
                {
                    anterior.Siguiente = siguiente;
                }

                if (siguiente != null)
                {
                    siguiente.Anterior = anterior;
                }
            }
        }


    }
}
