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
    public partial class FrmMenu : Form
    {
        FrmMostrar frmMostrar;
        Centralita c;

        public FrmMenu()
        {
            InitializeComponent();         
            c = new Centralita("Rocio Center");
            frmMostrar = new FrmMostrar(c);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar central telefonica?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel=true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(c);
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar.ShowDialog();
        }

        
    }
}
