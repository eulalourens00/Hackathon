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
        public WelcomeScreen()
        {
            InitializeComponent();
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
            MessageBox.Show(
                "Для создания учетной записи в системе необходимо обратиться к Вашему руководителю." +
                "\n\nEmail: admin@pomegranate.com",
                "Регистрация в системе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
