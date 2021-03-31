using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorNumeros;
using NumerosBinDec;

namespace Ejercicio25
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnBicToDec_Click(object sender, EventArgs e)
        {
            double bin;

            if (double.TryParse(txtBinario.Text, out bin)){

                NumeroBinario numBin =(string)Convert.ToString(bin); ;
                //aplico conversion implicita de clase

                NumeroDecimal d = (NumeroDecimal)numBin;

                txtBinToDec.Text = Convert.ToString(d.GetNum());

            }
            else
            {
                txtBinToDec.Text = "valor invalido";
                txtBinario.Focus();
            }
                
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double num;

            if(double.TryParse(txtDecimal.Text, out num)){

                NumeroDecimal dec = num;//conversion implicita de clase
                NumeroBinario bin = (NumeroBinario)dec;

                txtDecToBin.Text = bin.GetNum().ToString();
            }
            else
            {
                txtDecToBin.Text = "valor invalido";
                txtDecimal.Focus();
            }
        }
    }
}
