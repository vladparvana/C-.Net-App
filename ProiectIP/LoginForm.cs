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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProiectIP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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


        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            {
                string email = textBoxEmail.Text;
                string parola = textBoxParola.Text;
                try
                {
                    using (var context = new DatabaseContext("DataBase.db"))
                    {
                        var user = context.Users.FirstOrDefault(u => u.Email == email);

                        if (user != null && VerifyPassword(parola,user.Parola ))
                        {
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
                            throw new Exception("Adresa de email sau parola incorectă!");
                        }
                    }
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
