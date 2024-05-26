namespace ProiectIP
{
    partial class AdminFlightsForm
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
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.buttonAdaugaZbor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.GridColor = System.Drawing.Color.White;
            this.dataGridViewFlights.Location = new System.Drawing.Point(25, 76);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 51;
            this.dataGridViewFlights.RowTemplate.Height = 24;
            this.dataGridViewFlights.Size = new System.Drawing.Size(970, 534);
            this.dataGridViewFlights.TabIndex = 0;
            // 
            // buttonAdaugaZbor
            // 
            this.buttonAdaugaZbor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAdaugaZbor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaZbor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaZbor.ForeColor = System.Drawing.Color.White;
            this.buttonAdaugaZbor.Location = new System.Drawing.Point(25, 14);
            this.buttonAdaugaZbor.Name = "buttonAdaugaZbor";
            this.buttonAdaugaZbor.Size = new System.Drawing.Size(179, 39);
            this.buttonAdaugaZbor.TabIndex = 6;
            this.buttonAdaugaZbor.Text = "Adauga zbor";
            this.buttonAdaugaZbor.UseVisualStyleBackColor = false;
            this.buttonAdaugaZbor.Click += new System.EventHandler(this.buttonAdaugaZbor_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 634);
            this.Controls.Add(this.buttonAdaugaZbor);
            this.Controls.Add(this.dataGridViewFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.Button buttonAdaugaZbor;
    }
}