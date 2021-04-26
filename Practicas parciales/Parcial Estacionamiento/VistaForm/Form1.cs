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

    public partial class FormPrincipal : Form
    {
        PickUp pickup;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxModelo.Text) && !String.IsNullOrWhiteSpace(txtBoxPatente.Text) && txtBoxPatente.Text.Length == 6)
            {
                pickup = new PickUp(txtBoxPatente.Text, txtBoxModelo.Text);
                MessageBox.Show($"{pickup.ConsultarDatos()}", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
