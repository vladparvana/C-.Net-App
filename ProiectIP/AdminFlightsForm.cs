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
    /// <summary>
    /// Formular pentru gestionarea zborurilor de către administrator.
    /// </summary>
    public partial class AdminFlightsForm : Form
    {
        /// <summary>
        /// Constructorul clasei AdminFlightsForm.
        /// </summary>
        public AdminFlightsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdminFlightsForm_Load);
        }

        /// <summary>
        /// Evenimentul de încărcare a formularului.
        /// </summary>
        protected void AdminFlightsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Se încarcă zborurile din baza de date și se afișează într-un DataGridView
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

                    // Se adaugă o coloană de butoane pentru detalii la fiecare rând din DataGridView
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
                // Se afișează un mesaj de eroare în caz de problemă
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evenimentul pentru adăugarea unui zbor nou.
        /// </summary>
        private void buttonAdaugaZbor_Click(object sender, EventArgs e)
        {
            // Se afișează un formular pentru adăugarea unui zbor nou
            AddFlightsForm addFlightForm = new AddFlightsForm();
            addFlightForm.ShowDialog();
        }

        /// <summary>
        /// Evenimentul pentru gestionarea detaliilor unui zbor.
        /// </summary>
        private void DataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se verifică dacă s-a făcut clic pe butonul de detalii
            if (e.ColumnIndex == dataGridViewFlights.Columns["btnDetails"].Index && e.RowIndex >= 0)
            {
                // Se obține ID-ul zborului selectat și se afișează detalii despre zbor
                int zborID = (int)dataGridViewFlights.Rows[e.RowIndex].Cells["ZborID"].Value;
                FlightDetailsForm detaliiZborForm = new FlightDetailsForm(zborID);
                detaliiZborForm.ShowDialog();
            }
        }
    }
}
