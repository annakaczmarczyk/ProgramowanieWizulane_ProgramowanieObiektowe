namespace PanelLogowania
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uzytkownikTextBox = new System.Windows.Forms.TextBox();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.loginButton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // uzytkownikTextBox
            // 
            this.uzytkownikTextBox.Location = new System.Drawing.Point(83, 58);
            this.uzytkownikTextBox.Name = "uzytkownikTextBox";
            this.uzytkownikTextBox.Size = new System.Drawing.Size(189, 20);
            this.uzytkownikTextBox.TabIndex = 2;
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Location = new System.Drawing.Point(83, 93);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.PasswordChar = '*';
            this.hasloTextBox.Size = new System.Drawing.Size(189, 20);
            this.hasloTextBox.TabIndex = 3;
            // 
            // loginButton1
            // 
            this.loginButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginButton1.Location = new System.Drawing.Point(83, 144);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(189, 23);
            this.loginButton1.TabIndex = 4;
            this.loginButton1.Text = "Zaloguj (wariant prosty)";
            this.loginButton1.UseVisualStyleBackColor = false;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(89, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Panel Logowania";
            // 
            // loginButton2
            // 
            this.loginButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginButton2.Location = new System.Drawing.Point(83, 173);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(189, 23);
            this.loginButton2.TabIndex = 6;
            this.loginButton2.Text = "Zaloguj (wariant trudniejszy)";
            this.loginButton2.UseVisualStyleBackColor = false;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PanelLogowania.Properties.Resources.UserIcon;
            this.pictureBox1.Location = new System.Drawing.Point(101, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 256);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 376);
            this.Controls.Add(this.loginButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(this.uzytkownikTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab4 - Panel logowania";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uzytkownikTextBox;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.Button loginButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

