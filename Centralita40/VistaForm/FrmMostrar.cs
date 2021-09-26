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

namespace VistaForm
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipo;

        public FrmMostrar(Centralita c)
        {
            InitializeComponent();
            rtbFacturacion.ReadOnly = true;
            rtbListaLlamadas.ReadOnly = true;
            this.centralita = c;
            //this.TipoLlamada = tipoLlamada;
        }

        public Provincial.TipoLlamada TipoLlamada { set { this.tipo = value;  } }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar Informacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        
    }
}
