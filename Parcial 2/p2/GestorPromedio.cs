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

            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach(Promedio p in promedios)
            {
                sw.WriteLine(p);
            }

            sw.Close();
        }

        public Promedio[] ObtenerPromedios(Alumno[] alumnos, Nota[] notas)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            List<Promedio> promedios = new List<Promedio>();

            for(int i = 0; i < alumnos.Length; i++)
            {
                Promedio p = new Promedio();
                p.Legajo = alumnos[i].Legajo;
                p.Nombre = alumnos[i].Nombre;   
                p.Apellido = alumnos[i].Apellido;

                int contador = 0;
                int acumulador = 0; 

                for(int j = 0; j < notas.Length; j++)
                {
                    if (notas[j].Legajo == alumnos[i].Legajo && notas[j].Valor > 4)
                    {
                        contador++;
                            acumulador += notas[j].Valor;
                    }
                }

                p.ValorPromedio = contador == 0 ? 0 : acumulador / contador;
                promedios.Add(p);
            }
            fs.Close();
            GuardarPromedios(promedios.ToArray());
            return promedios.ToArray();
        }

        public double ObtenerMejorPromedio(Promedio[] promedios)
        {
            double mejorPromedio = 0;

            foreach (Promedio p in promedios) 
            {
                if(p.ValorPromedio > mejorPromedio)
                {
                    mejorPromedio = p.ValorPromedio;
                }
            }
            return mejorPromedio;
        }
    }
}
