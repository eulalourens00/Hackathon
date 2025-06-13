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
        private bool isAdmin;
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
            this.Hide();

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
            {
                MessageBox.Show($"Добро пожаловать, {user.username}!");

                AdminSession.isAdmin = (Login.Text == "admin" && Password.Text == "admin_09");
                AdminSession.Username = user.username;
                AdminSession.CurrentUserId = user.id;
                new AccountForm().Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Неверные данные."); }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar == true)
            {
                Password.UseSystemPasswordChar = false;
                Password.PasswordChar = '\0';
            }
            else if (Password.UseSystemPasswordChar == false)
            { Password.UseSystemPasswordChar = true; }
        }
    }


    // для сохранения админки, ибо она сбрасывается между переходами на формы
    public static class AdminSession
    {
        public static bool isAdmin { get; set; }
        public static string Username { get; set; }
        public static int CurrentUserId { get; set; }
    }
}
