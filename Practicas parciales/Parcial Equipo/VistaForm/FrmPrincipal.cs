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
    public partial class FrmPrincipal : Form
    {
        DirectorTecnico director;
        bool crear = false;

        public FrmPrincipal()
        {
            InitializeComponent();       
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.director = new DirectorTecnico(txtNombre.Text, txtApellido.Text,
                (int)nudEdad.Value, (int)nudDNI.Value, (int)nudExperiencia.Value);

            MessageBox.Show("Se ha creado el dt", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.crear = true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(crear == true)
            {
                if(this.director.ValidarAptitud())
                    MessageBox.Show("dt apto", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("dt no apto", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Aun no se ha creado un dt", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
