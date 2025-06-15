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
    public partial class Registration : Form
    {
        private readonly AuthService _authService;
        public Registration(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void existuserlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new WelcomeScreen().Show();
            this.Hide();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            if (_authService == null)
            { MessageBox.Show("Ошибка: Сервис авторизации не инициализирован!"); return;}

            if (string.IsNullOrWhiteSpace(EmailReg.Text) || string.IsNullOrWhiteSpace(LoginReg.Text) ||
                string.IsNullOrWhiteSpace(PasswordReg.Text) || string.IsNullOrWhiteSpace(RepPasswordReg.Text))
            { MessageBox.Show("Заполните все поля!"); return;}

            int? newUserId = _authService.RegisterUser(LoginReg.Text, PasswordReg.Text, EmailReg.Text);

            if (newUserId.HasValue)
            {
                var newEmployeeForm = new NewEmployeeForm(
                    userId: newUserId.Value,
                    username: LoginReg.Text,
                    email: EmailReg.Text,
                    password: PasswordReg.Text);

                if (newEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Регистрация и создание профиля сотрудника успешно завершены!");
                    this.Close();
                    new WelcomeScreen().Show();
                }
            }
            else {  MessageBox.Show("Произошла ошибка при регистрации.");}
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (PasswordReg.UseSystemPasswordChar == true)
            {
                PasswordReg.UseSystemPasswordChar = false;
                PasswordReg.PasswordChar = '\0';
            }
            else if (PasswordReg.UseSystemPasswordChar == false)
            { PasswordReg.UseSystemPasswordChar = true; }

        }

        private void showRepPassword_Click(object sender, EventArgs e)
        {
            if (RepPasswordReg.UseSystemPasswordChar == true)
            {
                RepPasswordReg.UseSystemPasswordChar = false;
                RepPasswordReg.PasswordChar = '\0';
            }
            else if (RepPasswordReg.UseSystemPasswordChar == false)
            { RepPasswordReg.UseSystemPasswordChar = true; }
        }
    }
}
