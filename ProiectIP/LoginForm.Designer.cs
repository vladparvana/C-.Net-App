namespace ProiectIP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelParola = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAutentificare = new System.Windows.Forms.Button();
            this.buttonAcasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelParola.Location = new System.Drawing.Point(63, 157);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(69, 25);
            this.labelParola.TabIndex = 40;
            this.labelParola.Text = "Parola";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelEmail.Location = new System.Drawing.Point(63, 86);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "Email";
            // 
            // textBoxParola
            // 
            this.textBoxParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxParola.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(64, 185);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(324, 27);
            this.textBoxParola.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(64, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 27);
            this.textBoxEmail.TabIndex = 37;
            // 
            // buttonAutentificare
            // 
            this.buttonAutentificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAutentificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutentificare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificare.ForeColor = System.Drawing.Color.White;
            this.buttonAutentificare.Location = new System.Drawing.Point(141, 261);
            this.buttonAutentificare.Name = "buttonAutentificare";
            this.buttonAutentificare.Size = new System.Drawing.Size(179, 39);
            this.buttonAutentificare.TabIndex = 41;
            this.buttonAutentificare.Text = "Autentificare";
            this.buttonAutentificare.UseVisualStyleBackColor = false;
            this.buttonAutentificare.Click += new System.EventHandler(this.buttonAutentificare_Click);
            // 
            // buttonAcasa
            // 
            this.buttonAcasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAcasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcasa.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAcasa.Location = new System.Drawing.Point(141, 327);
            this.buttonAcasa.Name = "buttonAcasa";
            this.buttonAcasa.Size = new System.Drawing.Size(179, 39);
            this.buttonAcasa.TabIndex = 42;
            this.buttonAcasa.Text = "Acasa";
            this.buttonAcasa.UseVisualStyleBackColor = true;
            this.buttonAcasa.Click += new System.EventHandler(this.buttonAcasa_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 425);
            this.Controls.Add(this.buttonAcasa);
            this.Controls.Add(this.buttonAutentificare);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAutentificare;
        private System.Windows.Forms.Button buttonAcasa;
    }
}