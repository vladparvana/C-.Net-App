using DatabaseAccess.Database;
using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    /// <summary>
    /// Fereastra de autentificare în aplicație.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Constructorul clasei LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda pentru verificarea corectitudinii parolei.
        /// </summary>
        /// <param name="inputPassword">Parola introdusă de utilizator.</param>
        /// <param name="storedPassword">Parola stocată în baza de date.</param>
        /// <returns>True dacă parolele coincid, false în caz contrar.</returns>
        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                StringBuilder inputBuilder = new StringBuilder();
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    inputBuilder.Append(inputBytes[i].ToString("x2"));
                }
                string inputHash = inputBuilder.ToString();

                return inputHash == storedPassword;
            }
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de autentificare.
        /// </summary>
        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string parola = textBoxParola.Text;
            try
            {
                // Se verifică credențialele utilizatorului în baza de date
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    var user = context.Users.FirstOrDefault(u => u.Email == email);

                    if (user != null && VerifyPassword(parola, user.Parola))
                    {
                        // Dacă autentificarea este reușită, se deschide fereastra corespunzătoare
                        if (user.Admin == "DA")
                        {
                            AdminDashboardForm adminDashboardForm = new AdminDashboardForm(user);
                            adminDashboardForm.ShowDialog();
                        }
                        else
                        {
                            UserDashboardForm userDashboardForm = new UserDashboardForm(user);
                            userDashboardForm.ShowDialog();
                        }
                    }
                    else
                    {
                        // Dacă autentificarea nu este reușită, se afișează un mesaj de eroare
                        throw new Exception("Adresa de email sau parola incorectă!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Se afișează un mesaj de eroare în caz de probleme
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de revenire la pagina de start.
        /// </summary>
        private void buttonAcasa_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
