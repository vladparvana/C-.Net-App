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
    /// <summary>
    /// Formular pentru adăugarea de zboruri în aplicație.
    /// </summary>
    public partial class AddFlightsForm : Form
    {
        /// <summary>
        /// Constructorul clasei AddFlightsForm.
        /// </summary>
        public AddFlightsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evenimentul apăsării butonului de adăugare a zborului.
        /// </summary>
        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                // Se preiau datele introduse de utilizator din interfața grafică
                string orasDestinatie = textBoxOrasDestinatie.Text;
                string orasPlecare = textBoxOrasPlecare.Text;
                DateTime dataPlecare = dateTimePickerDataPlecarii.Value;
                double durataEstimata = Convert.ToDouble(textBoxDurataEstimata.Text);
                double distanta = Convert.ToDouble(textBoxDistanta.Text);
                decimal pretBilet = Convert.ToDecimal(textBoxPretBilet.Text);
                int locuriDisponibile = Convert.ToInt32(textBoxLocuriDisponibile.Text);

                // Se creează un obiect Flight cu datele introduse
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

                // Se validează zborul folosind un validator
                var validator = new FlightValidator();
                validator.Validate(newFlight);

                // Se adaugă zborul în baza de date
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    context.Flights.Add(newFlight);
                    context.SaveChanges();

                    int zborID = newFlight.ZborID;

                    // Se creează bilete asociate zborului și se adaugă în baza de date
                    for (int i = 0; i < locuriDisponibile; i++)
                    {
                        var ticket = new Ticket
                        {
                            ZborID = zborID,
                            BiletID = i + 1,
                            Loc = i + 1,
                            DataCumparare = DateTime.Now,
                            PretBilet = pretBilet,
                            Stare = "Valabil"
                        };

                        context.Tickets.Add(ticket);
                    }

                    context.SaveChanges();
                }
                // Se afișează un mesaj de confirmare și se închide formularul
                MessageBox.Show("Zborul a fost adăugat cu succes!");
                this.Close();
            }
            // Se gestionează excepțiile și se afișează mesajul de eroare în caz de problemă
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evenimentul apăsării butonului de închidere a formularului.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Se închide formularul
            this.Close();
        }
    }
}
