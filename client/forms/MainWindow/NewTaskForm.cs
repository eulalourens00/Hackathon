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
using static client.forms.MainWindow.NewObjectForm;
using SqliteDB;
using System.Data.SQLite;

namespace client.forms.MainWindow
{
    public partial class NewTaskForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Tasks NewTask { get; private set; }

        private readonly bool _isAdmin;
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");

        public NewTaskForm(bool isAdmin = false)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            LoadEmployeeComboBox();
        }

        private void LoadEmployeeComboBox()
        {
            try
            {
                EmployeeComboBox.Items.Clear();
                using (var connection = new SQLiteConnection(@"Data Source=C:\Hackathon\dataBase.db;Version=3;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT id, username FROM users", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeComboBox.Items.Add(new EmployeeItem
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1)
                            });
                        }
                    }
                }

                EmployeeComboBox.DisplayMember = "Username";
                EmployeeComboBox.ValueMember = "Id";

                if (EmployeeComboBox.Items.Count == 0)
                {
                    MessageBox.Show("Нет доступных сотрудников");
                    SaveButton.Enabled = false;
                }
                else
                {
                    EmployeeComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(linkBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (EmployeeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите исполнителя");
                return;
            }

            try
            {
                var selectedEmployee = (EmployeeItem)EmployeeComboBox.SelectedItem;
                NewTask = new Tasks
                {
                    Name = nameBox.Text.Trim(),
                    Link = linkBox.Text.Trim(),
                    User_Id = selectedEmployee.Id,
                    Username = selectedEmployee.Username
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания задачи: {ex.Message}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
    // хоба блин
    public class EmployeeItem
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
