namespace Fahrenheit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.rdbCelsiusparaf = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheitparac = new System.Windows.Forms.RadioButton();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.rdbCelsiusparak = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheitparak = new System.Windows.Forms.RadioButton();
            this.rdbKelvinparac = new System.Windows.Forms.RadioButton();
            this.rdbKelvinparaF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(36, 26);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 2;
            this.txtCelsius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelsius_KeyDown);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(46, 262);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 13;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(12, 29);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(18, 13);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "Cº";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(13, 52);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(17, 13);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Fº";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(36, 52);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 4;
            this.txtFahrenheit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFahrenheit_KeyDown);
            // 
            // rdbCelsiusparaf
            // 
            this.rdbCelsiusparaf.AutoSize = true;
            this.rdbCelsiusparaf.Checked = true;
            this.rdbCelsiusparaf.Location = new System.Drawing.Point(16, 104);
            this.rdbCelsiusparaf.Name = "rdbCelsiusparaf";
            this.rdbCelsiusparaf.Size = new System.Drawing.Size(135, 17);
            this.rdbCelsiusparaf.TabIndex = 7;
            this.rdbCelsiusparaf.TabStop = true;
            this.rdbCelsiusparaf.Text = "Celsius para Fahrenheit";
            this.rdbCelsiusparaf.UseVisualStyleBackColor = true;
            // 
            // rdbFahrenheitparac
            // 
            this.rdbFahrenheitparac.AutoSize = true;
            this.rdbFahrenheitparac.Location = new System.Drawing.Point(16, 150);
            this.rdbFahrenheitparac.Name = "rdbFahrenheitparac";
            this.rdbFahrenheitparac.Size = new System.Drawing.Size(135, 17);
            this.rdbFahrenheitparac.TabIndex = 9;
            this.rdbFahrenheitparac.Text = "Fahrenheit para Celsius";
            this.rdbFahrenheitparac.UseVisualStyleBackColor = true;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(36, 81);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 6;
            this.txtKelvin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKelvin_KeyDown);
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(12, 81);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(18, 13);
            this.lblKelvin.TabIndex = 5;
            this.lblKelvin.Text = "Kº";
            // 
            // rdbCelsiusparak
            // 
            this.rdbCelsiusparak.AutoSize = true;
            this.rdbCelsiusparak.Location = new System.Drawing.Point(16, 127);
            this.rdbCelsiusparak.Name = "rdbCelsiusparak";
            this.rdbCelsiusparak.Size = new System.Drawing.Size(114, 17);
            this.rdbCelsiusparak.TabIndex = 8;
            this.rdbCelsiusparak.Text = "Celsius para Kelvin";
            this.rdbCelsiusparak.UseVisualStyleBackColor = true;
            // 
            // rdbFahrenheitparak
            // 
            this.rdbFahrenheitparak.AutoSize = true;
            this.rdbFahrenheitparak.Location = new System.Drawing.Point(16, 173);
            this.rdbFahrenheitparak.Name = "rdbFahrenheitparak";
            this.rdbFahrenheitparak.Size = new System.Drawing.Size(131, 17);
            this.rdbFahrenheitparak.TabIndex = 10;
            this.rdbFahrenheitparak.Text = "Fahrenheit para Kelvin";
            this.rdbFahrenheitparak.UseVisualStyleBackColor = true;
            // 
            // rdbKelvinparac
            // 
            this.rdbKelvinparac.AutoSize = true;
            this.rdbKelvinparac.Location = new System.Drawing.Point(16, 196);
            this.rdbKelvinparac.Name = "rdbKelvinparac";
            this.rdbKelvinparac.Size = new System.Drawing.Size(114, 17);
            this.rdbKelvinparac.TabIndex = 11;
            this.rdbKelvinparac.Text = "Kelvin para Celsius";
            this.rdbKelvinparac.UseVisualStyleBackColor = true;
            // 
            // rdbKelvinparaF
            // 
            this.rdbKelvinparaF.AutoSize = true;
            this.rdbKelvinparaF.Location = new System.Drawing.Point(16, 219);
            this.rdbKelvinparaF.Name = "rdbKelvinparaF";
            this.rdbKelvinparaF.Size = new System.Drawing.Size(134, 17);
            this.rdbKelvinparaF.TabIndex = 12;
            this.rdbKelvinparaF.Text = "Kelvin para Fahrenheit ";
            this.rdbKelvinparaF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 329);
            this.Controls.Add(this.rdbKelvinparaF);
            this.Controls.Add(this.rdbKelvinparac);
            this.Controls.Add(this.rdbFahrenheitparak);
            this.Controls.Add(this.rdbCelsiusparak);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.rdbFahrenheitparac);
            this.Controls.Add(this.rdbCelsiusparaf);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "c";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.RadioButton rdbCelsiusparaf;
        private System.Windows.Forms.RadioButton rdbFahrenheitparac;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.RadioButton rdbCelsiusparak;
        private System.Windows.Forms.RadioButton rdbFahrenheitparak;
        private System.Windows.Forms.RadioButton rdbKelvinparac;
        private System.Windows.Forms.RadioButton rdbKelvinparaF;
    }
}

