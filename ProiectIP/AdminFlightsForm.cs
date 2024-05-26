using DatabaseAccess.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class AdminFlightsForm : Form
    {
        public AdminFlightsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdminFlightsForm_Load);
        }

        protected void AdminFlightsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    var flights = context.Flights
                    .Select(f => new
                    {
                        f.ZborID,
                        f.OrasPlecare,
                        f.OrasDestinatie,
                        f.Distanta,
                        f.DurataEstimata,
                        f.PretBilet,
                        f.LocuriDisponibile
                    })
                    .ToList();
                    dataGridViewFlights.DataSource = flights;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Acțiune";
                    btn.Name = "btnDetails";
                    btn.Text = "Detalii";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridViewFlights.Columns.Add(btn);
                    dataGridViewFlights.CellContentClick += DataGridViewFlights_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdaugaZbor_Click(object sender, EventArgs e)
        {
            AddFlightsForm addFlightForm = new AddFlightsForm();
            addFlightForm.ShowDialog();
        }

        private void DataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFlights.Columns["btnDetails"].Index && e.RowIndex >= 0)
            {
                int zborID = (int)dataGridViewFlights.Rows[e.RowIndex].Cells["ZborID"].Value;
                FlightDetailsForm detaliiZborForm = new FlightDetailsForm(zborID);
                detaliiZborForm.ShowDialog();
            }
        }

    }
}
