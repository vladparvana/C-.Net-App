namespace ProiectIP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAutentificare = new System.Windows.Forms.Button();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelAction = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSide.Controls.Add(this.labelCredits);
            this.panelSide.Controls.Add(this.labelTitle);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(234, 545);
            this.panelSide.TabIndex = 0;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCredits.Location = new System.Drawing.Point(37, 476);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(149, 21);
            this.labelCredits.TabIndex = 1;
            this.labelCredits.Text = "© Proiect IP - 2024";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(71, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(91, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tarom";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonClose.Location = new System.Drawing.Point(705, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 43);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAutentificare
            // 
            this.buttonAutentificare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAutentificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutentificare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAutentificare.Location = new System.Drawing.Point(30, 220);
            this.buttonAutentificare.Name = "buttonAutentificare";
            this.buttonAutentificare.Size = new System.Drawing.Size(189, 39);
            this.buttonAutentificare.TabIndex = 4;
            this.buttonAutentificare.Text = "Auntetificare";
            this.buttonAutentificare.UseVisualStyleBackColor = true;
            this.buttonAutentificare.Click += new System.EventHandler(this.buttonAutentificare_Click_1);
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInregistrare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.ForeColor = System.Drawing.Color.White;
            this.buttonInregistrare.Location = new System.Drawing.Point(290, 220);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(179, 39);
            this.buttonInregistrare.TabIndex = 5;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click_1);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelWelcome.Location = new System.Drawing.Point(158, 62);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(180, 36);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Bine ati venit!";
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.buttonInregistrare);
            this.panelAction.Controls.Add(this.buttonAutentificare);
            this.panelAction.Controls.Add(this.labelWelcome);
            this.panelAction.Location = new System.Drawing.Point(240, 61);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(502, 472);
            this.panelAction.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu principal";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAutentificare;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Panel panelAction;
    }
}

