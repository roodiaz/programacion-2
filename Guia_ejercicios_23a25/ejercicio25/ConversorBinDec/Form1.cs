using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversores;

namespace ConversorBinDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtConversionBin.Text = "0";
            txtConversionDec.Text = "0";
        }

        //decimal a binario
        private void btnConvertToDec_Click(object sender, EventArgs e)
        {
            NumeroBinario b = new NumeroBinario(txtNum1.Text);
            NumeroDecimal d = (NumeroDecimal)b;

            if (d.GetDecimal() == 0)
                txtConversionDec.Text = "Invalido";
            else
                txtConversionDec.Text = d.GetDecimal().ToString();

            txtConversionDec.Enabled = false;
        }  

        private void btnConvertToBin_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(txtNum2.Text,out aux))
            {
                NumeroDecimal d = new NumeroDecimal(aux);
                NumeroBinario b = (NumeroBinario)d;
                txtConversionBin.Text = b.GetBin();
            }              
            else
                txtConversionBin.Text = "Valor invalido";

            txtConversionBin.Enabled = false;
        }
    }
}
