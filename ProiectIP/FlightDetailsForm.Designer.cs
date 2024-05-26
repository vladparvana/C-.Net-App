namespace ProiectIP
{
    partial class FlightDetailsForm
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
            this.labelDistanta = new System.Windows.Forms.Label();
            this.labelDurataEstimata = new System.Windows.Forms.Label();
            this.textBoxDistanta = new System.Windows.Forms.TextBox();
            this.textBoxDurataEstimata = new System.Windows.Forms.TextBox();
            this.labelDataPlecarii = new System.Windows.Forms.Label();
            this.labelPretBilet = new System.Windows.Forms.Label();
            this.labelLocuriDisponibile = new System.Windows.Forms.Label();
            this.labelOrasDestinatie = new System.Windows.Forms.Label();
            this.labelOrasPlecare = new System.Windows.Forms.Label();
            this.dateTimePickerDataPlecarii = new System.Windows.Forms.DateTimePicker();
            this.textBoxPretBilet = new System.Windows.Forms.TextBox();
            this.textBoxOrasDestinatie = new System.Windows.Forms.TextBox();
            this.textBoxOrasPlecare = new System.Windows.Forms.TextBox();
            this.textBoxLocuriDisponibile = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonStergeZbor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistanta
            // 
            this.labelDistanta.AutoSize = true;
            this.labelDistanta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelDistanta.Location = new System.Drawing.Point(401, 93);
            this.labelDistanta.Name = "labelDistanta";
            this.labelDistanta.Size = new System.Drawing.Size(84, 25);
            this.labelDistanta.TabIndex = 72;
            this.labelDistanta.Text = "Distanta";
            // 
            // labelDurataEstimata
            // 
            this.labelDurataEstimata.AutoSize = true;
            this.labelDurataEstimata.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurataEstimata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelDurataEstimata.Location = new System.Drawing.Point(229, 93);
            this.labelDurataEstimata.Name = "labelDurataEstimata";
            this.labelDurataEstimata.Size = new System.Drawing.Size(151, 25);
            this.labelDurataEstimata.TabIndex = 71;
            this.labelDurataEstimata.Text = "Durata estimata";
            // 
            // textBoxDistanta
            // 
            this.textBoxDistanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDistanta.Enabled = false;
            this.textBoxDistanta.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistanta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDistanta.Location = new System.Drawing.Point(400, 130);
            this.textBoxDistanta.Name = "textBoxDistanta";
            this.textBoxDistanta.Size = new System.Drawing.Size(154, 27);
            this.textBoxDistanta.TabIndex = 61;
            // 
            // textBoxDurataEstimata
            // 
            this.textBoxDurataEstimata.BackColor = System.Drawing.Color.White;
            this.textBoxDurataEstimata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDurataEstimata.Enabled = false;
            this.textBoxDurataEstimata.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurataEstimata.Location = new System.Drawing.Point(230, 130);
            this.textBoxDurataEstimata.Name = "textBoxDurataEstimata";
            this.textBoxDurataEstimata.Size = new System.Drawing.Size(154, 27);
            this.textBoxDurataEstimata.TabIndex = 60;
            // 
            // labelDataPlecarii
            // 
            this.labelDataPlecarii.AutoSize = true;
            this.labelDataPlecarii.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataPlecarii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelDataPlecarii.Location = new System.Drawing.Point(229, 232);
            this.labelDataPlecarii.Name = "labelDataPlecarii";
            this.labelDataPlecarii.Size = new System.Drawing.Size(121, 25);
            this.labelDataPlecarii.TabIndex = 70;
            this.labelDataPlecarii.Text = "Data plecarii";
            // 
            // labelPretBilet
            // 
            this.labelPretBilet.AutoSize = true;
            this.labelPretBilet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPretBilet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelPretBilet.Location = new System.Drawing.Point(395, 160);
            this.labelPretBilet.Name = "labelPretBilet";
            this.labelPretBilet.Size = new System.Drawing.Size(89, 25);
            this.labelPretBilet.TabIndex = 69;
            this.labelPretBilet.Text = "Pret bilet";
            // 
            // labelLocuriDisponibile
            // 
            this.labelLocuriDisponibile.AutoSize = true;
            this.labelLocuriDisponibile.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocuriDisponibile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelLocuriDisponibile.Location = new System.Drawing.Point(229, 160);
            this.labelLocuriDisponibile.Name = "labelLocuriDisponibile";
            this.labelLocuriDisponibile.Size = new System.Drawing.Size(164, 25);
            this.labelLocuriDisponibile.TabIndex = 68;
            this.labelLocuriDisponibile.Text = "Locuri disponibile";
            // 
            // labelOrasDestinatie
            // 
            this.labelOrasDestinatie.AutoSize = true;
            this.labelOrasDestinatie.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrasDestinatie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelOrasDestinatie.Location = new System.Drawing.Point(395, 31);
            this.labelOrasDestinatie.Name = "labelOrasDestinatie";
            this.labelOrasDestinatie.Size = new System.Drawing.Size(141, 25);
            this.labelOrasDestinatie.TabIndex = 67;
            this.labelOrasDestinatie.Text = "Oras destinatie";
            // 
            // labelOrasPlecare
            // 
            this.labelOrasPlecare.AutoSize = true;
            this.labelOrasPlecare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrasPlecare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelOrasPlecare.Location = new System.Drawing.Point(229, 31);
            this.labelOrasPlecare.Name = "labelOrasPlecare";
            this.labelOrasPlecare.Size = new System.Drawing.Size(120, 25);
            this.labelOrasPlecare.TabIndex = 66;
            this.labelOrasPlecare.Text = "Oras plecare";
            // 
            // dateTimePickerDataPlecarii
            // 
            this.dateTimePickerDataPlecarii.Enabled = false;
            this.dateTimePickerDataPlecarii.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataPlecarii.Location = new System.Drawing.Point(230, 260);
            this.dateTimePickerDataPlecarii.Name = "dateTimePickerDataPlecarii";
            this.dateTimePickerDataPlecarii.Size = new System.Drawing.Size(324, 27);
            this.dateTimePickerDataPlecarii.TabIndex = 64;
            // 
            // textBoxPretBilet
            // 
            this.textBoxPretBilet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPretBilet.Enabled = false;
            this.textBoxPretBilet.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretBilet.Location = new System.Drawing.Point(400, 188);
            this.textBoxPretBilet.Name = "textBoxPretBilet";
            this.textBoxPretBilet.Size = new System.Drawing.Size(154, 27);
            this.textBoxPretBilet.TabIndex = 63;
            // 
            // textBoxOrasDestinatie
            // 
            this.textBoxOrasDestinatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOrasDestinatie.Enabled = false;
            this.textBoxOrasDestinatie.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrasDestinatie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOrasDestinatie.Location = new System.Drawing.Point(400, 59);
            this.textBoxOrasDestinatie.Name = "textBoxOrasDestinatie";
            this.textBoxOrasDestinatie.Size = new System.Drawing.Size(154, 27);
            this.textBoxOrasDestinatie.TabIndex = 59;
            // 
            // textBoxOrasPlecare
            // 
            this.textBoxOrasPlecare.BackColor = System.Drawing.Color.White;
            this.textBoxOrasPlecare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOrasPlecare.Enabled = false;
            this.textBoxOrasPlecare.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrasPlecare.Location = new System.Drawing.Point(230, 59);
            this.textBoxOrasPlecare.Name = "textBoxOrasPlecare";
            this.textBoxOrasPlecare.Size = new System.Drawing.Size(154, 27);
            this.textBoxOrasPlecare.TabIndex = 58;
            // 
            // textBoxLocuriDisponibile
            // 
            this.textBoxLocuriDisponibile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLocuriDisponibile.Enabled = false;
            this.textBoxLocuriDisponibile.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocuriDisponibile.Location = new System.Drawing.Point(230, 188);
            this.textBoxLocuriDisponibile.Name = "textBoxLocuriDisponibile";
            this.textBoxLocuriDisponibile.Size = new System.Drawing.Size(154, 27);
            this.textBoxLocuriDisponibile.TabIndex = 62;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonClose.Location = new System.Drawing.Point(750, -2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 43);
            this.buttonClose.TabIndex = 73;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.GridColor = System.Drawing.Color.White;
            this.dataGridViewTickets.Location = new System.Drawing.Point(32, 303);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(746, 279);
            this.dataGridViewTickets.TabIndex = 74;
            // 
            // buttonStergeZbor
            // 
            this.buttonStergeZbor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonStergeZbor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStergeZbor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeZbor.ForeColor = System.Drawing.Color.White;
            this.buttonStergeZbor.Location = new System.Drawing.Point(12, 24);
            this.buttonStergeZbor.Name = "buttonStergeZbor";
            this.buttonStergeZbor.Size = new System.Drawing.Size(179, 39);
            this.buttonStergeZbor.TabIndex = 75;
            this.buttonStergeZbor.Text = "Sterge zbor";
            this.buttonStergeZbor.UseVisualStyleBackColor = false;
            this.buttonStergeZbor.Click += new System.EventHandler(this.buttonStergeZbor_Click);
            // 
            // FlightDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.buttonStergeZbor);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDistanta);
            this.Controls.Add(this.labelDurataEstimata);
            this.Controls.Add(this.textBoxDistanta);
            this.Controls.Add(this.textBoxDurataEstimata);
            this.Controls.Add(this.labelDataPlecarii);
            this.Controls.Add(this.labelPretBilet);
            this.Controls.Add(this.labelLocuriDisponibile);
            this.Controls.Add(this.labelOrasDestinatie);
            this.Controls.Add(this.labelOrasPlecare);
            this.Controls.Add(this.dateTimePickerDataPlecarii);
            this.Controls.Add(this.textBoxPretBilet);
            this.Controls.Add(this.textBoxOrasDestinatie);
            this.Controls.Add(this.textBoxOrasPlecare);
            this.Controls.Add(this.textBoxLocuriDisponibile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistanta;
        private System.Windows.Forms.Label labelDurataEstimata;
        private System.Windows.Forms.TextBox textBoxDistanta;
        private System.Windows.Forms.TextBox textBoxDurataEstimata;
        private System.Windows.Forms.Label labelDataPlecarii;
        private System.Windows.Forms.Label labelPretBilet;
        private System.Windows.Forms.Label labelLocuriDisponibile;
        private System.Windows.Forms.Label labelOrasDestinatie;
        private System.Windows.Forms.Label labelOrasPlecare;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPlecarii;
        private System.Windows.Forms.TextBox textBoxPretBilet;
        private System.Windows.Forms.TextBox textBoxOrasDestinatie;
        private System.Windows.Forms.TextBox textBoxOrasPlecare;
        private System.Windows.Forms.TextBox textBoxLocuriDisponibile;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonStergeZbor;
    }
}