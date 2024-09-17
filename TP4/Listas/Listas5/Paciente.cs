using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas5
{
    public class Paciente
    {   
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public int Telefono;
        public Paciente Siguiente;
        public Paciente Anterior; 
    }
}
