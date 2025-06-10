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
    public partial class TasksForm : Form
    {
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly bool _isAdmin;
        public TasksForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;

            LoadTasks();
        }
        private void LoadTasks()
        {
            try
            { UpdateTasksLayout(); }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки объектов: {ex.Message}"); }
        }
        private void UpdateTasksLayout()
        {
            TaskLayout.Controls.Clear();
            TaskLayout.SuspendLayout();

            try
            {
                var tasks = controller.GetTasksWithUsernames();

                foreach (var task in tasks)
                {
                    var taskPanel = new Panel { Width = TaskLayout.Width - 25, Height = 40 };

                    var objButton = new Button
                    {
                        Size = new Size(240, 30),
                        Text = $"{task.Name} ({task.Username ?? "нет исполнителя"})",
                        Tag = task.Id,
                        BackColor = Color.FromArgb(185, 209, 234),
                        Dock = DockStyle.Left
                    };
                    objButton.Click += (s, e) => OpenTaskDetails(task.Id);

                    var deleteButton = new Button
                    {
                        Size = new Size(75, 30),
                        Text = "Удалить",
                        Enabled = _isAdmin,
                        Tag = task.Id,
                        Dock = DockStyle.Right
                    };
                    deleteButton.Click += (s, e) => DeleteObject(task.Id);

                    taskPanel.Controls.Add(deleteButton);
                    taskPanel.Controls.Add(objButton);
                    TaskLayout.Controls.Add(taskPanel);
                }
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка обновления списка задач: {ex.Message}"); }
            finally
            {  TaskLayout.ResumeLayout(true); }

        }

        private void OpenTaskDetails(int taskId)
        {
            var form = new TaskInformationForm(taskId);
            form.ShowDialog();
            UpdateTasksLayout();
        }

        private void DeleteObject(int id)
        {
            if (MessageBox.Show("Удалить объект?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var tskToDelete = controller.tasksModel.Query().FirstOrDefault(o => o.Id == id);
                if (tskToDelete != null)
                {
                    controller.tasksModel.DeleteRecord(tskToDelete);
                    UpdateTasksLayout();
                }
            }
        }
        private void OnlyMyTasksCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MakeTaskButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (_isAdmin)
            {
                try
                {
                    using (NewTaskForm taskForm = new NewTaskForm(_isAdmin))
                    {
                        if (taskForm.ShowDialog() == DialogResult.OK && taskForm.NewTask != null)
                        {
                            var existing = controller.tasksModel.Query()
                                .FirstOrDefault(t => t.Name == taskForm.NewTask.Name);

                            if (existing == null)
                            {  controller.tasksModel.CreateRecord(taskForm.NewTask);}
                            else
                            {
                                MessageBox.Show("Задача с таким именем уже существует", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                finally
                {
                    this.Enabled = true;
                    UpdateTasksLayout();
                }
            }
        }

        private void ShowAllTAsksButoon_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }
    }
}
