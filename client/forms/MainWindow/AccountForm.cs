using client.models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AccountForm : Form
    {
        private readonly DBController _controller;
        private Employees _currentEmployee;
        private readonly int _userId;
        public AccountForm()
        {
            InitializeComponent();

            Console.WriteLine($"Текущий ID пользователя: {AdminSession.CurrentUserId}");

            if (AdminSession.CurrentUserId == 0)
            {
                MessageBox.Show("Ошибка: ID пользователя не установлен");
                this.Close();
                return;
            }

            _userId = AdminSession.CurrentUserId;
            _controller = new DBController(@"C:\Hackathon\dataBase.db");
            SetupControls();
            LoadAccountData();

            LoadAvatar();
        }
        private void SetupControls()
        {
            FN_box.ReadOnly = true;
            LN_box.ReadOnly = true;
            UsernameBox.ReadOnly = true;
            EmailBox.ReadOnly = true;
            RoleBox.ReadOnly = true;
            PositionBox.ReadOnly = true;

        }

        private void LoadAccountData()
        {
            try
            {
                var userInfo = _controller.GetUserWithEmployeeInfo(_userId);
                if (userInfo != null)
                {
                    UsernameBox.Text = userInfo.username;
                    EmailBox.Text = userInfo.email;
                    FN_box.Text = userInfo.first_name;
                    LN_box.Text = userInfo.last_name;
                    PositionBox.Text = userInfo.position_name ?? "Не указано";
                    RoleBox.Text = userInfo.role_name ?? "Не указано";
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки данных: {ex.Message}"); }
        }

        private void ChangeAvaLik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkPhoto = new LinkForm();
            linkPhoto.ShowDialog();

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pomegranate — это легкий в использовании инструмент для межведомственных групп," +
                "занимающихся контролем и надзором. " +
                "Он помогает собирать информацию, контролировать выполнение решений и составлять повестку.", "Pomegranate: Сервис для контроля проблемных объектов",
                 MessageBoxButtons.OKCancel);
        }

        private void AdminSMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Связаться с администрацией можно по следующему эл. адресу - "
                +"admin_pomegranate@com", "Администрация", MessageBoxButtons.OKCancel);
        }
        // что за фигня вообще. админ тру  крч. попытка зайти обратно на учетку - флс. не работает ептель


        private void LoadAvatar()
        {
            try
            {
                var userInfo = _controller.GetUserWithEmployeeInfo(_userId);
                if (userInfo != null)
                {
                    var avatarPath = _controller.GetEmployeeAvatar(userInfo.employee_id);
                    if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
                    {
                        avatarPictureBox.Image = Image.FromFile(avatarPath);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки аватарки: {ex.Message}");
            }
        }
    }
}
