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
    public partial class TicketsForm : Form
    {

        private User _user { get; set; }
        public TicketsForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(TicketsForm_Load);
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    var userTickets = context.Tickets
                        .Where(t => t.UserID == _user.UserID && t.Stare == "Cumparat")
                        .ToList();

                    var ticketDetails = new List<object>();

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
