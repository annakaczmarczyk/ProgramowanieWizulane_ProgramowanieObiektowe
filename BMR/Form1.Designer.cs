namespace BMR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Płeć = new System.Windows.Forms.Label();
            this.masa = new System.Windows.Forms.Label();
            this.Wzrost = new System.Windows.Forms.Label();
            this.Wiek = new System.Windows.Forms.Label();
            this.WartoscMasy = new System.Windows.Forms.TextBox();
            this.WartoscWzrostu = new System.Windows.Forms.TextBox();
            this.WartoscWieku = new System.Windows.Forms.TextBox();
            this.MezczyznaWartosc = new System.Windows.Forms.RadioButton();
            this.KobietaWartosc = new System.Windows.Forms.RadioButton();
            this.BMI = new System.Windows.Forms.Button();
            this.wynikBMI = new System.Windows.Forms.Label();
            this.Errors = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Płeć
            // 
            this.Płeć.AutoSize = true;
            this.Płeć.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Płeć.Location = new System.Drawing.Point(12, 9);
            this.Płeć.Name = "Płeć";
            this.Płeć.Size = new System.Drawing.Size(75, 31);
            this.Płeć.TabIndex = 0;
            this.Płeć.Text = "Płeć:";
            // 
            // masa
            // 
            this.masa.AutoSize = true;
            this.masa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masa.Location = new System.Drawing.Point(113, 9);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(88, 31);
            this.masa.TabIndex = 1;
            this.masa.Text = "Masa:";
            // 
            // Wzrost
            // 
            this.Wzrost.AutoSize = true;
            this.Wzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wzrost.Location = new System.Drawing.Point(265, 9);
            this.Wzrost.Name = "Wzrost";
            this.Wzrost.Size = new System.Drawing.Size(107, 31);
            this.Wzrost.TabIndex = 2;
            this.Wzrost.Text = "Wzrost:";
            // 
            // Wiek
            // 
            this.Wiek.AutoSize = true;
            this.Wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wiek.Location = new System.Drawing.Point(412, 9);
            this.Wiek.Name = "Wiek";
            this.Wiek.Size = new System.Drawing.Size(74, 31);
            this.Wiek.TabIndex = 3;
            this.Wiek.Text = "Wiek";
            // 
            // WartoscMasy
            // 
            this.WartoscMasy.Location = new System.Drawing.Point(119, 53);
            this.WartoscMasy.Name = "WartoscMasy";
            this.WartoscMasy.Size = new System.Drawing.Size(100, 20);
            this.WartoscMasy.TabIndex = 4;
            // 
            // WartoscWzrostu
            // 
            this.WartoscWzrostu.Location = new System.Drawing.Point(271, 52);
            this.WartoscWzrostu.Name = "WartoscWzrostu";
            this.WartoscWzrostu.Size = new System.Drawing.Size(100, 20);
            this.WartoscWzrostu.TabIndex = 5;
            // 
            // WartoscWieku
            // 
            this.WartoscWieku.Location = new System.Drawing.Point(418, 52);
            this.WartoscWieku.Name = "WartoscWieku";
            this.WartoscWieku.Size = new System.Drawing.Size(100, 20);
            this.WartoscWieku.TabIndex = 6;
            // 
            // MezczyznaWartosc
            // 
            this.MezczyznaWartosc.AutoSize = true;
            this.MezczyznaWartosc.Location = new System.Drawing.Point(18, 44);
            this.MezczyznaWartosc.Name = "MezczyznaWartosc";
            this.MezczyznaWartosc.Size = new System.Drawing.Size(78, 17);
            this.MezczyznaWartosc.TabIndex = 7;
            this.MezczyznaWartosc.TabStop = true;
            this.MezczyznaWartosc.Text = "Mężczyźna";
            this.MezczyznaWartosc.UseVisualStyleBackColor = true;
            this.MezczyznaWartosc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // KobietaWartosc
            // 
            this.KobietaWartosc.AutoSize = true;
            this.KobietaWartosc.Location = new System.Drawing.Point(18, 67);
            this.KobietaWartosc.Name = "KobietaWartosc";
            this.KobietaWartosc.Size = new System.Drawing.Size(61, 17);
            this.KobietaWartosc.TabIndex = 8;
            this.KobietaWartosc.TabStop = true;
            this.KobietaWartosc.Text = "Kobieta";
            this.KobietaWartosc.UseVisualStyleBackColor = true;
            // 
            // BMI
            // 
            this.BMI.Location = new System.Drawing.Point(21, 193);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(75, 23);
            this.BMI.TabIndex = 12;
            this.BMI.Text = "Oblicz";
            this.BMI.UseVisualStyleBackColor = true;
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // wynikBMI
            // 
            this.wynikBMI.AutoSize = true;
            this.wynikBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikBMI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wynikBMI.Location = new System.Drawing.Point(-3, 116);
            this.wynikBMI.Name = "wynikBMI";
            this.wynikBMI.Size = new System.Drawing.Size(120, 46);
            this.wynikBMI.TabIndex = 13;
            this.wynikBMI.Text = "BMR:";
            // 
            // Errors
            // 
            this.Errors.AutoSize = true;
            this.Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Errors.ForeColor = System.Drawing.Color.Red;
            this.Errors.Location = new System.Drawing.Point(398, 270);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(0, 63);
            this.Errors.TabIndex = 15;
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.Color.Black;
            this.wynik.Location = new System.Drawing.Point(113, 116);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(42, 46);
            this.wynik.TabIndex = 16;
            this.wynik.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 259);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.wynikBMI);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.KobietaWartosc);
            this.Controls.Add(this.MezczyznaWartosc);
            this.Controls.Add(this.WartoscWieku);
            this.Controls.Add(this.WartoscWzrostu);
            this.Controls.Add(this.WartoscMasy);
            this.Controls.Add(this.Wiek);
            this.Controls.Add(this.Wzrost);
            this.Controls.Add(this.masa);
            this.Controls.Add(this.Płeć);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Płeć;
        private System.Windows.Forms.Label masa;
        private System.Windows.Forms.Label Wzrost;
        private System.Windows.Forms.Label Wiek;
        private System.Windows.Forms.TextBox WartoscMasy;
        private System.Windows.Forms.TextBox WartoscWzrostu;
        private System.Windows.Forms.TextBox WartoscWieku;
        private System.Windows.Forms.RadioButton MezczyznaWartosc;
        private System.Windows.Forms.RadioButton KobietaWartosc;
        private System.Windows.Forms.Button BMI;
        private System.Windows.Forms.Label wynikBMI;
        private System.Windows.Forms.Label Errors;
        private System.Windows.Forms.Label wynik;
    }
}

