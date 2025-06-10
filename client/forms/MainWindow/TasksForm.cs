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

            TaskLayout.AutoScroll = true;
            TaskLayout.HorizontalScroll.Enabled = false;

            try
            {
                var tasks = controller.tasksModel.Query();

                foreach (var obj in tasks)
                {
                    var objButton = new Button
                    {
                        Size = new Size(240, 30),
                        Text = $"{obj.Name}",
                        Tag = obj.Id,
                        BackColor = Color.FromArgb(185, 209, 234)
                    };
                    objButton.Click += (s, e) =>
                    {
                        var form = new InformationFormcs(obj.Id);
                        form.ShowDialog();
                        UpdateTasksLayout();
                    };
                    TaskLayout.Controls.Add(objButton);

                    var deleteButton = new Button
                    {
                        Size = new Size(75, 30),
                        Text = "Удалить",
                        Enabled = _isAdmin,
                        Tag = obj.Id,
                    };
                    deleteButton.Click += (s, e) => DeleteObject(obj.Id);
                    TaskLayout.Controls.Add(deleteButton);

                    if (_isAdmin)
                    {
                        MakeTaskButton.MouseEnter += (s, e) =>
                            MakeTaskButton.BackColor = Color.FromArgb(129, 155, 181);
                        MakeTaskButton.MouseLeave += (s, e) =>
                            MakeTaskButton.BackColor = Color.FromArgb(150, 175, 200);

                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки: {ex.Message}"); }
            finally
            {
                TaskLayout.ResumeLayout(true);
                TaskLayout.PerformLayout();
            }
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
