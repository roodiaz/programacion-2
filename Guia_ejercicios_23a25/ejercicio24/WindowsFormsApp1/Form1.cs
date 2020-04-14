using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grados;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double grados;

            if(double.TryParse(txtFahrenheit.Text,out grados))
            {
                Fahrenheit f = new Fahrenheit(grados);

                txtFahrenheitToFahrenheit.Text = Convert.ToString(f.GetGrados());
                txtFahrenheitToKelvin.Text = ((Kelvin)f).GetGrados().ToString();
                txtFarenheitToCelcius.Text = ((Celcius)f).GetGrados().ToString();
            }
        }

        private void btnConvertCelcius_Click(object sender, EventArgs e)
        {
            double grados;

            if (double.TryParse(txtCelcius.Text, out grados))
            {
                Celcius c = new Celcius(grados);

                txtCelciusToCelcius.Text = Convert.ToString(c.GetGrados());
                txtCelciusToKelvin.Text = ((Kelvin)c).GetGrados().ToString();
                txtCelciusToFahrenheit.Text = ((Fahrenheit)c).GetGrados().ToString();
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double grados;

            if (double.TryParse(txtKelvin.Text, out grados))
            {
                Kelvin k = new Kelvin(grados);

                txtKelvinToKelvin.Text = Convert.ToString(k.GetGrados());
                txtKelvinToCelcius.Text = ((Celcius)k).GetGrados().ToString();
                txtKelvinToFahrenheit.Text = ((Fahrenheit)k).GetGrados().ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Clear();
            txtCelcius.Clear();
            txtKelvin.Clear();

            txtKelvinToKelvin.Clear();
            txtKelvinToCelcius.Clear();
            txtKelvinToFahrenheit.Clear();

            txtCelciusToCelcius.Clear();
            txtCelciusToKelvin.Clear();
            txtCelciusToFahrenheit.Clear();

            txtFahrenheitToFahrenheit.Clear();
            txtFahrenheitToKelvin.Clear();
            txtFarenheitToCelcius.Clear();
        }
    }
}
