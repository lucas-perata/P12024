using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas4
{
    internal class ListaEnlazadaCircular
    {
        public Alumno NodoInicial = null;
        public Alumno NodoActual = null;

        public void AgregarFinal(Alumno alumno)
        {
            if (NodoInicial == null)
            {
                NodoInicial = alumno;
                NodoInicial.Siguiente = NodoInicial;
            }
            else
            {
                Alumno actual = NodoInicial;

                while (actual.Siguiente != NodoInicial)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = alumno;
                alumno.Siguiente = NodoInicial;
            }
        }

        public void AgregarPrimero(Alumno alumno)
        {
            if (NodoInicial == null)
            {
                NodoInicial = alumno;
                NodoInicial.Siguiente = NodoInicial;
            }
            else
            {
                Alumno actual = NodoInicial;

                while (actual.Siguiente != NodoInicial)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = alumno;

                alumno.Siguiente = NodoInicial;
                NodoInicial = alumno;
            }
        }

        private Alumno BuscarAlumnoPorDni(int dni)
        {
            Alumno actual = NodoInicial;

            while (actual != null)
            {
                if (actual.DNI == dni)
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public void ActualizarAlumno(Alumno alumnoActualizado)
        {
            Alumno alumno = BuscarAlumnoPorDni(alumnoActualizado.DNI);

            if (alumno != null)
            {
                alumno.Nombre = alumnoActualizado.Nombre;
                alumno.Apellido = alumnoActualizado.Apellido;
                alumno.Edad = alumnoActualizado.Edad;
            }
        }

        public void Eliminar(int dni)
        {
            if (NodoInicial == null) return;

            if (NodoInicial.DNI == dni)
            {
                if (NodoInicial.Siguiente == NodoInicial)
                {
                    NodoInicial = null; 
                }
                else
                {
                    Alumno actual = NodoInicial;
                    while (actual.Siguiente != NodoInicial)
                    {
                        actual = actual.Siguiente;
                    }

                    actual.Siguiente = NodoInicial.Siguiente;
                    NodoInicial = NodoInicial.Siguiente;
                }
            }
            else
            {
                Alumno actual = NodoInicial;
                while (actual.Siguiente != NodoInicial && actual.Siguiente.DNI != dni)
                {
                    actual = actual.Siguiente;
                }

                if (actual.Siguiente.DNI == dni)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }
            }

        }
    }
}
