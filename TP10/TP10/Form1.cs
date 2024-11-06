using System.Windows.Forms;

namespace Parte_B
{
    public partial class Form1 : Form
    {
        GestorAlumnos gestorAlumnos;
        GestorNota gestorNotas;
        public Form1()
        {
            InitializeComponent();
            gestorAlumnos = new GestorAlumnos();
            gestorNotas = new GestorNota();
            ListarAlumnos();
            ListarNotas();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarAlumnos();
            ListarNotas();
        }
        private void ListarAlumnos()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = gestorAlumnos.LeerAlumnos();
        }

        private void ListarNotas()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = gestorNotas.LeerNotas();
        }

        private void submitAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((int)this.dniAlumnos.Value, this.nombreTxt.Text, this.apellidoTxt.Text);
            gestorAlumnos.GuardarAlumno(alumno);
            ListarAlumnos();
        }

        private void submitNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota((int)this.dniNotas.Value, this.dateNota.Value, (int)this.notaNum.Value);
            gestorNotas.GuardarNota(nota);
            ListarNotas();
        }

        private void alumnoEdit_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno(GetDni(dataGridView1), this.nombreTxt.Text, this.apellidoTxt.Text);
            gestorAlumnos.EditarAlumno(alumno, GetDni(dataGridView1).ToString());
        }

        private void alumnoDelete_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno(GetDni(dataGridView1), this.nombreTxt.Text, this.apellidoTxt.Text);
            gestorAlumnos.BorrarAlumno(alumno, GetDni(dataGridView1).ToString());
            ListarAlumnos();

            dataGridView3.DataSource = null;
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

                if (dni == GetDni(dataGridView2).ToString())
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

            while (lectorNotas.Peek() > -1)
            {
                reg = lectorNotas.ReadLine();
                VectorRegAux = reg.Split(";");
                dni = VectorRegAux[0];

                if (dni != GetDni(dataGridView2).ToString())
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

        private int GetDni(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);

                if (isChecked)
                {
                    string dataInColumn2 = row.Cells[1].Value.ToString();
                    return Convert.ToInt32(dataInColumn2);
                }
            }

            return 0;
        }

        private void promedioBtn_Click(object sender, EventArgs e)
        {
            Alumno[] alumnos = gestorAlumnos.Ordenar();
            Nota[] notas = gestorNotas.Ordenar();

            if (alumnos == null || alumnos.Length == 0)
            {
                MessageBox.Show("No hay alumnos disponibles.");
                return;
            }

            if (notas == null || notas.Length == 0)
            {
                MessageBox.Show("No hay notas disponibles.");
                return;
            }

            List<Promedio> promedios = new List<Promedio>();

            for (int i = 0; i < alumnos.Length; i++)
            {
                Promedio p = new Promedio();
                p.DNI = alumnos[i].DNI;
                p.Nombre = alumnos[i].Nombre;
                p.Apellido = alumnos[i].Apellido;

                int contador = 0;
                int acumulador = 0;
                for (int x = 0; x < notas.Length; x++)
                {
                    if (notas[x].DNI == alumnos[i].DNI)
                    {
                        contador++;
                        acumulador += notas[x].ValorNota;
                    }
                }

                p.ValorPromedio = contador == 0 ? 0 : acumulador / contador;
                promedios.Add(p);
            }

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = promedios;
        }
    }
}
