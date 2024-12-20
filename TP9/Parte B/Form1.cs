using System.Windows.Forms;

namespace Parte_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarAlumnos();
            ListarNotas();
        }

        private void Listar(DataGridView dgv, FileStream file, StreamReader reader)
        {
            dgv.Rows.Clear();

            string linea;
            string[] splitLinea;

            if (reader.Peek() > -1)
            {
                linea = reader.ReadLine();

                while (linea != null)
                {
                    splitLinea = linea.Split(";");
                    int n = dgv.Rows.Add();
                    for (int i = 0; i < splitLinea.Length; i++)
                    {
                        dgv.Rows[n].Cells[i].Value = splitLinea[i];
                    }
                    linea = reader.ReadLine();
                }
            }

            file.Close();
            reader.Close();
        }

        private void ListarAlumnos()
        {
            this.dataGridView1.Rows.Clear();

            FileStream alumnos = new FileStream("alumnos.txt", FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(alumnos);

            string linea;
            string[] splitLinea;

            if (lector.Peek() > -1)
            {
                linea = lector.ReadLine();

                while (linea != null)
                {
                    splitLinea = linea.Split(";");
                    int n = this.dataGridView1.Rows.Add();
                    for (int i = 0; i < splitLinea.Length; i++)
                    {
                        this.dataGridView1.Rows[n].Cells[i].Value = splitLinea[i];
                    }
                    linea = lector.ReadLine();
                }
            }

            lector.Close();
            alumnos.Close();
        }

        private void ListarNotas()
        {
            this.dataGridView2.Rows.Clear();

            FileStream notas = new FileStream("notas.txt", FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(notas);

            string linea;
            string[] splitLinea;

            linea = lector.ReadLine();

            while (linea != null)
            {
                splitLinea = linea.Split(";");
                int n = this.dataGridView2.Rows.Add();
                for (int i = 0; i < splitLinea.Length; i++)
                {
                    this.dataGridView2.Rows[n].Cells[i].Value = splitLinea[i];
                }
                linea = lector.ReadLine();
            }

            lector.Close();
            notas.Close();
        }

        private void submitAlumno_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("alumnos.txt", FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);
            StreamReader lector = new StreamReader(archivo);

            string reg;

            reg = dniAlumnos.Value.ToString() + ";" + nombreTxt.Text + ";" + apellidoTxt.Text;
            reg = String.Format("{0};{1};{2}", dniAlumnos.Value.ToString(), nombreTxt.Text, apellidoTxt.Text);
            EscritorArchivo.WriteLine(reg);
            EscritorArchivo.Close();

            dniAlumnos.Value = 0;
            apellidoTxt.Text = "";
            nombreTxt.Text = "";
            dniAlumnos.Focus();

            Listar(dataGridView1, archivo, lector);
        }

        private void submitNota_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("notas.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            string reg;


            reg = dniNotas.Value.ToString() + ";" + dateNota.Value.ToShortDateString() + ";" + notaNum.Value.ToString();
            reg = String.Format("{0};{1};{2}", dniNotas.Value.ToString(), dateNota.Value.ToString(), notaNum.Value.ToString());
            escritor.WriteLine(reg);
            escritor.Close();

            dniNotas.Value = 0;
            notaNum.Value = 0;

            ListarNotas();
        }

        private void alumnoEdit_Click(object sender, EventArgs e)
        {
            FileStream alumnos = new FileStream("alumnos.txt", FileMode.Open);
            FileStream alumnosAux = new FileStream("alumnosAux.txt", FileMode.Create);
            StreamReader lectorAlumnos = new StreamReader(alumnos);
            StreamWriter escritorAlumnosAux = new StreamWriter(alumnosAux);
            String[] VectorRegAux = new string[0];

            string reg = "";
            string dni;

            while (lectorAlumnos.Peek() > -1)
            {
                reg = lectorAlumnos.ReadLine();
                VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni == GetDni(dataGridView1))
                {
                    reg = String.Format("{0};{1};{2}", dniAlumnos.Value.ToString(), nombreTxt.Text, apellidoTxt.Text);
                }

                escritorAlumnosAux.WriteLine(reg);
            }

            lectorAlumnos.Close();
            alumnos.Close();
            escritorAlumnosAux.Close();
            alumnosAux.Close();

            File.Delete("alumnos.txt");
            File.Move("alumnosAux.txt", "alumnos.txt");

            dniAlumnos.Value = 0;
            apellidoTxt.Text = "";
            nombreTxt.Text = "";

            ListarAlumnos();
        }

        private void alumnoDelete_Click(object sender, EventArgs e)
        {
            FileStream alumnos = new FileStream("alumnos.txt", FileMode.Open);
            FileStream alumnosAux = new FileStream("alumnosAux.txt", FileMode.Create);
            StreamReader lectorAlumnos = new StreamReader(alumnos);
            StreamWriter escritorAlumnosAux = new StreamWriter(alumnosAux);

            String[] VectorRegAux = new string[0];

            string reg;
            string dni;


            while (lectorAlumnos.Peek() > -1)
            {
                reg = lectorAlumnos.ReadLine();
                VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni != GetDni(dataGridView1))
                {
                    escritorAlumnosAux.WriteLine(reg);
                }
            }

            lectorAlumnos.Close();
            alumnos.Close();
            escritorAlumnosAux.Close();
            alumnosAux.Close();

            File.Delete("alumnos.txt");
            File.Move("alumnosAux.txt", "alumnos.txt");

            dniAlumnos.Value = 0;
            apellidoTxt.Text = "";
            nombreTxt.Text = "";

            ListarAlumnos();
        }

        private void notaEdit_Click(object sender, EventArgs e)
        {
            FileStream notas = new FileStream("notas.txt", FileMode.Open);
            FileStream notasAux = new FileStream("notasAux.txt", FileMode.Create);
            StreamReader lectorNotas = new StreamReader(notas);
            StreamWriter escritorNotasAux = new StreamWriter(notasAux);
            String[] VectorRegAux = new string[0];

            string reg = "";
            string dni;

            while (lectorNotas.Peek() > -1)
            {
                reg = lectorNotas.ReadLine();
                VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni == GetDni(dataGridView2))
                {
                    reg = String.Format("{0};{1};{2}", GetDni(dataGridView2), notaNum.Text, dateNota.Text);
                }

                escritorNotasAux.WriteLine(reg);
            }

            lectorNotas.Close();
            notas.Close();
            escritorNotasAux.Close();
            notasAux.Close();

            File.Delete("notas.txt");
            File.Move("notasAux.txt", "notas.txt");

            dniAlumnos.Value = 0;
            apellidoTxt.Text = "";
            nombreTxt.Text = "";

            ListarNotas();
        }

        private void notaDelete_Click(object sender, EventArgs e)
        {
            FileStream notas = new FileStream("notas.txt", FileMode.Open);
            FileStream notasAux = new FileStream("notasAux.txt", FileMode.Create);
            StreamReader lectorNotas = new StreamReader(notas);
            StreamWriter escritorNotasAux = new StreamWriter(notasAux);

            String[] VectorRegAux = new string[0];

            string reg;
            string dni; 

            while(lectorNotas.Peek() > - 1)
            {
                reg = lectorNotas.ReadLine();
                VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if(dni != GetDni(dataGridView2))
                {
                    escritorNotasAux.WriteLine(reg);
                }
            }

            lectorNotas.Close();
            notas.Close();
            escritorNotasAux.Close();
            notasAux.Close();

            File.Delete("notas.txt");
            File.Move("notasAux.txt", "notas.txt");

            dniNotas.Value = 0;

            ListarNotas();
        }

        private string GetDni(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[3].Value);

                if (isChecked)
                {
                    string dataInColumn2 = row.Cells[0].Value.ToString(); 
                    return dataInColumn2;
                }
            }

            return String.Empty;
        }
    }
}
