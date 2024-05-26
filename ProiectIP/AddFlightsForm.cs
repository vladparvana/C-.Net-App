using ChainOfResponsibility.Validators;
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
    public partial class AddFlightsForm : Form
    {
        public AddFlightsForm()
        {
            InitializeComponent();
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                string orasDestinatie = textBoxOrasDestinatie.Text;
                string orasPlecare = textBoxOrasPlecare.Text;
                DateTime dataPlecare = dateTimePickerDataPlecarii.Value;
                double durataEstimata = Convert.ToDouble(textBoxDurataEstimata.Text);
                double distanta = Convert.ToDouble(textBoxDistanta.Text);
                decimal pretBilet = Convert.ToDecimal(textBoxPretBilet.Text);
                int locuriDisponibile = Convert.ToInt32(textBoxLocuriDisponibile.Text);

                var newFlight = new Flight
                {
                    OrasDestinatie = orasDestinatie,
                    DataPlecare = dataPlecare,
                    DurataEstimata = durataEstimata,
                    Distanta = distanta,
                    PretBilet = pretBilet,
                    OrasPlecare = orasPlecare,
                    LocuriDisponibile = locuriDisponibile
                };

                var validator = new FlightValidator();
                validator.Validate(newFlight);

                using (var context = new DatabaseContext("DataBase.db"))
                {
                    context.Flights.Add(newFlight);
                    context.SaveChanges();

                    int zborID = newFlight.ZborID;

                    for (int i = 0; i < locuriDisponibile; i++)
                    {
                        var ticket = new Ticket
                        {
                            ZborID = zborID,
                            BiletID = i+1,
                            Loc = i + 1,
                            DataCumparare = DateTime.Now,
                            PretBilet = pretBilet,
                            Stare = "Valabil"
                        };

                        context.Tickets.Add(ticket);
                    }

                    context.SaveChanges();
                }
                MessageBox.Show("Zborul a fost adăugat cu succes!");
                this.Close();
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
    }
}
