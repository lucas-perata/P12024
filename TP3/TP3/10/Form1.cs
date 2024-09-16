using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            textBox2.Text = ConvertMain(num).ToString();

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = num;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = GetCheckedRadioButtonText(groupBox1);
            dataGridView1.Rows[n].Cells[3].Value = GetCheckedRadioButtonText(groupBox2);
        }

        private string GetCheckedRadioButtonText(GroupBox groupBox)
        {
            var checkedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            return checkedRadioButton?.Text;
        }

        private double ConvertMain(int n)
        {
            // Caso Base
            if(cel1Btn.Checked && cel2Btn.Checked) { return n; }
            if(kel1Btn.Checked && kel2Btn.Checked) { return n; }
            if(far1Btn.Checked && far2Btn.Checked) { return n; }
            if(ran1Btn.Checked && ran2Btn.Checked) { return n; }

            // Kelvin 
            if(kel1Btn.Checked && cel2Btn.Checked) { return ConvertFromKelvinToCelcius(n); }
            if(kel1Btn.Checked && far2Btn.Checked) { return ConvertFromKelvinToFahrenheit(n); }
            if(kel1Btn.Checked && ran2Btn.Checked ) { return ConvertFromKelvinToRankine(n); }

            // Celcius 
            if(cel1Btn.Checked && ran2Btn.Checked ) { return ConvertToRankineFromCelcius(n); }
            if(cel1Btn.Checked && far2Btn.Checked) { return ConvertToFahrenheitFromCelcius(n); }
            if(cel1Btn.Checked && kel2Btn.Checked) { return ConvertToKelvinFromCelcius(n); }

            // Fahrenheit
            if(far1Btn.Checked && ran2Btn.Checked) { return ConvertFromFahrenheitToRankine(n); }
            if(far1Btn.Checked && kel2Btn.Checked) { return ConvertFromFahrenheitToKelvin(n); }
            if(far1Btn.Checked && cel2Btn.Checked) { return ConvertFromFahrenheitToCelcius(n); }

            // Rankine 
            if(ran1Btn.Checked && cel2Btn.Checked) { return ConvertFromRankineToCelcius(n); }
            if(ran1Btn.Checked && kel2Btn.Checked) { return ConvertFromRankineToKelvin(n); }
            if(ran1Btn.Checked && far2Btn.Checked) { return ConvertFromRankineToFahrenheit(n); }

            return n; 
        }

        // Kelvin 
        private double ConvertFromKelvinToCelcius(int n) 
        { 
            return n - 273.15;
        }

        private double ConvertFromKelvinToFahrenheit(int n)
        {
            return (n - 273.15) * 1.8 + 32;
        }

        private double ConvertFromKelvinToRankine(int n)
        {
            return n * 1.8;
        }

        // Celcius 
        private double ConvertToKelvinFromCelcius(int n) 
        {
            return n + 273.15;
        }
        private double ConvertToFahrenheitFromCelcius(int n) 
        {
            return (n * 1.8) + 32; 
        }
        private double ConvertToRankineFromCelcius(int n) 
        {
            return (n * 1.8) + 491.67;
        }

        // Fahrenheit
        private double ConvertFromFahrenheitToCelcius(int n) 
        {
            return (n - 32) * 0.55;
        }
        private double ConvertFromFahrenheitToKelvin(int n) 
        {
            return (n - 32) * 0.55 + 273.15; 
        }
        private double ConvertFromFahrenheitToRankine(int n) 
        { 
            return n + 459.67; 
        }

        // Rankine 
        private double ConvertFromRankineToCelcius(int n) 
        {
            return (n - 491.67) * 0.55;
        }
        private double ConvertFromRankineToKelvin(int n) 
        { 
            return n * 0.55; 
        }
        private double ConvertFromRankineToFahrenheit(int n) 
        {
            return n-459.67; 
        }
    }
}
