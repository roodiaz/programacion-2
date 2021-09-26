
namespace VistaForm
{
    partial class FrmMenu
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
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturacionTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionTotal.ForeColor = System.Drawing.Color.Thistle;
            this.btnFacturacionTotal.Location = new System.Drawing.Point(51, 130);
            this.btnFacturacionTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(339, 91);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = false;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturacionLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionLocal.ForeColor = System.Drawing.Color.Thistle;
            this.btnFacturacionLocal.Location = new System.Drawing.Point(51, 231);
            this.btnFacturacionLocal.Margin = new System.Windows.Forms.Padding(5);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(339, 91);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = false;
            this.btnFacturacionLocal.Click += new System.EventHandler(this.btnFacturacionLocal_Click);
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturacionProvincial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionProvincial.ForeColor = System.Drawing.Color.Thistle;
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(51, 332);
            this.btnFacturacionProvincial.Margin = new System.Windows.Forms.Padding(5);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(339, 91);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = false;
            this.btnFacturacionProvincial.Click += new System.EventHandler(this.btnFacturacionProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Thistle;
            this.btnSalir.Location = new System.Drawing.Point(51, 434);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(339, 91);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerarLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarLlamada.ForeColor = System.Drawing.Color.Thistle;
            this.btnGenerarLlamada.Location = new System.Drawing.Point(51, 29);
            this.btnGenerarLlamada.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(339, 91);
            this.btnGenerarLlamada.TabIndex = 5;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = false;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(437, 557);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMostrar_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarLlamada;
    }
}

