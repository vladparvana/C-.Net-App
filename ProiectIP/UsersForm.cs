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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(UsersForm_Load);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext("DataBase.db"))
                {
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
