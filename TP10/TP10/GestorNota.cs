using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_B
{
    internal class GestorNota
    {
        string archivo = "notas.txt";

        public Nota[] LeerNotas()
        {
            Nota[] notas = new Nota[1];
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();
            int i = 0;

            while (linea != null)
            {
                notas[i] = new Nota(linea);
                linea = sr.ReadLine();

                if (linea != null)
                {
                    Array.Resize(ref notas, notas.Length + 1);
                }
                i++;
            }

            fs.Close();
            sr.Close();

            return notas; 
        }

        public Nota[] Ordenar()
        {
            Nota[] notas = LeerNotas();


            for (int i = 0; i < notas.Length; i++)
            {
                var tmp = notas[i];
                for (int x = i + 1; x < notas.Length; x++)
                {

                    if (notas[i].DNI > notas[x].DNI)
                    {
                        notas[i] = notas[x];
                        notas[x] = tmp;
                        tmp = notas[x];
                    }
                }
            }


            return notas;
        }

        public void GuardarNota(Nota nota)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(nota.ObtenerRegistro());
            sw.Close();
        }
    }
}
