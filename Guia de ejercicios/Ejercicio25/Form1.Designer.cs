namespace Ejercicio25
{
    partial class Conversor
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
            this.lblBinToDec = new System.Windows.Forms.Label();
            this.lblDecToBin = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtDecToBin = new System.Windows.Forms.TextBox();
            this.txtBinToDec = new System.Windows.Forms.TextBox();
            this.btnBicToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinToDec
            // 
            this.lblBinToDec.AutoSize = true;
            this.lblBinToDec.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinToDec.Location = new System.Drawing.Point(12, 46);
            this.lblBinToDec.Name = "lblBinToDec";
            this.lblBinToDec.Size = new System.Drawing.Size(167, 22);
            this.lblBinToDec.TabIndex = 0;
            this.lblBinToDec.Text = "Binario a Decimal";
            this.lblBinToDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecToBin
            // 
            this.lblDecToBin.AutoSize = true;
            this.lblDecToBin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecToBin.Location = new System.Drawing.Point(12, 90);
            this.lblDecToBin.Name = "lblDecToBin";
            this.lblDecToBin.Size = new System.Drawing.Size(167, 22);
            this.lblDecToBin.TabIndex = 1;
            this.lblDecToBin.Text = "Decimal a Binario";
            this.lblDecToBin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(195, 46);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 2;
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(195, 94);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 3;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecToBin
            // 
            this.txtDecToBin.Location = new System.Drawing.Point(404, 94);
            this.txtDecToBin.Name = "txtDecToBin";
            this.txtDecToBin.Size = new System.Drawing.Size(100, 20);
            this.txtDecToBin.TabIndex = 4;
            this.txtDecToBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBinToDec
            // 
            this.txtBinToDec.Location = new System.Drawing.Point(404, 46);
            this.txtBinToDec.Name = "txtBinToDec";
            this.txtBinToDec.Size = new System.Drawing.Size(100, 20);
            this.txtBinToDec.TabIndex = 5;
            this.txtBinToDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBicToDec
            // 
            this.btnBicToDec.Location = new System.Drawing.Point(326, 45);
            this.btnBicToDec.Name = "btnBicToDec";
            this.btnBicToDec.Size = new System.Drawing.Size(53, 23);
            this.btnBicToDec.TabIndex = 6;
            this.btnBicToDec.Text = "-->";
            this.btnBicToDec.UseVisualStyleBackColor = true;
            this.btnBicToDec.Click += new System.EventHandler(this.btnBicToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(326, 92);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(53, 23);
            this.btnDecToBin.TabIndex = 7;
            this.btnDecToBin.Text = "-->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 157);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBicToDec);
            this.Controls.Add(this.txtBinToDec);
            this.Controls.Add(this.txtDecToBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecToBin);
            this.Controls.Add(this.lblBinToDec);
            this.MaximizeBox = false;
            this.Name = "Conversor";
            this.Text = "Conversor binario/decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtDecToBin;
        private System.Windows.Forms.TextBox txtBinToDec;
        private System.Windows.Forms.Button btnBicToDec;
        private System.Windows.Forms.Button btnDecToBin;
    }
}

