using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        Entidades.Jardin miJardin;

        public Form1()
        {
            InitializeComponent();          
        }

        private void Jardin_Load(object sender, EventArgs e)
        {
            miJardin = new Jardin(100);

            bool pudo = miJardin + new Arbusto("Arbusto 1", 10);
            pudo = this.miJardin + new Arbusto("Arbusto 2", 15);
            pudo = this.miJardin + new Rosal("Rosa 1", 20, Rosal.Color.Amarrilla);
            pudo = this.miJardin + new Rosal("Rosa clásica", 25);
            pudo = this.miJardin + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.miJardin + new Banano("No carga", 1, "ARG028")))
            {
                MessageBox.Show(" ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = miJardin.ToString();
        }
    }
}
