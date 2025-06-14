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
    public partial class EmployeesForm : Form
    {
        private readonly bool _isAdmin;
        private readonly DBController _controller = new DBController(@"C:\Hackathon\dataBase.db");

        public EmployeesForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;

            if (_controller?.employeesModel == null)
            {
                MessageBox.Show("Ошибка инициализации модели сотрудников");
                this.Close();
                return;
            }

            LoadObjects();
        }

        private void LoadObjects()
        {
            try
            {
              AddEmployeeToLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
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
                    Width = 200,
                    Tag = employee.id,
                    BackColor = Color.FromArgb(185, 209, 234)
                };
                nameButton.Click += (s, e) => ShowEmployeeDetails(employee.id);

                var deleteButton = new Button
                {
                    Text = "Удалить",
                    Width = 80,
                    Enabled = _isAdmin,
                    Tag = employee.id
                };

                deleteButton.Click += (s, e) => DeleteEmployee(employee.id);

                EmployeesLayout.Controls.Add(deleteButton);
                EmployeesLayout.Controls.Add(nameButton);
            }
        }

        private void ShowEmployeeDetails(int employeeId)
        {
            using (var form = new InfoEmployeeForm(employeeId))
            {
                form.ShowDialog();
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
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
