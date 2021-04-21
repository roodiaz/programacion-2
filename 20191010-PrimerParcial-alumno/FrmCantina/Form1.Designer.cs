namespace FrmCantina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDownCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.Marca = new System.Windows.Forms.Label();
            this.BotellaTipo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.comboBoxBotellaTipo = new System.Windows.Forms.ComboBox();
            this.rdioBtnCerveza = new System.Windows.Forms.RadioButton();
            this.rdioBtnAgua = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Capacidad = new System.Windows.Forms.Label();
            this.Contenido = new System.Windows.Forms.Label();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCapacidad
            // 
            this.numericUpDownCapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCapacidad.Location = new System.Drawing.Point(113, 545);
            this.numericUpDownCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            this.numericUpDownCapacidad.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownCapacidad.TabIndex = 3;
            this.numericUpDownCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
//            this.numericUpDownCapacidad.ValueChanged += new System.EventHandler(this.numericUpDownCapacidad_ValueChanged);
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownContenido.Location = new System.Drawing.Point(217, 545);
            this.numericUpDownContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContenido.Name = "numericUpDownContenido";
            this.numericUpDownContenido.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownContenido.TabIndex = 5;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
//            this.numericUpDownContenido.ValueChanged += new System.EventHandler(this.numericUpDownContenido_ValueChanged);
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(183, 462);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 6;
            this.Marca.Text = "Marca";
            // 
            // BotellaTipo
            // 
            this.BotellaTipo.AutoSize = true;
            this.BotellaTipo.Location = new System.Drawing.Point(381, 449);
            this.BotellaTipo.Name = "BotellaTipo";
            this.BotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.BotellaTipo.TabIndex = 7;
            this.BotellaTipo.Text = "Botella Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(151, 487);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // comboBoxBotellaTipo
            // 
            this.comboBoxBotellaTipo.FormattingEnabled = true;
            this.comboBoxBotellaTipo.Location = new System.Drawing.Point(352, 487);
            this.comboBoxBotellaTipo.Name = "comboBoxBotellaTipo";
            this.comboBoxBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBotellaTipo.TabIndex = 9;
            // 
            // rdioBtnCerveza
            // 
            this.rdioBtnCerveza.AutoSize = true;
            this.rdioBtnCerveza.Location = new System.Drawing.Point(8, 449);
            this.rdioBtnCerveza.Name = "rdioBtnCerveza";
            this.rdioBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdioBtnCerveza.TabIndex = 10;
            this.rdioBtnCerveza.TabStop = true;
            this.rdioBtnCerveza.Text = "Cerveza";
            this.rdioBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // rdioBtnAgua
            // 
            this.rdioBtnAgua.AutoSize = true;
            this.rdioBtnAgua.Location = new System.Drawing.Point(8, 491);
            this.rdioBtnAgua.Name = "rdioBtnAgua";
            this.rdioBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rdioBtnAgua.TabIndex = 11;
            this.rdioBtnAgua.TabStop = true;
            this.rdioBtnAgua.Text = "Agua";
            this.rdioBtnAgua.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(352, 532);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSize = true;
            this.Capacidad.Location = new System.Drawing.Point(128, 529);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(58, 13);
            this.Capacidad.TabIndex = 13;
            this.Capacidad.Text = "Capacidad";
            // 
            // Contenido
            // 
            this.Contenido.AutoSize = true;
            this.Contenido.Location = new System.Drawing.Point(233, 529);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(55, 13);
            this.Contenido.TabIndex = 14;
            this.Contenido.Text = "Contenido";
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 595);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rdioBtnAgua);
            this.Controls.Add(this.rdioBtnCerveza);
            this.Controls.Add(this.comboBoxBotellaTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.BotellaTipo);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.numericUpDownContenido);
            this.Controls.Add(this.numericUpDownCapacidad);
            this.Controls.Add(this.barra1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rocio Diaz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidad;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label BotellaTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox comboBoxBotellaTipo;
        private System.Windows.Forms.RadioButton rdioBtnCerveza;
        private System.Windows.Forms.RadioButton rdioBtnAgua;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label Capacidad;
        private System.Windows.Forms.Label Contenido;
    }
}

