﻿namespace VistaForm
{
    partial class FrmTest
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
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(539, 328);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(239, 42);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(27, 328);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(239, 42);
            this.btnVerInforme.TabIndex = 1;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(239, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(6, 169);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.ReadOnly = true;
            this.rtbInforme.Size = new System.Drawing.Size(786, 142);
            this.rtbInforme.TabIndex = 3;
            this.rtbInforme.Text = "";
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(6, 16);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(786, 147);
            this.lstStock.TabIndex = 4;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnVender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testear App de Rocio Diaz(2D)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.ListBox lstStock;
    }
}

