using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadNotes();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (FileStream archivo = new FileStream("notas.txt", FileMode.Append))
            using (StreamWriter escritor = new StreamWriter(archivo))
            {
                escritor.WriteLine(this.richTextBox1.Text);
            }

            this.richTextBox1.Text = string.Empty;

            ReadNotes();
        }

        private void ReadNotes()
        {
            this.richTextBox2.Text = String.Empty;

            using (FileStream archivo = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.Read))
            using (StreamReader lector = new StreamReader(archivo))
            {
                string line;
                while ((line = lector.ReadLine()) != null)
                {
                    this.richTextBox2.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string nombre = $"notas-{DateTime.UtcNow.ToString("yyyy-MM-dd")}-bak.txt";

            using (FileStream aux = new FileStream("notas.txt", FileMode.Open))
            using (StreamReader lector = new StreamReader(aux))
            using (FileStream arc = new FileStream(nombre, FileMode.Create)) 
            using (StreamWriter escritor = new StreamWriter(arc))
            {
                string line;
                while ((line = lector.ReadLine()) != null)
                {
                    escritor.WriteLine(line);
                }
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("notas.txt", FileMode.Create);
            archivo.Close();

                ReadNotes();
        }
    }
}
