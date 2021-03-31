namespace Ejercicio24
{
    partial class ConversorGrados
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
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusToKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusToCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinToCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinToKelvin = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.ConvertCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(12, 37);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(108, 22);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Fahrenheit";
            this.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrenheit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(12, 83);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(69, 22);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "Celsius";
            this.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Celsius";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(12, 131);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(64, 22);
            this.lblKelvin.TabIndex = 4;
            this.lblKelvin.Text = "Kelvin";
            this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelvin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(153, 39);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 6;
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(153, 135);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 7;
            this.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(153, 87);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 8;
            this.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitToCelsius
            // 
            this.txtFahrenheitToCelsius.Location = new System.Drawing.Point(530, 41);
            this.txtFahrenheitToCelsius.Name = "txtFahrenheitToCelsius";
            this.txtFahrenheitToCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitToCelsius.TabIndex = 9;
            this.txtFahrenheitToCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitToFahrenheit
            // 
            this.txtFahrenheitToFahrenheit.Location = new System.Drawing.Point(381, 41);
            this.txtFahrenheitToFahrenheit.Name = "txtFahrenheitToFahrenheit";
            this.txtFahrenheitToFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitToFahrenheit.TabIndex = 10;
            this.txtFahrenheitToFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitToKelvin
            // 
            this.txtFahrenheitToKelvin.Location = new System.Drawing.Point(670, 39);
            this.txtFahrenheitToKelvin.Name = "txtFahrenheitToKelvin";
            this.txtFahrenheitToKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitToKelvin.TabIndex = 11;
            this.txtFahrenheitToKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusToFahrenheit
            // 
            this.txtCelsiusToFahrenheit.Location = new System.Drawing.Point(381, 87);
            this.txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit";
            this.txtCelsiusToFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusToFahrenheit.TabIndex = 12;
            this.txtCelsiusToFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusToKelvin
            // 
            this.txtCelsiusToKelvin.Location = new System.Drawing.Point(670, 87);
            this.txtCelsiusToKelvin.Name = "txtCelsiusToKelvin";
            this.txtCelsiusToKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusToKelvin.TabIndex = 13;
            this.txtCelsiusToKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusToCelsius
            // 
            this.txtCelsiusToCelsius.Location = new System.Drawing.Point(530, 87);
            this.txtCelsiusToCelsius.Name = "txtCelsiusToCelsius";
            this.txtCelsiusToCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusToCelsius.TabIndex = 14;
            this.txtCelsiusToCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinToFahrenheit
            // 
            this.txtKelvinToFahrenheit.Location = new System.Drawing.Point(381, 135);
            this.txtKelvinToFahrenheit.Name = "txtKelvinToFahrenheit";
            this.txtKelvinToFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinToFahrenheit.TabIndex = 15;
            this.txtKelvinToFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinToCelsius
            // 
            this.txtKelvinToCelsius.Location = new System.Drawing.Point(530, 135);
            this.txtKelvinToCelsius.Name = "txtKelvinToCelsius";
            this.txtKelvinToCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinToCelsius.TabIndex = 16;
            this.txtKelvinToCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinToKelvin
            // 
            this.txtKelvinToKelvin.Location = new System.Drawing.Point(670, 136);
            this.txtKelvinToKelvin.Name = "txtKelvinToKelvin";
            this.txtKelvinToKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinToKelvin.TabIndex = 17;
            this.txtKelvinToKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertFahrenheit
            // 
            this.btnConvertFahrenheit.Location = new System.Drawing.Point(286, 38);
            this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            this.btnConvertFahrenheit.Size = new System.Drawing.Size(62, 23);
            this.btnConvertFahrenheit.TabIndex = 18;
            this.btnConvertFahrenheit.Text = "-->";
            this.btnConvertFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheit.Click += new System.EventHandler(this.btnConvertFahrenheit_Click);
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Location = new System.Drawing.Point(286, 133);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(62, 23);
            this.btnConvertKelvin.TabIndex = 19;
            this.btnConvertKelvin.Text = "-->";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // ConvertCelsius
            // 
            this.ConvertCelsius.Location = new System.Drawing.Point(286, 85);
            this.ConvertCelsius.Name = "ConvertCelsius";
            this.ConvertCelsius.Size = new System.Drawing.Size(62, 23);
            this.ConvertCelsius.TabIndex = 20;
            this.ConvertCelsius.Text = "-->";
            this.ConvertCelsius.UseVisualStyleBackColor = true;
            this.ConvertCelsius.Click += new System.EventHandler(this.ConvertCelsius_Click);
            // 
            // ConversorGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 176);
            this.Controls.Add(this.ConvertCelsius);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.btnConvertFahrenheit);
            this.Controls.Add(this.txtKelvinToKelvin);
            this.Controls.Add(this.txtKelvinToCelsius);
            this.Controls.Add(this.txtKelvinToFahrenheit);
            this.Controls.Add(this.txtCelsiusToCelsius);
            this.Controls.Add(this.txtCelsiusToKelvin);
            this.Controls.Add(this.txtCelsiusToFahrenheit);
            this.Controls.Add(this.txtFahrenheitToKelvin);
            this.Controls.Add(this.txtFahrenheitToFahrenheit);
            this.Controls.Add(this.txtFahrenheitToCelsius);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFahrenheit);
            this.MinimizeBox = false;
            this.Name = "ConversorGrados";
            this.Text = "Conversor Grados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheitToCelsius;
        private System.Windows.Forms.TextBox txtFahrenheitToFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitToKelvin;
        private System.Windows.Forms.TextBox txtCelsiusToFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusToKelvin;
        private System.Windows.Forms.TextBox txtCelsiusToCelsius;
        private System.Windows.Forms.TextBox txtKelvinToFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinToCelsius;
        private System.Windows.Forms.TextBox txtKelvinToKelvin;
        private System.Windows.Forms.Button btnConvertFahrenheit;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.Button ConvertCelsius;
    }
}

