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
    /// <summary>
    /// Fereastra pentru afișarea și gestionarea detaliilor unui zbor.
    /// </summary>
    public partial class FlightDetailsForm : Form
    {
        private int _zborID; // ID-ul zborului curent
        private Flight _flight; // Obiectul Flight asociat zborului

        /// <summary>
        /// Constructorul clasei FlightDetailsForm.
        /// </summary>
        /// <param name="zborID">ID-ul zborului pentru care se afișează detalii.</param>
        public FlightDetailsForm(int zborID)
        {
            InitializeComponent();
            this._zborID = zborID;
            this.Load += new EventHandler(FlightDetailsForm_Load);
        }

        /// <summary>
        /// Evenimentul de încărcare a formularului.
        /// </summary>
        private void FlightDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    // Se obțin detalii despre zbor și se afișează în controalele formularului
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

                    // Se obțin biletele asociate zborului și se afișează într-un DataGridView
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
                // Tratarea excepției și afișarea mesajului de eroare
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evenimentul pentru închiderea formularului.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evenimentul pentru ștergerea zborului și a biletele asociate.
        /// </summary>
        private void buttonStergeZbor_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    // Se verifică dacă există bilete cumpărate pentru zborul curent
                    bool allTicketsValid = context.Tickets.Any(t => t.ZborID == _zborID && t.Stare != "Valabil");

                    if (allTicketsValid)
                    {
                        throw new Exception("Există bilete cumpărate pentru acest zbor. Nu se poate șterge.");
                    }

                    // Se șterg biletele asociate zborului
                    var ticketsToDelete = context.Tickets.Where(t => t.ZborID == _zborID);
                    context.Tickets.RemoveRange(ticketsToDelete);

                    // Se șterge zborul
                    var flightToDelete = context.Flights.FirstOrDefault(f => f.ZborID == _zborID);
                    if (flightToDelete != null)
                    {
                        context.Flights.Remove(flightToDelete);
                        context.SaveChanges();
                    }

                    // Se afișează un mesaj de succes
                    MessageBox.Show("Zborul și biletele asociate au fost șterse cu succes.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Tratarea excepției și afișarea mesajului de eroare
                MessageBox.Show(ex.Message);
            }
        }
    }
}
