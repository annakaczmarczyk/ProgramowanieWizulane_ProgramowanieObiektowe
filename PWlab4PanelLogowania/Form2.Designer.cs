namespace PanelLogowania
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Komputerowy";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InfoLabel.Location = new System.Drawing.Point(70, 34);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(260, 24);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Witamy! Wciśnij \'Q\' aby wyjść.";
            // 
            // ImieLabel
            // 
            this.ImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImieLabel.Location = new System.Drawing.Point(12, 71);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(377, 37);
            this.ImieLabel.TabIndex = 2;
            this.ImieLabel.Text = "(Imie)";
            this.ImieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwiskoLabel.Location = new System.Drawing.Point(12, 108);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(377, 37);
            this.NazwiskoLabel.TabIndex = 3;
            this.NazwiskoLabel.Text = "(Nazwisko)";
            this.NazwiskoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NazwiskoLabel.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.NazwiskoLabel.MouseHover += new System.EventHandler(this.Label_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PanelLogowania.Properties.Resources.ComputerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(146, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 253);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 341);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Lab4 - Witamy!";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoLabel;
        public System.Windows.Forms.Label ImieLabel;
        public System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}