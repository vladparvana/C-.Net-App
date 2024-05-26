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
    /// Formular pentru panoul de administrare al aplicației.
    /// </summary>
    public partial class AdminDashboardForm : Form
    {
        // Utilizatorul curent logat în sistem
        private User _user { get; set; }

        /// <summary>
        /// Constructorul clasei AdminDashboardForm.
        /// </summary>
        /// <param name="user">Utilizatorul curent logat în sistem.</param>
        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            this._user = user;
            // Evenimentul de încărcare a formularului
            this.Load += new EventHandler(AdminDashboardForm_Load);
        }

        /// <summary>
        /// Evenimentul de încărcare a formularului.
        /// </summary>
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Verificarea existenței utilizatorului
                if (_user == null)
                {
                    throw (new Exception("Eroare la încărcarea datelor utilizatorului."));
                }
                // Afișarea numelui utilizatorului pe etichetă
                labelUserName.Text = $"{_user.Nume} {_user.Prenume}";
            }
            catch (Exception ex)
            {
                // Tratarea excepției și afișarea mesajului de eroare
                MessageBox.Show(ex.Message);
                // Închiderea formularului în caz de eroare
                this.Close();
                return;
            }
        }

        /// <summary>
        /// Evenimentul de închidere a formularului.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evenimentul de deconectare.
        /// </summary>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evenimentul pentru afișarea formularului cu zboruri.
        /// </summary>
        private void buttonZboruri_Click(object sender, EventArgs e)
        {
            AdminFlightsForm flightsForm = new AdminFlightsForm();
            flightsForm.TopLevel = false;
            flightsForm.TopMost = false;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(flightsForm);
            flightsForm.Show();
        }

        /// <summary>
        /// Evenimentul pentru afișarea formularului cu utilizatori.
        /// </summary>
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
