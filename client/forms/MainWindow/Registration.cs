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
            {
                MessageBox.Show("Заполните все поля!"); return;
            }

            if (_authService.RegisterUser(LoginReg.Text, PasswordReg.Text, EmailReg.Text))
            { MessageBox.Show("Регистрация успешна!"); this.Close(); }

            else
            { MessageBox.Show("Произошла ошибка.");}
        }
    }
}
