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
        }

        private void LoadEmployeeComboBox()
        {
            try
            {
                EmployeeComboBox.Items.Clear();
                string dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

                using (var connection = new SQLiteConnection(dbPath))
                using (var command = new SQLiteCommand("SELECT id, name FROM users", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeComboBox.Items.Add(new ObjectTypeItem
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }

                EmployeeComboBox.DisplayMember = "Name";
                EmployeeComboBox.ValueMember = "Id";

                if (EmployeeComboBox.Items.Count > 0)
                { EmployeeComboBox.SelectedIndex = 0; }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}"); }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null) btn.Enabled = false;

            if (string.IsNullOrWhiteSpace(nameBox.Text) ||
                string.IsNullOrWhiteSpace(linkBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                if (btn != null) btn.Enabled = true;
                return;
            }

            try
            {
                var selectedType = (Tasks)EmployeeComboBox.SelectedItem;
                NewTask = new Tasks
                {
                    Name = nameBox.Text.Trim(),
                    Link = linkBox.Text.Trim(),
                    
                };

                var existing = controller.tasksModel.Query()
                    .FirstOrDefault(t => t.Name == NewTask.Name);

                if (existing != null)
                {
                    MessageBox.Show("Задача с таким именем уже существует.");
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            finally
            { if (btn != null) btn.Enabled = true; }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
