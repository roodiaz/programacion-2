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
    public partial class Conversor : Form
    {
        //el evento leave es cuando se deja el foco del control bien sea por mouse o teclado. 

        public Conversor()
        {
            InitializeComponent();
            //puedo inicializar el form con las cotizaciones por defecto
            txtCotizDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizPesos.Text = Peso.GetCotizacion().ToString();
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if (double.TryParse(txtCotizEuro.Text, out cotiz))
            {
                Euro.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizEuro.Focus();//sino se ingresa valor valido no deja continuar
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if (double.TryParse(txtCotizDolar.Text, out cotiz))
            {
                Dolar.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizDolar.Focus();
            }
        }

        private void txtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double cotiz;

            if (double.TryParse(txtCotizPesos.Text, out cotiz))
            {
                Peso.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizPesos.Focus();
            }
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {

            if (!txtCotizDolar.Enabled)//false
            {
                txtCotizDolar.Enabled = true;
                txtCotizEuro.Enabled = true;
                txtCotizPesos.Enabled = true;
                txtDolarADolar.Enabled = true;
                txtDolarAEuro.Enabled = true;
                txtDolarAPesos.Enabled = true;
                txtEuroADolar.Enabled = true;
                txtEuroAEuro.Enabled = true;
                txtEuroAPesos.Enabled = true;
                txtPesosADolar.Enabled = true;
                txtPesosAEuro.Enabled = true;
                txtPesosAPesos.Enabled = true;
                btnLockCotizacion.Image = imageList1.Images[0];//indice 0 desbloqueado
            }
            else//true
            {
                txtCotizDolar.Enabled = false;
                txtCotizEuro.Enabled = false;
                txtCotizPesos.Enabled = false;
                txtDolarADolar.Enabled = false;
                txtDolarAEuro.Enabled = false;
                txtDolarAPesos.Enabled = false;
                txtEuroADolar.Enabled = false;
                txtEuroAEuro.Enabled = false;
                txtEuroAPesos.Enabled = false;
                txtPesosADolar.Enabled = false;
                txtPesosAEuro.Enabled = false;
                txtPesosAPesos.Enabled = false;
                btnLockCotizacion.Image = imageList1.Images[1];//indice 1 bloqueado
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double resultado;

            if (double.TryParse(txtEuro.Text, out resultado))
            {
                Euro euro = new Euro(resultado);
                txtEuroAEuro.Text = Convert.ToString(euro.GetCantidad());
                txtEuroADolar.Text = Math.Round(((Dolar)euro).GetCantidad(),2).ToString();//redondeo a 2 decimales
                txtEuroAPesos.Text = Math.Round(((Peso)euro).GetCantidad(),2).ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double resultado;

            if (double.TryParse(txtDolar.Text, out resultado))
            {
                Dolar dolar = new Dolar(resultado);
                txtDolarADolar.Text = Convert.ToString(dolar.GetCantidad());
                txtDolarAEuro.Text = Math.Round(((Euro)dolar).GetCantidad(),2).ToString();
                txtDolarAPesos.Text = Math.Round(((Peso)dolar).GetCantidad(),2).ToString();
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double resultado;

            if (double.TryParse(txtPesos.Text, out resultado))
            {
                Peso p = new Peso(resultado);
                txtPesosAPesos.Text = Convert.ToString(p.GetCantidad());
                txtPesosADolar.Text = Math.Round(((Dolar)p).GetCantidad(),2).ToString();
                txtPesosAEuro.Text = Math.Round(((Euro)p).GetCantidad(),2).ToString();
            }
        }
    }
}
