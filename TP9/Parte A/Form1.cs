using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parte_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("archivo.txt", FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);
            string reg;

            reg = txtleg.Text + ";" + txtnom.Text + ";" + txtcat.Text; 
            reg = String.Format("{0};{1};{2}", txtleg.Text, txtnom.Text, txtcat.Text);
            EscritorArchivo.WriteLine(reg);
            EscritorArchivo.Close();
            txtleg.Text = "";
            txtnom.Text = "";
            txtcat.Text = "";
            txtleg.Focus();
            Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar() 
        {
            this.listBox1.Items.Clear();

            FileStream miArchivo = new FileStream("archivo.txt", FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(miArchivo);

            string linea;
            linea = lector.ReadLine();

            while(linea!=null)
            {
                this.listBox1.Items.Add(linea);
                linea = lector.ReadLine(); 
            }

            lector.Close();
            miArchivo.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Baja 
            FileStream archivo = new FileStream("archivo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("archivoAux.txt", FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            String[] VectorRegAux = new String[0];

            string reg;
            string legajo; 

            while(LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];

                if (legajo != txtleg.Text)
                {
                    EscritorArchivoAux.WriteLine(reg);
                }
            }

            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            File.Delete("archivo.txt");
            File.Move("archivoAux.txt", "archivo.txt");

            txtleg.Text = "";
            txtnom.Text = "";
            txtcat.Text = "";

            txtleg.Focus();
            Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("archivo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("archivoAux.txt", FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);
            String[] VectorRegAux = new string[0];

            string reg = "";
            string legajo; 


            while(LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];

                if(legajo == txtleg.Text)
                {
                    reg = String.Format("{0};{1};{2}", txtleg.Text, txtnom.Text, txtcat.Text);  
                }

                EscritorArchivoAux.WriteLine(reg);
            }

            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            File.Delete("archivo.txt");
            File.Move("archivoAux.txt","archivo.txt");
            txtleg.Text = "";
            txtnom.Text = "";
            txtcat.Text = "";

            txtleg.Focus();
            Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedItem != null)
            {
                string seleccionado = listBox1.SelectedItem.ToString();
                string[] vectorLista = new string[0];
                vectorLista = seleccionado.Split(';');
                txtleg.Text = vectorLista[0];
                txtnom.Text = vectorLista[1];
                txtcat.Text = vectorLista[2];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
