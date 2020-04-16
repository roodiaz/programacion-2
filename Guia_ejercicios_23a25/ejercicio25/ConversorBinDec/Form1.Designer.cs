namespace ConversorBinDec
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
            this.lblConvertBin = new System.Windows.Forms.Label();
            this.lblConvertDec = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtConversionDec = new System.Windows.Forms.TextBox();
            this.txtConversionBin = new System.Windows.Forms.TextBox();
            this.btnConvertToDec = new System.Windows.Forms.Button();
            this.btnConvertToBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConvertBin
            // 
            this.lblConvertBin.AutoSize = true;
            this.lblConvertBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertBin.Location = new System.Drawing.Point(21, 30);
            this.lblConvertBin.Name = "lblConvertBin";
            this.lblConvertBin.Size = new System.Drawing.Size(162, 24);
            this.lblConvertBin.TabIndex = 0;
            this.lblConvertBin.Text = "Convertir a binario";
            // 
            // lblConvertDec
            // 
            this.lblConvertDec.AutoSize = true;
            this.lblConvertDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertDec.Location = new System.Drawing.Point(21, 70);
            this.lblConvertDec.Name = "lblConvertDec";
            this.lblConvertDec.Size = new System.Drawing.Size(171, 24);
            this.lblConvertDec.TabIndex = 1;
            this.lblConvertDec.Text = "Convertir a decimal";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(206, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(119, 27);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(206, 74);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(119, 27);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConversionDec
            // 
            this.txtConversionDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversionDec.Location = new System.Drawing.Point(441, 34);
            this.txtConversionDec.Name = "txtConversionDec";
            this.txtConversionDec.Size = new System.Drawing.Size(118, 27);
            this.txtConversionDec.TabIndex = 4;
            this.txtConversionDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConversionBin
            // 
            this.txtConversionBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversionBin.Location = new System.Drawing.Point(441, 74);
            this.txtConversionBin.Name = "txtConversionBin";
            this.txtConversionBin.Size = new System.Drawing.Size(118, 27);
            this.txtConversionBin.TabIndex = 5;
            this.txtConversionBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertToDec
            // 
            this.btnConvertToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToDec.Location = new System.Drawing.Point(348, 34);
            this.btnConvertToDec.Name = "btnConvertToDec";
            this.btnConvertToDec.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToDec.TabIndex = 6;
            this.btnConvertToDec.Text = "->";
            this.btnConvertToDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertToDec.UseVisualStyleBackColor = true;
            this.btnConvertToDec.Click += new System.EventHandler(this.btnConvertToDec_Click);
            // 
            // btnConvertToBin
            // 
            this.btnConvertToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToBin.Location = new System.Drawing.Point(348, 78);
            this.btnConvertToBin.Name = "btnConvertToBin";
            this.btnConvertToBin.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToBin.TabIndex = 7;
            this.btnConvertToBin.Text = "->";
            this.btnConvertToBin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertToBin.UseVisualStyleBackColor = true;
            this.btnConvertToBin.Click += new System.EventHandler(this.btnConvertToBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 120);
            this.Controls.Add(this.btnConvertToBin);
            this.Controls.Add(this.btnConvertToDec);
            this.Controls.Add(this.txtConversionBin);
            this.Controls.Add(this.txtConversionDec);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblConvertDec);
            this.Controls.Add(this.lblConvertBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Conversor numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertBin;
        private System.Windows.Forms.Label lblConvertDec;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtConversionDec;
        private System.Windows.Forms.TextBox txtConversionBin;
        private System.Windows.Forms.Button btnConvertToDec;
        private System.Windows.Forms.Button btnConvertToBin;
    }
}

