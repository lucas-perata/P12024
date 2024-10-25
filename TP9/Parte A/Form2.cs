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

namespace Parte_A
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] Unidades = Directory.GetLogicalDrives();

            for(int i = 1; i < Unidades.Length - 1; i++)
            {
                listBox2.Items.Add(Unidades[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            DateTime creacion;
            int i;
            string Ruta = textBox1.Text; 

            if(Directory.Exists(Ruta))
            {
                string[] carpetas = Directory.GetDirectories(Ruta);
                creacion = Directory.GetCreationTime(Ruta);
                string[] archivos = Directory.GetFiles(Ruta);

                for(i = 1; i < carpetas.Length - 1; i++)
                {
                    listBox1.Items.Add("Carpeta: " + Path.GetFileName(carpetas[i]));
                }

                for(i = 1; i < archivos.Length - 1; i++)
                {
                    listBox1.Items.Add("Archivo: " + Path.GetFileName(archivos[i]));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
