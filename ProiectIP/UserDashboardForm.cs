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
    /// Fereastra pentru panoul de bord al utilizatorului.
    /// </summary>
    public partial class UserDashboardForm : Form
    {
        private User _user { get; set; }

        /// <summary>
        /// Constructorul clasei UserDashboardForm.
        /// </summary>
        /// <param name="user">Utilizatorul curent pentru care se afișează panoul de bord.</param>
        public UserDashboardForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(UserDashboardForm_Load);
        }

        /// <summary>
        /// Evenimentul declanșat la încărcarea formularului.
        /// </summary>
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_user == null)
                {
                    throw new Exception("Eroare la încărcarea datelor utilizatorului.");
                }
                labelUserName.Text = $"{_user.Nume} {_user.Prenume}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                return;
            }
        }

        /// <summary>
        /// Închide fereastra curentă.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Deconectează utilizatorul și închide fereastra curentă.
        /// </summary>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Deschide fereastra pentru vizualizarea zborurilor disponibile.
        /// </summary>
        private void buttonZboruri_Click(object sender, EventArgs e)
        {
            UserFlightsForm flightsForm = new UserFlightsForm(_user);
            flightsForm.TopLevel = false;
            flightsForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(flightsForm);
            flightsForm.Show();
        }

        /// <summary>
        /// Deschide fereastra pentru vizualizarea biletelor achiziționate.
        /// </summary>
        private void buttonBilete_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm(_user);
            ticketsForm.TopLevel = false;
            ticketsForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(ticketsForm);
            ticketsForm.Show();
        }
    }
}
