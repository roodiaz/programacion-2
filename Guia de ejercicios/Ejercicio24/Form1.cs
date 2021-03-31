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

namespace Ejercicio24
{
    public partial class ConversorGrados : Form
    {
        public ConversorGrados()
        {
            bool bloqueo = false;
            InitializeComponent();

            if (bloqueo)//si es true
            {
                txtFahrenheitToFahrenheit.Enabled = false;
                txtFahrenheitToCelsius.Enabled = false;
                txtFahrenheitToKelvin.Enabled = false;

                txtCelsiusToCelsius.Enabled = false;
                txtCelsiusToFahrenheit.Enabled = false;
                txtCelsiusToKelvin.Enabled = false;

                txtKelvinToCelsius.Enabled = false;
                txtKelvinToFahrenheit.Enabled = false;
                txtKelvinToKelvin.Enabled = false;

            }
            
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double grados;

            if (double.TryParse(txtFahrenheit.Text, out grados))
            {
                Fahrenheit f = new Fahrenheit(grados);

                txtFahrenheitToFahrenheit.Text = f.GetGrados().ToString();
                txtFahrenheitToCelsius.Text = ((Celcius)f).GetGrados().ToString();
                txtFahrenheitToKelvin.Text = ((Kelvin)f).GetGrados().ToString();
            }
            else
                txtFahrenheit.Focus();
        }

        private void ConvertCelsius_Click(object sender, EventArgs e)
        {
            double grados;

            if (double.TryParse(txtCelsius.Text, out grados))
            {
                Celcius c = new Celcius(grados);

                txtCelsiusToCelsius.Text = c.GetGrados().ToString();
                txtCelsiusToFahrenheit.Text = ((Fahrenheit)c).GetGrados().ToString();
                txtCelsiusToKelvin.Text = ((Kelvin)c).GetGrados().ToString();
            }
            else
                txtCelsius.Focus();
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double grados;

            if (double.TryParse(txtKelvin.Text, out grados))
            {
                Kelvin k = new Kelvin(grados);

                txtKelvinToKelvin.Text = k.GetGrados().ToString();
                txtKelvinToFahrenheit.Text = ((Fahrenheit)k).GetGrados().ToString();
                txtKelvinToCelsius.Text = ((Celcius)k).GetGrados().ToString();
            }
            else
                txtKelvin.Focus();
        }
    }
}
