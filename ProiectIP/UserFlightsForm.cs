using DatabaseAccess.Database;
using DatabaseAccess.Entities;
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
    /// Fereastra pentru vizualizarea și cumpărarea zborurilor disponibile.
    /// </summary>
    public partial class UserFlightsForm : Form
    {
        private User _user { get; set; }

        /// <summary>
        /// Constructorul clasei UserFlightsForm.
        /// </summary>
        /// <param name="user">Utilizatorul curent care vizualizează zborurile.</param>
        public UserFlightsForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(UserFlightsForm_Load);
        }

        /// <summary>
        /// Evenimentul declanșat la încărcarea formularului.
        /// </summary>
        private void UserFlightsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    // Se selectează zborurile disponibile și se afișează într-un DataGridView
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

                    // Se adaugă un buton în fiecare rând al DataGridView pentru cumpărarea biletului
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Acțiune";
                    btn.Name = "btnCumpara";
                    btn.Text = "Cumpara";
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

        /// <summary>
        /// Eveniment declanșat la apăsarea butonului "Cumpara" pentru un anumit zbor.
        /// </summary>
        private void DataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridViewFlights.Columns["btnCumpara"].Index && e.RowIndex >= 0)
                {
                    int zborID = (int)dataGridViewFlights.Rows[e.RowIndex].Cells["ZborID"].Value;

                    using (var context = new DatabaseContext("DataBase.db"))
                    {
                        // Se verifică disponibilitatea locurilor pentru zbor
                        var flight = context.Flights.FirstOrDefault(f => f.ZborID == zborID);
                        if (flight == null || flight.LocuriDisponibile <= 0)
                        {
                            throw new Exception("Nu mai sunt locuri disponibile pentru acest zbor.");
                        }

                        // Se încearcă achiziționarea unui bilet pentru utilizator
                        var availableTicket = context.Tickets.FirstOrDefault(t => t.ZborID == zborID && t.Stare == "Valabil");
                        if (availableTicket != null)
                        {
                            availableTicket.Stare = "Cumparat";
                            availableTicket.UserID = _user.UserID;
                            context.SaveChanges();
                            flight.LocuriDisponibile--;
                            context.SaveChanges();

                            MessageBox.Show("Bilet cumpărat cu succes!");
                            UserFlightsForm_Load(this, EventArgs.Empty); // Se reîncarcă zborurile disponibile

                        }
                        else
                        {
                            throw new Exception("Nu există bilete disponibile pentru acest zbor.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
