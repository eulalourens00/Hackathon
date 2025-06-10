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
    public partial class TaskInformationForm : Form
    {
        private readonly int _taskId;
        private readonly bool _isAdmin;
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");
        public TaskInformationForm(int taskId)
        {
            InitializeComponent();
            _taskId = taskId;
            LoadTaskData();
        }

        private void LoadTaskData()
        {
            DBController tempController = null;
            try
            {
                tempController = new DBController(@"C:\Hackathon\dataBase.db");
                var task = tempController.tasksModel.Query().FirstOrDefault(t => t.Id == _taskId);
                if (task != null)
                {
                    nameBox.Text = task.Name;
                    linkBox.Text = task.Link;
                    EmployeeComboBox.Text = task.Username ?? "Не назначено";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных задачи: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {

        }
    }
}
