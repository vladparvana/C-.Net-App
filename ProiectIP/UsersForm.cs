using DatabaseAccess.Database;
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
    /// Fereastra pentru afișarea utilizatorilor din baza de date.
    /// </summary>
    public partial class UsersForm : Form
    {
        /// <summary>
        /// Constructorul clasei UsersForm.
        /// </summary>
        public UsersForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(UsersForm_Load);
        }

        /// <summary>
        /// Evenimentul declanșat la încărcarea formularului.
        /// </summary>
        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
                    // Se selectează utilizatorii din bază și se afișează într-un DataGridView
                    var users = context.Users
                    .Select(f => new
                    {
                        f.UserID,
                        f.Nume,
                        f.Prenume,
                        f.Email,
                        f.DataNastere,
                        f.Admin
                    })
                    .ToList();
                    dataGridViewUsers.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
