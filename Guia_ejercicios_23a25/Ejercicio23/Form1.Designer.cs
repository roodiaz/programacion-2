namespace Ejercicio23
{
    partial class FormMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonedas));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblPesosA = new System.Windows.Forms.Label();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPesos = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(43, 32);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(119, 31);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(369, 78);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(69, 31);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(265, 78);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(61, 31);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Euro";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(475, 78);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(71, 31);
            this.lblPesos.TabIndex = 3;
            this.lblPesos.Text = "Pesos";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(1, 170);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(69, 31);
            this.lblDolarA.TabIndex = 4;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(7, 123);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(61, 31);
            this.lblEuroA.TabIndex = 5;
            this.lblEuroA.Text = "Euro";
            // 
            // lblPesosA
            // 
            this.lblPesosA.AutoSize = true;
            this.lblPesosA.Font = new System.Drawing.Font("Calibri", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesosA.Location = new System.Drawing.Point(-2, 220);
            this.lblPesosA.Name = "lblPesosA";
            this.lblPesosA.Size = new System.Drawing.Size(71, 31);
            this.lblPesosA.TabIndex = 6;
            this.lblPesosA.Text = "Pesos";
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertEuro.Location = new System.Drawing.Point(173, 123);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(65, 25);
            this.btnConvertEuro.TabIndex = 7;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDolar.Location = new System.Drawing.Point(173, 173);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(65, 25);
            this.btnConvertDolar.TabIndex = 8;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertPesos.Location = new System.Drawing.Point(173, 220);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(65, 25);
            this.btnConvertPesos.TabIndex = 9;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionEuro.Location = new System.Drawing.Point(257, 32);
            this.txtCotizacionEuro.Multiline = true;
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(80, 25);
            this.txtCotizacionEuro.TabIndex = 10;
            this.txtCotizacionEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionDolar.Location = new System.Drawing.Point(364, 32);
            this.txtCotizacionDolar.Multiline = true;
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(80, 25);
            this.txtCotizacionDolar.TabIndex = 11;
            this.txtCotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionPesos
            // 
            this.txtCotizacionPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionPesos.Location = new System.Drawing.Point(467, 32);
            this.txtCotizacionPesos.Multiline = true;
            this.txtCotizacionPesos.Name = "txtCotizacionPesos";
            this.txtCotizacionPesos.Size = new System.Drawing.Size(80, 25);
            this.txtCotizacionPesos.TabIndex = 12;
            this.txtCotizacionPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(76, 123);
            this.txtEuro.Multiline = true;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(80, 25);
            this.txtEuro.TabIndex = 13;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(76, 173);
            this.txtDolar.Multiline = true;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(80, 25);
            this.txtDolar.TabIndex = 14;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesos
            // 
            this.txtPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesos.Location = new System.Drawing.Point(76, 220);
            this.txtPesos.Multiline = true;
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(80, 25);
            this.txtPesos.TabIndex = 15;
            this.txtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAEuro.Location = new System.Drawing.Point(257, 123);
            this.txtEuroAEuro.Multiline = true;
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(80, 25);
            this.txtEuroAEuro.TabIndex = 16;
            this.txtEuroAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroADolar.Location = new System.Drawing.Point(364, 123);
            this.txtEuroADolar.Multiline = true;
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(80, 25);
            this.txtEuroADolar.TabIndex = 17;
            this.txtEuroADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAPesos.Location = new System.Drawing.Point(467, 123);
            this.txtEuroAPesos.Multiline = true;
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(80, 25);
            this.txtEuroAPesos.TabIndex = 18;
            this.txtEuroAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAEuro.Location = new System.Drawing.Point(257, 173);
            this.txtDolarAEuro.Multiline = true;
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(80, 25);
            this.txtDolarAEuro.TabIndex = 19;
            this.txtDolarAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarADolar.Location = new System.Drawing.Point(364, 176);
            this.txtDolarADolar.Multiline = true;
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(80, 25);
            this.txtDolarADolar.TabIndex = 20;
            this.txtDolarADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAPesos.Location = new System.Drawing.Point(467, 176);
            this.txtDolarAPesos.Multiline = true;
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(80, 25);
            this.txtDolarAPesos.TabIndex = 21;
            this.txtDolarAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesosAEuro.Location = new System.Drawing.Point(257, 220);
            this.txtPesosAEuro.Multiline = true;
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(80, 25);
            this.txtPesosAEuro.TabIndex = 22;
            this.txtPesosAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesosADolar.Location = new System.Drawing.Point(364, 220);
            this.txtPesosADolar.Multiline = true;
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(80, 25);
            this.txtPesosADolar.TabIndex = 23;
            this.txtPesosADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesosAPesos.Location = new System.Drawing.Point(467, 223);
            this.txtPesosAPesos.Multiline = true;
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(80, 25);
            this.txtPesosAPesos.TabIndex = 24;
            this.txtPesosAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "desbloqueado.png");
            this.imageList1.Images.SetKeyName(1, "bloqueado.png");
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLockCotizacion.Image")));
            this.btnLockCotizacion.Location = new System.Drawing.Point(173, 29);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(65, 36);
            this.btnLockCotizacion.TabIndex = 25;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // FormMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(585, 264);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtCotizacionPesos);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.lblPesosA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblCotizacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblPesosA;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLockCotizacion;
    }
}

