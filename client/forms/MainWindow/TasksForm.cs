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
    public partial class TasksForm : Form
    {
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly bool _isAdmin;
        private readonly int _currentUserId;
        private readonly AuthService _authService;
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
                    var objButton = new Button
                    {
                        Size = new Size(240, 30),
                        Text = $"{task.name} ({task.username ?? "нет исполнителя"})",
                        Tag = task.id,
                        BackColor = Color.FromArgb(185, 209, 234)
                        
                    };
                    objButton.Click += (s, e) => OpenTaskDetails(task.id);

                    var deleteButton = new Button
                    {
                        Size = new Size(75, 30),
                        Text = "Удалить",
                        Enabled = _isAdmin,
                        Tag = task.id
                    };
                    deleteButton.Click += (s, e) => DeleteObject(task.id);

                    TaskLayout.Controls.Add(objButton);
                    TaskLayout.Controls.Add(deleteButton);
                    
                }
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка обновления списка задач: {ex.Message}"); }
            finally
            {  TaskLayout.ResumeLayout(true); }

        }

        private void OpenTaskDetails(int taskId)
        {
            var form = new TaskInformationForm(taskId, _isAdmin);
            form.ShowDialog();
            UpdateTasksLayout();
        }

        private void DeleteObject(int id)
        {
            if (MessageBox.Show("Удалить объект?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var tskToDelete = controller.tasksModel.Query().FirstOrDefault(o => o.id == id);
                if (tskToDelete != null)
                {
                    controller.tasksModel.DeleteRecord(tskToDelete);
                    UpdateTasksLayout();
                }
            }
        }
        private void OnlyMyTasksCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (OnlyMyTasksCheck.Checked)
                {
                    var myTasks = controller.GetTasksWithUsernames()
                .Where(task => task.user_id == _currentUserId)
                .ToList();
                    //UpdateFilteredObjectsLayout(myTasks);
                }
                else
                {
                    LoadTasks();
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка поиска: {ex.Message}"); }
        }

        //// для галочки, получаем айдишник 
        private int GetCurrentUserId() { return _currentUserId; }
        //private void UpdateFilteredObjectsLayout(List<Tasks> tasks)
        //{
        //    TaskLayout.Controls.Clear();
        //    TaskLayout.SuspendLayout();

        //    try
        //    {
        //        foreach (var task in tasks)
        //        {
        //            var objButton = new Button
        //            {
        //                Size = new Size(240, 30),
        //                Text = $"{task.name} ({task.username})",
        //                Tag = task.id,
        //                BackColor = Color.FromArgb(185, 209, 234)
        //            };
        //            objButton.Click += (s, e) => OpenTaskDetails(task.id);

        //            var deleteButton = new Button
        //            {
        //                Size = new Size(75, 30),
        //                Text = "Удалить",
        //                Enabled = _isAdmin,
        //                Tag = task.id
        //            };
        //            deleteButton.Click += (s, e) => DeleteObject(task.id);

        //            TaskLayout.Controls.Add(objButton);
        //            TaskLayout.Controls.Add(deleteButton);
        //        }
        //    }
        //    catch (Exception ex) { MessageBox.Show($"Ошибка загрузки: {ex.Message}"); }
        //    finally { TaskLayout.ResumeLayout(true); }
        //}

        private void MakeTaskButton_Click(object sender, EventArgs e)
        {
            if (!_isAdmin) return;
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
                                .FirstOrDefault(t => t.name == taskForm.NewTask.name);
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
            OnlyMyTasksCheck.Checked = false;
        }
    }
}
