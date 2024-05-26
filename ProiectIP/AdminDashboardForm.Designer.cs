namespace ProiectIP
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUtilizatori = new System.Windows.Forms.Button();
            this.buttonZboruri = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSide.Controls.Add(this.labelWelcome);
            this.panelSide.Controls.Add(this.buttonLogout);
            this.panelSide.Controls.Add(this.buttonUtilizatori);
            this.panelSide.Controls.Add(this.buttonZboruri);
            this.panelSide.Controls.Add(this.labelUserName);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(234, 720);
            this.panelSide.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(26, 660);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(189, 39);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Delogare";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUtilizatori
            // 
            this.buttonUtilizatori.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilizatori.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatori.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatori.Location = new System.Drawing.Point(26, 240);
            this.buttonUtilizatori.Name = "buttonUtilizatori";
            this.buttonUtilizatori.Size = new System.Drawing.Size(189, 39);
            this.buttonUtilizatori.TabIndex = 6;
            this.buttonUtilizatori.Text = "Utilizatori";
            this.buttonUtilizatori.UseVisualStyleBackColor = true;
            this.buttonUtilizatori.Click += new System.EventHandler(this.buttonUtilizatori_Click);
            // 
            // buttonZboruri
            // 
            this.buttonZboruri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonZboruri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZboruri.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZboruri.ForeColor = System.Drawing.Color.White;
            this.buttonZboruri.Location = new System.Drawing.Point(26, 195);
            this.buttonZboruri.Name = "buttonZboruri";
            this.buttonZboruri.Size = new System.Drawing.Size(189, 39);
            this.buttonZboruri.TabIndex = 5;
            this.buttonZboruri.Text = "Zboruri";
            this.buttonZboruri.UseVisualStyleBackColor = true;
            this.buttonZboruri.Click += new System.EventHandler(this.buttonZboruri_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(62, 89);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(101, 25);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "UserName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAction
            // 
            this.panelAction.Location = new System.Drawing.Point(240, 74);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1028, 634);
            this.panelAction.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonClose.Location = new System.Drawing.Point(1230, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 43);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(55, 64);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(122, 25);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Bine ai venit,";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUtilizatori;
        private System.Windows.Forms.Button buttonZboruri;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelWelcome;
    }
}