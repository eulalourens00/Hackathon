using SqliteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.forms.MainWindow
{
    public partial class WelcomeScreen : Form
    {
        private readonly Database _database;
        private readonly AuthService _authService;
        public WelcomeScreen()
        {
            InitializeComponent();
            _database = new Database("dataBase.db");
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Для восстановления пароля обратитесь к администратору." +
                "\n\nEmail: admin@pomegranate.com",
                "Восстановление пароля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void newuserlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var authService = new AuthService(@"C:\Hackathon\dataBase.db", _database);
            var registrationForm = new Registration(authService);
            registrationForm.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string dbFilePath = @"C:\Hackathon\dataBase.db";
            var authService = new AuthService(dbFilePath, _database);

            Users user = authService.Authenticate(
                Login.Text,
                Password.Text
            );

            if (user != null)
            { MessageBox.Show($"Добро пожаловать, {user.username}!");

                bool isAdmin = (Login.Text == "admin" && Password.Text == "admin_09");
                var accountForm = new AccountForm(isAdmin);
                accountForm.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Неверные данные."); }
        }
    }
}
