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

namespace VistaFrm
{
    public partial class frmPpal : Form
    {
        private EjercitoImperial ejercitoImperial;

        /// <summary>
        /// constructor del form, inicializa objeto ejercito
        /// </summary>
        public frmPpal()
        {
            InitializeComponent();
            this.ejercitoImperial = new EjercitoImperial(10);
            this.ejercitoImperial += new TrooperAsalto(Blaster.EC17,false);
            this.RefrescarEjercito();

        }


        private void frmPpal_Load(object sender, EventArgs e)
        {
            this.cmbTipo.Items.Add("Arena");
            this.cmbTipo.Items.Add("Asalto");
            this.cmbTipo.Items.Add("Explorador");

            //this.cmbTipo.DataSource = new List<string>() {"Arena", "Asalto","Explorador"};

            this.cmbBlaster.Items.Add(Blaster.DLT19);
            this.cmbBlaster.Items.Add(Blaster.E11);
            this.cmbBlaster.Items.Add(Blaster.EC17);

	    //this.cmbBlaster.DataSource = new List<Blaster>() {Blaster.DLT19, Blaster.E11,Blaster.EC17};

            this.cmbVehiculo.Items.Add("AT-RT");
            this.cmbVehiculo.Items.Add("AT-ST");
            this.cmbVehiculo.Items.Add("AT-TE");
        }

        /// <summary>
        /// metodo privado para actualizar lista de soldados
        /// </summary>
        private void RefrescarEjercito()
        {
            this.lstEjercito.Items.Clear();


            foreach (Trooper item in ejercitoImperial.Troopers)
            {
                this.lstEjercito.Items.Add(item.InfoTrooper());
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbTipo.SelectedItem is null)
            {
                MessageBox.Show("DEBE SELECCIONAR TIPO DE SOLDADO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbBlaster.SelectedItem is null)
            {
                MessageBox.Show("DEBE SELECCIONAR TIPO DE BlASTER", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbTipo.SelectedItem is "Arena")
                {

                    TrooperArena arena = new TrooperArena((Blaster)this.cmbBlaster.SelectedItem);

                    if (this.chekBoxSi.Checked)
                        arena.EsClon = true;
                    else
                        arena.EsClon = false;

                    ejercitoImperial += arena;

                }
                else if (cmbTipo.SelectedItem is "Asalto")
                {
                    TrooperAsalto asalto = new TrooperAsalto((Blaster)this.cmbBlaster.SelectedItem);

                    if (this.chekBoxSi.Checked)
                        asalto.EsClon = true;
                    else
                        asalto.EsClon = false;

                    ejercitoImperial += asalto;
                }
                else
                {

                    if (cmbVehiculo.SelectedItem is null)
                    {
                        MessageBox.Show("DEBE SELECCIONAR VEHICULO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        TrooperExplorador explorador = new TrooperExplorador(this.cmbVehiculo.SelectedItem.ToString());

                        if (this.chekBoxSi.Checked)
                            explorador.EsClon = true;
                        else
                            explorador.EsClon = false;


                        ejercitoImperial += explorador;
                    }

                }

                this.RefrescarEjercito();

            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (cmbTipo.SelectedItem is null)
            {
                MessageBox.Show("DEBE SELECCIONAR SOLDADO A RETIRAR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbTipo.SelectedItem is "Arena")
                {

                    TrooperArena arena = new TrooperArena(Blaster.EC17);

                    ejercitoImperial -= arena;

                }
                else if (cmbTipo.SelectedItem is "Asalto")
                {
                    TrooperAsalto asalto = new TrooperAsalto(Blaster.E11);

                    ejercitoImperial -= asalto;
                }
                else
                {
                    TrooperExplorador explorador = new TrooperExplorador("");

                    ejercitoImperial -= explorador;
                }

                this.RefrescarEjercito();
            }
        }

        private void frmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
