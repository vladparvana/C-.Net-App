using DatabaseAccess.Database;
using DatabaseAccess.Entities;
using System;
using System.IO;
using System.Windows.Forms;
using ChainOfResponsibility.Validators;
using System.Data.Entity.Infrastructure;
using System.Security.Cryptography;
using System.Text;

namespace ProiectIP
{
    /// <summary>
    /// Fereastra de înregistrare a utilizatorilor în aplicație.
    /// </summary>
    public partial class RegisterForm : Form
    {
        private UserValidator _validator;

        /// <summary>
        /// Constructorul clasei RegisterForm.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            _validator = new UserValidator();
        }

        /// <summary>
        /// Evenimentul declanșat la apăsarea butonului de înregistrare.
        /// </summary>
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            var databasePath = Path.GetFullPath("DataBase.db");

            using (var context = new DatabaseContext(databasePath))
            {
                // Se criptează parola utilizatorului înainte de stocare
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBoxParola.Text));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    var parola = builder.ToString();
                    var user = new User
                    {
                        Nume = textBoxNume.Text,
                        Prenume = textBoxPrenume.Text,
                        DataNastere = dateTimePickerDataNasterii.Value,
                        Email = textBoxEmail.Text,
                        Parola = textBoxParola.Text,
                        Admin = "NU"
                    };
                    try
                    {
                        // Se verifică corectitudinea datelor introduse de utilizator
                        if (textBoxParola.Text != textBoxComfirmareParola.Text)
                        {
                            throw new Exception("Parole diferite.");
                        }

                        if (!radioButtonTermeni.Checked)
                        {
                            throw new Exception("Trebuie să fiți de acord cu termenii și condițiile.");
                        }

                        // Se validează utilizatorul folosind un validator
                        _validator.Validate(user);
                        user.Parola = parola;
                        context.Users.Add(user);
                        context.SaveChanges();

                        MessageBox.Show("Utilizatorul a fost adăugat cu succes în baza de date!");
                        Application.Restart();

                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show("Există deja un utilizator cu această adresă de email.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
