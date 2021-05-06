using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;

        /// <summary>
        /// constructor tipo form
        /// </summary>
        public FrmTest()
        {
            InitializeComponent();
            this.vendedor = new Vendedor("Rocio Diaz");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        /// <summary>
        /// muestra mensaje para confirma el cierre del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// muestra mensaje para confirma el cierre del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            } 
            
        }

        /// <summary>
        /// seleeciona publicacion de ListTextBox y agrega a lista de ventas de ser posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion venta = (Publicacion)lstStock.SelectedItem;

            if(!(lstStock.SelectedItem is null))
            {
                if (vendedor + venta)
                {
                    MessageBox.Show($"Venta realizada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay mas stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar comic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                         
        }

        /// <summary>
        /// muestra el informe de ventas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Vendedor.InformeDeVentas(vendedor);
        }

        
    }
}
