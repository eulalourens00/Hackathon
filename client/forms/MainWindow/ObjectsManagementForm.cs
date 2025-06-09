using client.forms.MainWindow;
using SqliteDB;

namespace client{
    public partial class ObjectsManagementForm : Form
    {
        private DBController controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly bool _isAdmin;
        public ObjectsManagementForm(bool isAdmin = false)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            MakeObject.Enabled = _isAdmin;

            LoadObjects();
        }
        private void LoadObjects()
        {
            try
            { UpdateObjectsLayout(); }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки объектов: {ex.Message}"); }
        }
        private void UpdateObjectsLayout()
        {
            ObjectLayout.Controls.Clear();
            ObjectLayout.SuspendLayout();
            
            ObjectLayout.AutoScroll = true;
            ObjectLayout.HorizontalScroll.Enabled = false;

            try
            {
                var objects = controller.objectsModel.Query();

                foreach (var obj in objects)
                {
                    var objButton = new Button
                    {
                        Size = new Size(240, 30),
                        Text = $"{obj.name}, {obj.number}",
                        Tag = obj.id,
                        BackColor = Color.FromArgb(185, 209, 234)
                    };
                    objButton.Click += (s, e) =>
                    {
                        var form = new InformationFormcs(obj.id);
                        form.ShowDialog();
                        UpdateObjectsLayout();
                    };
                    ObjectLayout.Controls.Add(objButton);

                    var deleteButton = new Button
                    {
                        Size = new Size(75, 30),
                        Text = "Удалить",
                        Enabled = _isAdmin,
                        Tag = obj.id,
                    };
                    deleteButton.Click += (s, e) => DeleteObject(obj.id);
                    ObjectLayout.Controls.Add(deleteButton);

                    if (_isAdmin)
                    {
                        MakeObject.MouseEnter += (s, e) =>
                            MakeObject.BackColor = Color.FromArgb(129, 155, 181);
                        MakeObject.MouseLeave += (s, e) =>
                            MakeObject.BackColor = Color.FromArgb(150, 175, 200);

                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки: {ex.Message}"); }
            finally
            {
                ObjectLayout.ResumeLayout(true);
                ObjectLayout.PerformLayout();
            }
        }
        
        private void DeleteObject(int id)
        {
            if (MessageBox.Show("Удалить объект?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var objToDelete = controller.objectsModel.Query().FirstOrDefault(o => o.id == id);
                if (objToDelete != null)
                {
                    controller.objectsModel.DeleteRecord(objToDelete);
                    UpdateObjectsLayout();
                }
            }
        }
        private void MakeObject_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (_isAdmin)
            {
                try
                {
                    using (NewObjectForm objectForm = new NewObjectForm())
                    {
                        if (objectForm.ShowDialog() == DialogResult.OK)
                        {
                            var existing = controller.objectsModel.Query()
                            .FirstOrDefault(o => o.name == objectForm.NewObject.name &&
                                               o.number == objectForm.NewObject.number);

                            if (existing == null)
                            { controller.objectsModel.CreateRecord(objectForm.NewObject); }
                        }
                    }
                }
                finally
                {
                    this.Enabled = true;
                    UpdateObjectsLayout();
                }
            }
            
        }

        private void ShowObjects_Click(object sender, EventArgs e)
        {
            LoadObjects();
        }
    }
}
