using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.numericUpDownCapacidad.Value = 1000;
            this.numericUpDownContenido.Value = 1000;
            this.barra1.SetCantina = Cantina.GetCantina(10);
            this.comboBoxBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxBotellaTipo.SelectedValue.ToString(), out tipo);

            if (rdioBtnAgua.Checked)
            {
                Agua water = new Agua((int)this.numericUpDownCapacidad.Value, this.txtMarca.Text, (int)this.numericUpDownContenido.Value);
                this.barra1.AgregarBotella(water);
            }
            else
            {
                Cerveza beer = new Cerveza((int)this.numericUpDownCapacidad.Value, this.txtMarca.Text, (Botella.Tipo)comboBoxBotellaTipo.SelectedItem,(int)this.numericUpDownContenido.Value);
                this.barra1.AgregarBotella(beer);
            }
        }
    }
}
