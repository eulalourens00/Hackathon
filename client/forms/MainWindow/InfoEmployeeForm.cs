using client.models;
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
    public partial class InfoEmployeeForm : Form
    {
        private readonly DBController _controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly int _employeeId;
        public InfoEmployeeForm(int employeeId)
        {
            InitializeComponent();

            _employeeId = employeeId;

            SetupControls();
            LoadEmployeetData(employeeId);
        }

        private void SetupControls()
        {
            FnameBox.ReadOnly = true;
            LnameBox.ReadOnly = true;
            EmailBox.ReadOnly = true;
            RoleBox.ReadOnly = true;
            PositionBox.ReadOnly = true;
            LoginBox.ReadOnly = true;
            PasswordBox.PasswordChar = '*';
            PasswordBox.ReadOnly = true;
        }

        private void LoadEmployeetData(int employeeId)
        {
            try
            {
                var employeeInfo = _controller.GetALLUserWithEmployeeInfo(_employeeId);

                if (employeeInfo == null)
                {
                    MessageBox.Show("Данные сотрудника не найдены");
                    this.Close();
                    return;
                }
                LoginBox.Text = employeeInfo.username ?? "Не указано";
                PasswordBox.Text = employeeInfo.password ?? "Не указано";
                EmailBox.Text = employeeInfo.email ?? "Не указано";
                FnameBox.Text = employeeInfo.first_name ?? "Не указано";
                LnameBox.Text = employeeInfo.last_name ?? "Не указано";
                PositionBox.Text = employeeInfo.position_name ?? "Не указано";
                RoleBox.Text = employeeInfo.role_name ?? "Не указано";
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки данных: {ex.Message}"); }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
