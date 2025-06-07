using client.forms.MainWindow;
using SqliteDB;

namespace client{
    public partial class ObjectsManagementForm : Form
    {
        private DBController controller = new DBController("dataBase.db");
        private readonly bool _isAdmin;
        public ObjectsManagementForm(bool isAdmin = false)
        {
            InitializeComponent();
            UpdateObjectsLayout();
            _isAdmin = isAdmin;
        }

        private void UpdateObjectsLayout()
        {
            ObjectLayout.Controls.Clear();
            List<Objects> objects = controller.objectsModel.Query();

            foreach (Objects obj in objects)
            {
                Button objButton = new Button
                {
                    Size = new Size(240, 30),
                    Text = obj.name + ", " + obj.number
                };
                ObjectLayout.Controls.Add(objButton);

                Button deleteButton = new Button
                {
                    Size = new Size(75, 30),
                    Text = "Delete"
                };

                deleteButton.Click += (s, e) =>
                {
                    ObjectLayout.Controls.Remove(objButton);
                    ObjectLayout.Controls.Remove(deleteButton);
                    controller.objectsModel.DeleteRecord(obj);
                };
                ObjectLayout.Controls.Add(deleteButton);
            }
        }

        private void MakeObject_Click(object sender, EventArgs e)
        {
            using (NewObjectForm objectForm = new NewObjectForm())
            {
                if (objectForm.ShowDialog() == DialogResult.OK)
                {
                    Objects newObject = objectForm.NewObject;
                    controller.objectsModel.CreateRecord(newObject);
                    UpdateObjectsLayout();
                }
            }
        }
    }
}
