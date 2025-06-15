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
using SqliteDB;
using System.Data.SQLite;

namespace client.forms.MainWindow
{
    public partial class NewEmployeeForm : Form
    {
        private readonly DBController _controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly int _userId;
        private readonly string _username;
        private readonly string _email;

        public NewEmployeeForm(int userId, string username, string email, string password)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            _email = email;

            LoadRolesAndPositions();
            SetupControls(password);
        }

        private void SetupControls(string password)
        {
            UsernameBox.Text = _username;
            EmailBox.Text = _email;

            PasswordBox.PasswordChar = '*';
            PasswordBox.Text = password;
            PasswordBox.ReadOnly = true;

            UsernameBox.ReadOnly = true;
            EmailBox.ReadOnly = true;
        }

        private void LoadRolesAndPositions()
        {
            try
            {
                string dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

                RoleComboBox.Items.Clear();
                using (var connection = new SQLiteConnection(dbPath))
                using (var command = new SQLiteCommand("SELECT id, name FROM roles", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleComboBox.Items.Add(new RoleItem
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }

                RoleComboBox.DisplayMember = "Name";
                RoleComboBox.ValueMember = "Id";

                PositionComboBox.Items.Clear();
                using (var connection = new SQLiteConnection(dbPath))
                using (var command = new SQLiteCommand("SELECT id, name FROM positions", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PositionComboBox.Items.Add(new PositionItem
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }

                PositionComboBox.DisplayMember = "Name";
                PositionComboBox.ValueMember = "Id";

                if (RoleComboBox.Items.Count > 0)
                    RoleComboBox.SelectedIndex = 0;

                if (PositionComboBox.Items.Count > 0)
                    PositionComboBox.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка загрузки данных: {ex.Message}"); }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FnameBox.Text) ||  string.IsNullOrWhiteSpace(LnameBox.Text))
            {  MessageBox.Show("Заполните все обязательные поля");  return; }

            try
            {
                if (RoleComboBox.SelectedItem == null || PositionComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите роль и должность");
                    return;
                }

                var newEmployee = new Employees
                {
                    first_name = FnameBox.Text,
                    last_name = LnameBox.Text,
                    role_id = ((RoleItem)RoleComboBox.SelectedItem).Id,
                    position_id = ((PositionItem)PositionComboBox.SelectedItem).Id
                };

                int success = _controller.AddEmployee(newEmployee, _userId);

                if (success > 0)
                {
                    MessageBox.Show("Сотрудник успешно добавлен");
                    this.DialogResult = DialogResult.OK;
                    this.Tag = success;
                    this.Close();
                }
                else
                {  MessageBox.Show("Не удалось добавить сотрудника");}
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка при сохранении: {ex.Message}\n\n{ex.StackTrace}");}
        }
    }
    public class RoleItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PositionItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
