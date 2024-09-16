using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2
{
    internal class ListaEnlazada
    {
        public Alumno NodoInicial = null;

        public void AgregarAlPrincipio(Alumno alumno)
        {
            
            if (NodoInicial == null)
            {
                NodoInicial = alumno;
            }
            else
            {
                Alumno aux = NodoInicial;
                NodoInicial = alumno;
                NodoInicial.Siguiente = aux;
            }
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            Alumno alumnoActualizar = BuscarAlumnoPorDNI(alumno.DNI);

            if(alumnoActualizar != null)
            {
                alumnoActualizar.Nombre = alumno.Nombre;
                alumnoActualizar.Apellido = alumno.Apellido;
                alumnoActualizar.Telefono = alumno.Telefono;
                alumnoActualizar.Direccion = alumno.Direccion;
            }
        }

        public void AgregarDespuesSeleccionado(int dni, Alumno alumno)
        {
            Alumno seleccionado = BuscarAlumnoPorDNI(dni);

            if (seleccionado != null)
            {
                alumno.Siguiente = seleccionado.Siguiente;
                seleccionado.Siguiente = alumno;
            }
        }

        public void AgregarAntesSeleccionado(int dni, Alumno nuevoAlumno)
        {
            Alumno seleccionado = BuscarAlumnoPorDNI(dni);

            if (NodoInicial == seleccionado)
            {
                nuevoAlumno.Siguiente = NodoInicial;
                NodoInicial = nuevoAlumno;
            }
            else
            {
                Alumno anterior = BuscarAnteriorPorDNI(dni);

                if (anterior != null)
                {
                    nuevoAlumno.Siguiente = anterior.Siguiente;
                    anterior.Siguiente = nuevoAlumno;
                }
            }
        }

        private Alumno BuscarAnteriorPorDNI(int dni)
        {
            Alumno actual = NodoInicial;

            while (actual != null && actual.Siguiente != null)
            {
                if (actual.Siguiente.DNI == dni)
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        private Alumno BuscarAlumnoPorDNI(int dni)
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

        private void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }

        private Alumno BuscarUltimo(Alumno alumno)
        {
            if (alumno == null) return null;

            if (alumno.Siguiente != null)
            {
                return BuscarUltimo(alumno.Siguiente);
            }
            else
            {
                return alumno;
            }

        }

        private void QuitarUltimo()
        {
            Alumno anteultimo = BuscarAnteultimo(NodoInicial);

            if (anteultimo != null)
            {
                anteultimo.Siguiente = null;
            }
            else
            {
                NodoInicial = null;
            }
        } 

        private Alumno BuscarAnteultimo(Alumno alumno)
        {
            if (alumno is null) return null;

            if (alumno.Siguiente is null) return null;

            if (alumno.Siguiente.Siguiente != null)
                return BuscarAnteultimo(alumno.Siguiente);
            else
                return alumno; 
        }

        public void EliminarAlumno(int dni)
        {
            Alumno seleccionado = BuscarAlumnoPorDNI(dni);

            if (NodoInicial != null)
            {
                if(NodoInicial.DNI == dni)
                {
                    QuitarPrimero();
                }
                else
                {
                    Alumno ultimo = BuscarUltimo(NodoInicial);
                    if(ultimo != null && ultimo.DNI == dni)
                    {
                        QuitarUltimo(); 
                    }
                    else
                    {
                        Alumno alumnoAnteriorAlSelecionado = BuscarAnteriorPorDNI(dni);
                        if(alumnoAnteriorAlSelecionado != null)
                        {
                            alumnoAnteriorAlSelecionado.Siguiente = alumnoAnteriorAlSelecionado.Siguiente.Siguiente; 
                        }
                    } 
                        
                }
            }
        }


    }
}
