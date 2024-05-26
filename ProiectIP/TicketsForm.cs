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
    /// Fereastra pentru afișarea biletelor utilizatorului curent.
    /// </summary>
    public partial class TicketsForm : Form
    {
        private User _user { get; set; }

        /// <summary>
        /// Constructorul clasei TicketsForm.
        /// </summary>
        /// <param name="user">Utilizatorul curent pentru care se afișează biletele.</param>
        public TicketsForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(TicketsForm_Load);
        }

        /// <summary>
        /// Evenimentul declanșat la încărcarea formularului.
        /// </summary>
        private void TicketsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    // Se obțin biletele utilizatorului curent cu starea "Cumparat"
                    var userTickets = context.Tickets
                        .Where(t => t.UserID == _user.UserID && t.Stare == "Cumparat")
                        .ToList();

                    var ticketDetails = new List<object>();

                    // Pentru fiecare bilet, se obțin detalii despre zborul asociat
                    foreach (var ticket in userTickets)
                    {
                        var zborInfo = context.Flights
                            .Where(f => f.ZborID == ticket.ZborID)
                            .Select(f => new
                            {
                                f.OrasPlecare,
                                f.OrasDestinatie,
                                f.Distanta,
                                f.DurataEstimata,
                                f.PretBilet
                            })
                            .FirstOrDefault();

                        // Se creează un obiect cu detalii complete despre bilet
                        var ticketDetail = new
                        {
                            ticket.BiletID,
                            ticket.ZborID,
                            ticket.Loc,
                            ticket.DataCumparare,
                            ticket.Stare,
                            OrasPlecare = zborInfo.OrasPlecare,
                            OrasDestinatie = zborInfo.OrasDestinatie,
                            Distanta = zborInfo.Distanta,
                            DurataEstimata = zborInfo.DurataEstimata,
                            PretBilet = zborInfo.PretBilet
                        };

                        ticketDetails.Add(ticketDetail);
                    }

                    // Se afișează detaliile biletelor într-un control DataGridView
                    dataGridViewTickets.DataSource = ticketDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
