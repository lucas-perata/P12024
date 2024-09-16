using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaEnlazadaSimple
    {
        public Paciente NodoInicial = null;

        public void AgregarAlPrincipio(string nombre, int codigo, string apellido, string direccion, int telefono)
        {
            Paciente paciente = new Paciente();
            paciente.Numero = ProximoNumero();
            paciente.Nombre = nombre;
            paciente.Apellido = apellido;
            paciente.Codigo = codigo; 
            paciente.Direccion = direccion;
            paciente.Telefono = telefono;

            if(NodoInicial == null)
            {
                NodoInicial = paciente; 
            }
            else
            {

                Paciente aux = NodoInicial;
                NodoInicial = paciente;
                NodoInicial.Siguiente = aux; 
            }
        }

        public void ActualizarPaciente(int codigo, string nuevoNombre, string nuevoApellido, string nuevaDireccion, int nuevoTelefono)
        {
            Paciente paciente = BuscarPacientePorCodigo(codigo);

            if(paciente != null)
            {
                paciente.Nombre = nuevoNombre;
                paciente.Apellido = nuevoApellido;
                paciente.Direccion = nuevaDireccion;
                paciente.Telefono = nuevoTelefono; 
            } 
        }

        private Paciente BuscarPacientePorCodigo(int codigo)
        {
            Paciente actual = NodoInicial; 

            while(actual != null)
            {
                if(actual.Codigo == codigo)
                {
                    return actual; 
                }

                actual = actual.Siguiente; 
            }

            return null;
        }

        public void AgregarAlFinal(string nombre)
        {
            Paciente paciente = new Paciente();
            paciente.Numero = ProximoNumero();
            paciente.Nombre = nombre;

            Paciente ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = paciente; 

        }

        private int ProximoNumero()
        {
            if (NodoInicial == null) return 1;
            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);
            return max + 1; 
        }

        private int BuscarMaximo(Paciente pacientes, int num)
        {
            int max = pacientes.Numero > num ? pacientes.Numero : num; 

            if(pacientes.Siguiente != null)
            {
                return BuscarMaximo(pacientes.Siguiente, max); 
            }
            else
            {
                return max; 
            }

        }

        private Paciente BuscarUltimo(Paciente paciente)
        {
            if(paciente==null) return null;

            if(paciente.Siguiente != null)
            {
                return BuscarUltimo(paciente.Siguiente); 
            } else
            {
                return paciente; 
            }
        }

        public void QuitarPrimero()
        {
            if(NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente; 
            }
        }

        public void QuitarUltimo()
        {
            Paciente anteultimo = BuscarAnteultimo(NodoInicial); 

            if(anteultimo != null)
            {
                anteultimo.Siguiente = null; 
            } else
            {
                NodoInicial = null; 
            }
        }

        private Paciente BuscarAnteultimo(Paciente paciente)
        {
            if (paciente is null) return null;

            if (paciente.Siguiente is null) return null;

            if (paciente.Siguiente.Siguiente != null)
                return BuscarAnteultimo(paciente.Siguiente);
            else
                return paciente; 
        }

        private Paciente BuscarAnterior(Paciente paciente, int num)
        {
            if(paciente.Siguiente != null && paciente.Siguiente.Numero == num)
                { return paciente; }

            if (paciente.Siguiente != null)
                return BuscarAnterior(paciente.Siguiente, num);

            return null;
        }

        public void QuitarPosicion(int num)
        {
            if (NodoInicial != null)
            {
                if(NodoInicial.Numero == num)
                {
                    QuitarPrimero();
                }
                else
                {
                    Paciente ultimo = BuscarUltimo(NodoInicial); 
                    if(ultimo != null && ultimo.Numero == num)
                    {
                        QuitarUltimo(); 
                    }
                    else
                    {
                        Paciente pacienteAnteriorAlSeleccionado = BuscarAnterior(NodoInicial, num);
                        if(pacienteAnteriorAlSeleccionado != null)
                        {
                            pacienteAnteriorAlSeleccionado.Siguiente = pacienteAnteriorAlSeleccionado.Siguiente.Siguiente; 
                        }
                    }
                }
            }    
        }

    }
}
