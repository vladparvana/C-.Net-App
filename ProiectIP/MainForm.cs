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
    /// Fereastra principală a aplicației.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructorul clasei MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de închidere a aplicației.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de înregistrare.
        /// </summary>
        private void buttonInregistrare_Click_1(object sender, EventArgs e)
        {
            // Se deschide fereastra de înregistrare în cadrul panoului de acțiune
            RegisterForm registerForm = new RegisterForm();
            registerForm.TopLevel = false;
            registerForm.TopMost = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(registerForm);
            registerForm.Show();
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de autentificare.
        /// </summary>
        private void buttonAutentificare_Click_1(object sender, EventArgs e)
        {
            // Se deschide fereastra de autentificare în cadrul panoului de acțiune
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.TopMost = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(loginForm);
            loginForm.Show();
        }
    }
}
