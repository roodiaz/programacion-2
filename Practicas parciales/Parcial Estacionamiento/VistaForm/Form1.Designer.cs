namespace VistaForm
{
    partial class FormPrincipal
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.Patente = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.txtBoxPatente = new System.Windows.Forms.TextBox();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(75, 247);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(194, 73);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Patente
            // 
            this.Patente.AutoSize = true;
            this.Patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patente.Location = new System.Drawing.Point(28, 26);
            this.Patente.Name = "Patente";
            this.Patente.Size = new System.Drawing.Size(95, 29);
            this.Patente.TabIndex = 1;
            this.Patente.Text = "Patente";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.Location = new System.Drawing.Point(28, 131);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(95, 29);
            this.Modelo.TabIndex = 2;
            this.Modelo.Text = "Modelo";
            // 
            // txtBoxPatente
            // 
            this.txtBoxPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatente.Location = new System.Drawing.Point(33, 58);
            this.txtBoxPatente.Multiline = true;
            this.txtBoxPatente.Name = "txtBoxPatente";
            this.txtBoxPatente.Size = new System.Drawing.Size(286, 44);
            this.txtBoxPatente.TabIndex = 3;
            this.txtBoxPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxModelo.Location = new System.Drawing.Point(33, 163);
            this.txtBoxModelo.Multiline = true;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(286, 44);
            this.txtBoxModelo.TabIndex = 4;
            this.txtBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 332);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.txtBoxPatente);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Patente);
            this.Controls.Add(this.btnCrear);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear PickUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label Patente;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.TextBox txtBoxPatente;
        private System.Windows.Forms.TextBox txtBoxModelo;
    }
}

