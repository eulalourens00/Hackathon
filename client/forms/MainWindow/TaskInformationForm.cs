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
    public partial class TaskInformationForm : Form
    {
        private readonly int _taskId;
        private readonly bool _isAdmin;
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");
        public TaskInformationForm(int taskId, bool isAdmin = false)
        {
            InitializeComponent();
            _taskId = taskId;
            _isAdmin = isAdmin;
            LoadTaskData();
        }

        private void LoadTaskData()
        {
            try
            {
                var task = controller.GetFullTaskInfo(_taskId);
                if (task != null)
                {
                    nameBox.Text = task.name;
                    linkBox.Text = task.link;

                    LoadEmployeeComboBox();

                    if (task.user_id > 0)
                    {
                        var employee = EmployeeComboBox.Items.Cast<EmployeeItem>()
                            .FirstOrDefault(e => e.id == task.user_id);
                        if (employee != null)
                        {  EmployeeComboBox.SelectedItem = employee; }
                    }
                    else { EmployeeComboBox.Text = "Не назначено";}
                }
            }
            catch (Exception ex) {  MessageBox.Show($"Ошибка загрузки данных задачи: {ex.Message}"); }
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
                                id = reader.GetInt32(0),
                                username = reader.GetString(1)
                            });
                        }
                    }
                }

                EmployeeComboBox.DisplayMember = "username";
                EmployeeComboBox.ValueMember = "id";
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}"); }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
