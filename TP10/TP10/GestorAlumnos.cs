using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_B
{
    internal class GestorAlumnos
    {
        string archivo = "alumnos.txt";
        string archivoAux = "alumnosAux.txt";

        public Alumno[] LeerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();

            while (linea != null)
            {
                alumnos.Add(new Alumno(linea));
                linea = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            return alumnos.ToArray();
        }

        public Alumno[] Ordenar()
        {
            Alumno[] alumnos = LeerAlumnos(); 

            for(int i = 0; i < alumnos.Length; i++)
            {
                var tmp = alumnos[i];

                for(int j = i+1; j < alumnos.Length; j++)
                    {
                        if (alumnos[j] != null)
                        {
                            if (alumnos[i].DNI > alumnos[j].DNI)
                            {
                                alumnos[i] = alumnos[j];
                                alumnos[j] = tmp;
                                tmp = alumnos[j];
                            }
                     }
                }

            }
            return alumnos.ToArray(); 
        }

        public void GuardarAlumno(Alumno alumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(alumno.ObtenerRegistro());
            sw.Close(); 
        }

        public void EditarAlumno(Alumno alumno, string dniEditar)
        {
            FileStream alumnos = new FileStream(archivo, FileMode.Open);
            FileStream alumnosAux = new FileStream(archivoAux, FileMode.Create);
            StreamReader lectorAlumnos = new StreamReader(alumnos);
            StreamWriter escritorAlumnosAux = new StreamWriter(alumnosAux);

            string reg = "";
            string dni;

            while (lectorAlumnos.Peek() > -1)
            {
                reg = lectorAlumnos.ReadLine();
                string[] VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni == dniEditar)
                {
                    escritorAlumnosAux.WriteLine(alumno.ObtenerRegistro());
                }
                else
                {
                    escritorAlumnosAux.WriteLine(reg);
                }
            }

            lectorAlumnos.Close();
            escritorAlumnosAux.Close();
            alumnos.Close();
            alumnosAux.Close();

            File.Delete(archivo);
            File.Move(archivoAux, archivo);
        }

        public void BorrarAlumno(Alumno alumno, string dniBorrar)
        {
            FileStream alumnos = new FileStream(archivo, FileMode.Open);
            FileStream alumnosAux = new FileStream(archivoAux, FileMode.Create);
            StreamReader lectorAlumnos = new StreamReader(alumnos);
            StreamWriter escritorAlumnosAux = new StreamWriter(alumnosAux);

            string reg = String.Empty;
            string dni = String.Empty; 

            while(lectorAlumnos.Peek() > - 1)
            {
                reg = lectorAlumnos.ReadLine();
                string[] VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni != dniBorrar)
                {
                    escritorAlumnosAux.WriteLine(reg);
                }
            }

            lectorAlumnos.Close();
            escritorAlumnosAux.Close();
            alumnos.Close();
            alumnosAux.Close();

            File.Delete(archivo);
            File.Move(archivoAux, archivo);
        }

    }
}
