﻿using client.forms.MainWindow;
using SqliteDB;

namespace client{
    public partial class ObjectsManagementForm : Form
    {
        private DBController controller = new DBController("dataBase.db");
        private readonly bool _isAdmin;
        public ObjectsManagementForm(bool isAdmin = false)
        {
            InitializeComponent();
            LoadData();
            _isAdmin = isAdmin;
        }
        private void LoadData()
        {
            controller.objectsModel.CreateRecord(new Objects
            {
                object_type = 1,
                name = "Goida House",
                description = "Goida Description",
                location = "Goida Street",
                number = 1
            });
            List<Objects> objects = controller.objectsModel.Query();

            dataGridView1.DataSource = objects;
        }
    }
}
