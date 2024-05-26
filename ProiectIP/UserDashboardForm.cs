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
    public partial class UserDashboardForm : Form
    {
        private User _user { get; set; }
        public UserDashboardForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(UserDashboardForm_Load);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_user == null)
                {
                    throw (new Exception("Eroare la încărcarea datelor utilizatorului."));

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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZboruri_Click(object sender, EventArgs e)
        {
            UserFlightsForm flightsForm = new UserFlightsForm(_user);
            flightsForm.TopLevel = false;
            flightsForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(flightsForm);
            flightsForm.Show();
        }

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
