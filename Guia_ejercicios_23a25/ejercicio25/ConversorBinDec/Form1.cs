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
           double aux = Conversor.BinarioDecimal(txtNum1.Text);

            if (aux == 0)
                txtConversionDec.Text = "Invalido";
            else
                txtConversionDec.Text = aux.ToString();

            txtConversionDec.Enabled = false;
        }  

        private void btnConvertToBin_Click(object sender, EventArgs e)
        {
            int aux;

            if(int.TryParse(txtNum2.Text,out aux))
                txtConversionBin.Text = Conversor.DecimalBinario(aux);              
            else
                txtConversionBin.Text = "Valor invalido";

            txtConversionBin.Enabled = false;
        }
    }
}
