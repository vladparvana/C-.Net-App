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
    public partial class UserFlightsForm : Form
    {
        private User _user { get; set; }
        public UserFlightsForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(UserFlightsForm_Load);
        }

        private void UserFlightsForm_Load(object sender, EventArgs e)
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
        private void DataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridViewFlights.Columns["btnCumpara"].Index && e.RowIndex >= 0)
                {
                    int zborID = (int)dataGridViewFlights.Rows[e.RowIndex].Cells["ZborID"].Value;

                    using (var context = new DatabaseContext("DataBase.db"))
                    {
                        var flight = context.Flights.FirstOrDefault(f => f.ZborID == zborID);
                        if (flight == null || flight.LocuriDisponibile <= 0)
                        {
                            throw new Exception("Nu mai sunt locuri disponibile pentru acest zbor.");
                            return;
                        }

                        var availableTicket = context.Tickets.FirstOrDefault(t => t.ZborID == zborID && t.Stare == "Valabil");
                        if (availableTicket != null)
                        {
                            availableTicket.Stare = "Cumparat";
                            availableTicket.UserID = _user.UserID;
                            context.SaveChanges();
                            flight.LocuriDisponibile--;
                            context.SaveChanges();

                            MessageBox.Show("Bilet cumpărat cu succes!");
                            UserFlightsForm_Load(this, EventArgs.Empty);

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
