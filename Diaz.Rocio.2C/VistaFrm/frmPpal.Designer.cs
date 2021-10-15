
namespace VistaFrm
{
    partial class frmPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPpal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chekBoxSi = new System.Windows.Forms.CheckBox();
            this.cmbBlaster = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmpPal.Properties.Resources.stormtrooper;
            this.pictureBox1.Location = new System.Drawing.Point(31, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(31, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(134, 23);
            this.cmbTipo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(31, 303);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(134, 36);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // lstEjercito
            // 
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 15;
            this.lstEjercito.Location = new System.Drawing.Point(181, 27);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(624, 304);
            this.lstEjercito.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Es clon";
            // 
            // chekBoxSi
            // 
            this.chekBoxSi.AutoSize = true;
            this.chekBoxSi.Location = new System.Drawing.Point(263, 362);
            this.chekBoxSi.Name = "chekBoxSi";
            this.chekBoxSi.Size = new System.Drawing.Size(35, 19);
            this.chekBoxSi.TabIndex = 7;
            this.chekBoxSi.Text = "SI";
            this.chekBoxSi.UseVisualStyleBackColor = true;
            // 
            // cmbBlaster
            // 
            this.cmbBlaster.FormattingEnabled = true;
            this.cmbBlaster.Location = new System.Drawing.Point(398, 354);
            this.cmbBlaster.Name = "cmbBlaster";
            this.cmbBlaster.Size = new System.Drawing.Size(121, 23);
            this.cmbBlaster.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Blaster";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(563, 354);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(121, 23);
            this.cmbVehiculo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vehiculo";
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBlaster);
            this.Controls.Add(this.chekBoxSi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fabrica de troopes del  Lado Oscuro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPpal_FormClosing);
            this.Load += new System.EventHandler(this.frmPpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chekBoxSi;
        private System.Windows.Forms.ComboBox cmbBlaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label4;
    }
}

