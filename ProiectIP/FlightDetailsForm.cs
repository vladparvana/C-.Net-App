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
using DatabaseAccess.Entities;

namespace ProiectIP
{
    public partial class FlightDetailsForm : Form
    {
        private int _zborID;
        private Flight _flight;

        public FlightDetailsForm(int zborID)
        {
            InitializeComponent();
            this._zborID = zborID;
            this.Load += new EventHandler(FlightDetailsForm_Load);
        }

        private void FlightDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    _flight = context.Flights.FirstOrDefault(f => f.ZborID == _zborID);
                    if (_flight != null)
                    {
                        textBoxOrasPlecare.Text = _flight.OrasPlecare;
                        textBoxOrasDestinatie.Text = _flight.OrasDestinatie;
                        textBoxDistanta.Text = _flight.Distanta.ToString();
                        textBoxDurataEstimata.Text = _flight.DurataEstimata.ToString();
                        textBoxPretBilet.Text = _flight.PretBilet.ToString();
                        textBoxLocuriDisponibile.Text = _flight.LocuriDisponibile.ToString();
                    }
                    var tickets = context.Tickets
                    .Where(t => t.ZborID == _zborID)
                    .Select(t => new
                    {
                        t.BiletID,
                        t.Loc,
                        t.DataCumparare,
                        t.PretBilet,
                        t.Stare
                    })
                    .ToList();

                    dataGridViewTickets.DataSource = tickets;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStergeZbor_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    bool allTicketsValid = context.Tickets.Any(t => t.ZborID == _zborID && t.Stare != "Valabil");

                    if (allTicketsValid)
                    {
                        throw new Exception("Există bilete cumpărate pentru acest zbor. Nu se poate șterge.");
                    }

                    var ticketsToDelete = context.Tickets.Where(t => t.ZborID == _zborID);
                    context.Tickets.RemoveRange(ticketsToDelete);

                    var flightToDelete = context.Flights.FirstOrDefault(f => f.ZborID == _zborID);
                    if (flightToDelete != null)
                    {
                        context.Flights.Remove(flightToDelete);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Zborul și biletele asociate au fost șterse cu succes.");
                    this.Close();
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
        }
    }
}
