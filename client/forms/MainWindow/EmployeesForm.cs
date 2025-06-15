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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client.forms.MainWindow
{
    public partial class EmployeesForm : Form
    {
        private readonly bool _isAdmin;
        private readonly DBController _controller = new DBController(@"C:\Hackathon\dataBase.db");

        private readonly int _userId;
        private readonly string _username;
        private readonly string _email;
        private readonly string _password;
        public EmployeesForm(bool isAdmin, int userId = 0, string username = "", string email = "", string password = "")
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            _userId = userId;
            _username = username;
            _email = email;
            _password = password;

            if (_controller?.employeesModel == null)
            { //ААААА ТУТ ТАКОЙ ПРОСКОК БЫЛ АХАХАХАХАХАХ 
                MessageBox.Show("Ошибка инициализации модели сотрудников");
                this.Close();
                return;
            }

            LoadObjects();
        }

        private void LoadObjects()
        {
            try
            {  AddEmployeeToLayout(); }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка загрузки: {ex.Message}"); }
        }

        private void AddEmployeeToLayout()
        {
            var employees = _controller.employeesModel.Query();

            if (employees == null || !employees.Any())
            {
                MessageBox.Show("Нет данных о сотрудниках");
                return;
            }

            EmployeesLayout.Controls.Clear();

            foreach (var employee in employees)
            {
                var nameButton = new Button
                {
                    Text = $"{employee.first_name} {employee.last_name}",
                    Width = 240,
                    Height = 60,
                    Tag = employee.id,
                    BackColor = Color.FromArgb(185, 209, 234)
                };
                nameButton.Click += (s, e) => ShowEmployeeDetails(employee.id);

                var deleteButton = new Button
                {
                    Text = "Удалить",
                    Width = 100,
                    Height = 60,
                    Enabled = _isAdmin,
                    Tag = employee.id
                };

                deleteButton.Click += (s, e) => DeleteEmployee(employee.id);

                EmployeesLayout.Controls.Add(nameButton);
                EmployeesLayout.Controls.Add(deleteButton);
            }
        }

        private void ShowEmployeeDetails(int employeeId)
        {
            using (var employeeForm = new InfoEmployeeForm(employeeId))
            {
                employeeForm.ShowDialog();
                LoadObjects();
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            if (MessageBox.Show("Удалить сотрудника?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var employee = _controller.employeesModel.Query()?
                        .FirstOrDefault(e => e.id == employeeId);

                    if (employee != null)
                    {
                        _controller.employeesModel.DeleteRecord(employee);
                        MessageBox.Show("Сотрудник удален");
                        LoadObjects();
                    }
                }
                catch (Exception ex)
                {  MessageBox.Show($"Ошибка удаления: {ex.Message}"); }
            }
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var form = new NewEmployeeForm(_userId, _username, _email, _password))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newEmployeeId = (int)form.Tag;
                    LoadObjects();
                    ShowEmployeeDetails(newEmployeeId);
                }
            }
        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {
            AddEmployeeToLayout();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
