using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Listas4
{
    internal class ListaEnlazadaCircular
    {
        public Alumno NodoInicial = null;
        public Alumno NodoActual = null;
        public Alumno head = null; 

        public void Agregar(Alumno alumno)
        {
            if (head == null)
            {
                head = alumno;
                NodoInicial = alumno; 
                head.Siguiente = head;
            }
            else
            {
                Alumno temp = head;
                while (temp.Siguiente != head)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = alumno;
                alumno.Siguiente = head;
            }
        }

        public void AgregarDespuesDe(int dni, Alumno nuevoAlumno)
        {
            Alumno actual = BuscarAlumnoPorDni(dni);

            if(actual != null)
            {
                nuevoAlumno.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevoAlumno;

                if(actual == head)
                {
                    head = nuevoAlumno;
                }
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
