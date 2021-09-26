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
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            txtNroDestino.ReadOnly= true;
            this.centralita = c;
        }

        public Centralita Centralita { get { return this.centralita; } }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar llamador?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSalirLlamador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
