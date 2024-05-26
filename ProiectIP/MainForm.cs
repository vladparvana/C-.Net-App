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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInregistrare_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.TopLevel = false;
            registerForm.TopMost = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            panelAction.Controls.Clear();
            panelAction.Controls.Add(registerForm);
            registerForm.Show();
        }

        private void buttonAutentificare_Click_1(object sender, EventArgs e)
        {
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
