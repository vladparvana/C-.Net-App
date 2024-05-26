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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProiectIP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

                        if (user != null && user.Parola == parola)
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
