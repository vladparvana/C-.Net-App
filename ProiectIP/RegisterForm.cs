using DatabaseAccess.Database;
using DatabaseAccess.Entities;
using System;
using System.IO;
using System.Windows.Forms;
using ChainOfResponsibility.Validators;
using System.Data.Entity.Infrastructure;

namespace ProiectIP
{
    public partial class RegisterForm : Form
    {
        private UserValidator _validator;
        public RegisterForm()
        {
            InitializeComponent();
            _validator = new UserValidator();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            var databasePath = Path.GetFullPath("DataBase.db");
            Console.WriteLine(databasePath);

            using (var context = new DatabaseContext(databasePath))
            {

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
                    if (textBoxParola.Text != textBoxComfirmareParola.Text)

                    {
                        throw new Exception("Parole diferite.");
                    }

                    if(!radioButtonTermeni.Checked)
                    {
                        throw new Exception("Trebuie sa fiti de acord cu termenii si conditiile.");
                    }
                    _validator.Validate(user);
                    context.Users.Add(user);
                    context.SaveChanges();

                    Console.WriteLine("Utilizatorul a fost adăugat cu succes în baza de date!");
                    MessageBox.Show("Utilizatorul a fost adăugat cu succes în baza de date!");
                    Application.Restart();
                    
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Exista deja un utilizator cu aceasta adresa de email.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                
            }
        }

        private void buttonAcasa_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
