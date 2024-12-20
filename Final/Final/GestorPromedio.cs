using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    internal class GestorPromedio
    {
        string archivo = "promedios.txt";

        private void GuardarPromedios(Promedio[] promedios)
        {
            // Recibe la lista de promedios ya procesada 
            // y los guarda en un archivo 

            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach(Promedio p in promedios)
            {
                sw.WriteLine("{0};{1};{2};{3}", p.Legajo, p.Nombre, p.Apellido, p.ValorPromedio);
            }

            sw.Close();
        }

        public Promedio[] ObtenerPromedios(Alumno[] alumnos, Nota[] notas)
        {
            FileStream fs = new FileStream(archivo, FileMode.Truncate);

            List<Promedio> promedios = new List<Promedio>();

            // Simula el apareo de datos secuenciales procesando dos listas ya ordenadas (alumnos y notas).
            // Luego, aplica un corte de control para calcular el promedio de cada alumno basado en su Legajo.

            // Recorre la lista de alumnos para procesarlos uno por uno.
            for (int i = 0; i < alumnos.Length; i++)
            {
                // Crea un nuevo objeto Promedio y asigna los datos básicos del alumno.
                Promedio p = new Promedio();
                p.Legajo = alumnos[i].Legajo;      
                p.Nombre = alumnos[i].Nombre;    
                p.Apellido = alumnos[i].Apellido; 

                int contador = 0;    
                int acumulador = 0;  

                // Recorre la lista de notas para buscar las que pertenecen al alumno actual.
                for (int j = 0; j < notas.Length; j++)
                {
                    // Si la nota pertenece al alumno actual (mismo Legajo) y es aprobada (mayor a 4):
                    if (notas[j].Legajo == alumnos[i].Legajo && notas[j].Valor > 4)
                    {
                        contador++;               // Incrementa el contador de notas aprobadas.
                        acumulador += notas[j].Valor; // Suma el valor de la nota al acumulador.
                    }
                }

                // Calcula el promedio de las notas aprobadas:
                // Si no hay notas aprobadas, el promedio es 0. De lo contrario, se divide el acumulador
                // entre el contador de notas aprobadas.
                p.ValorPromedio = contador == 0 ? 0 : acumulador / contador;

                // Agrega el objeto Promedio calculado a la lista.
                promedios.Add(p);
            }

            fs.Close();

            GuardarPromedios(promedios.ToArray());

            return promedios.ToArray();
        }

        public Promedio ObtenerMejorPromedio(Promedio[] promedios)
        {
            Promedio mejorPromedio = new Promedio();

            foreach (Promedio p in promedios) 
            {
                if(p.ValorPromedio > mejorPromedio.ValorPromedio)
                {
                    mejorPromedio = p;
                }
            }
            return mejorPromedio;
        }
    }
}
