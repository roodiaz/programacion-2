using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monedas;


namespace Ejercicio23
{
    public partial class FormMonedas : Form
    {
        public FormMonedas()
        {
            InitializeComponent();
            //puedo inicializar el form con las cotizaciones por defecto
            txtCotizacionDolar.Text = Convert.ToString(Dolar.GetCotizacion());
            txtCotizacionEuro.Text = Convert.ToString(Euro.GetCotizacion());
            txtCotizacionPesos.Text = Convert.ToString(Pesos.GetCotizacion());
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if(double.TryParse(txtCotizacionEuro.Text, out cotiz))
            {
                Euro.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if (double.TryParse(txtCotizacionDolar.Text, out cotiz))
            {
                Dolar.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if (double.TryParse(txtCotizacionPesos.Text, out cotiz))
            {
                Pesos.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionPesos.Focus();
            }
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {


            if (!txtCotizacionDolar.Enabled)
            {
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPesos.Enabled = true;
                txtDolarADolar.Enabled = true;
                txtDolarAEuro.Enabled = true;
                txtDolarAPesos.Enabled = true;
                txtEuroADolar.Enabled = true;
                txtEuroAEuro.Enabled = true;
                txtEuroAPesos.Enabled = true;
                txtPesosADolar.Enabled = true;
                txtPesosAEuro.Enabled = true;
                txtPesosAPesos.Enabled = true;
                btnLockCotizacion.Image = imageList1.Images[0];
            }
            else
            {
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPesos.Enabled = false;
                txtDolarADolar.Enabled = false;
                txtDolarAEuro.Enabled = false;
                txtDolarAPesos.Enabled = false;
                txtEuroADolar.Enabled = false;
                txtEuroAEuro.Enabled = false;
                txtEuroAPesos.Enabled = false;
                txtPesosADolar.Enabled = false;
                txtPesosAEuro.Enabled = false;
                txtPesosAPesos.Enabled = false;
                btnLockCotizacion.Image = imageList1.Images[1];
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double resultado;

            if(double.TryParse(txtEuro.Text, out resultado))
            {
                Euro euro = new Euro(resultado);
                txtEuroAEuro.Text = Convert.ToString(euro.GetCantidad());
                txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
                txtEuroAPesos.Text = ((Pesos)euro).GetCantidad().ToString();                            
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double resultado;

            if (double.TryParse(txtDolar.Text, out resultado))
            {
                Dolar dolar = new Dolar(resultado);
                txtDolarADolar.Text = Convert.ToString(dolar.GetCantidad());
                txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double resultado;

            if(double.TryParse(txtPesos.Text,out resultado))
            {
                Pesos p = new Pesos(resultado);
                txtPesosAPesos.Text = Convert.ToString(p.GetCantidad());
                txtPesosADolar.Text = ((Dolar)p).GetCantidad().ToString();
                txtPesosAEuro.Text = ((Euro)p).GetCantidad().ToString();
            }
        }
    }
}
