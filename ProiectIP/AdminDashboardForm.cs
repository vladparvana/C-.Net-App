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
    public partial class AdminDashboardForm : Form
    {
        private User _user { get; set; }
        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Load += new EventHandler(AdminDashboardForm_Load);
        }
        private void AdminDashboardForm_Load(object sender, EventArgs e)
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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZboruri_Click(object sender, EventArgs e)
        {
            AdminFlightsForm flightsForm = new AdminFlightsForm();
            flightsForm.TopLevel = false;
            flightsForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(flightsForm);
            flightsForm.Show();
        }

        private void buttonUtilizatori_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.TopLevel = false;
            usersForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(usersForm);
            usersForm.Show();
        }
    }
}
