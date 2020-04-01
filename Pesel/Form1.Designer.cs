namespace Pesel
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
            this.label1 = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.TextBox();
            this.peselWynik = new System.Windows.Forms.Label();
            this.sprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesel:";
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(119, 39);
            this.pesel.MaxLength = 11;
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(178, 20);
            this.pesel.TabIndex = 1;
            // 
            // peselWynik
            // 
            this.peselWynik.AutoSize = true;
            this.peselWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselWynik.ForeColor = System.Drawing.Color.Black;
            this.peselWynik.Location = new System.Drawing.Point(23, 99);
            this.peselWynik.Name = "peselWynik";
            this.peselWynik.Size = new System.Drawing.Size(0, 31);
            this.peselWynik.TabIndex = 2;
            // 
            // sprawdz
            // 
            this.sprawdz.Location = new System.Drawing.Point(303, 39);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(75, 23);
            this.sprawdz.TabIndex = 3;
            this.sprawdz.Text = "Check";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 152);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.peselWynik);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Label peselWynik;
        private System.Windows.Forms.Button sprawdz;
    }
}

