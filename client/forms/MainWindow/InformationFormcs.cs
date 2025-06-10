using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Data.SQLite;
using static client.forms.MainWindow.NewObjectForm;

namespace client.forms.MainWindow
{
    public partial class InformationFormcs : Form
    {
        private readonly int _objectId;
        private readonly bool _isAdmin;
        private bool _isEditMode = false;
        private readonly DBController _controller;
        private Objects _currentObject;

        public InformationFormcs(int objectId, bool isAdmin = true)
        {
            InitializeComponent();

            _objectId = objectId;
            _isAdmin = isAdmin;
            _controller = new DBController(@"C:\Hackathon\dataBase.db");

            SetupControls();
            LoadObjectData();
        }

        private void SetupControls()
        {
            NameBox.ReadOnly = true;
            NumberBox.ReadOnly = true;
            DescriptionBox.ReadOnly = true;
            LocationBox.ReadOnly = true;

        }


        private void LoadObjectData()
        {
            try
            {
                _currentObject = _controller.objectsModel.Filter(_objectId);

                if (_currentObject != null)
                {
                    NameBox.Text = _currentObject.name;
                    NumberBox.Text = _currentObject.number.ToString();
                    DescriptionBox.Text = _currentObject.description;
                    LocationBox.Text = _currentObject.location;

                    LoadComboBoxData();

                    if (_currentObject.object_type > 0)
                    {
                        foreach (ObjectTypeItem item in ObjectTypecomboBox.Items)
                        {
                            if (item.Id == _currentObject.object_type)
                            {
                                ObjectTypecomboBox.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки данных: {ex.Message}"); }
        }
        private void EditObject_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                try
                {
                    NameBox.ReadOnly = false;
                    NumberBox.ReadOnly = false;
                    DescriptionBox.ReadOnly = false;
                    LocationBox.ReadOnly = false;

                    SaveButton.Enabled = true;
                    EditObject.Enabled = false;
                }
                finally
                {
                    _isEditMode = true;
                }
            }
            else { MessageBox.Show("Недоступно."); }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                try
                {
                    _currentObject.name = NameBox.Text;
                    _currentObject.number = int.Parse(NumberBox.Text);
                    _currentObject.description = DescriptionBox.Text;
                    _currentObject.location = LocationBox.Text;

                    _controller.objectsModel.UpdateRecord(_currentObject);

                    SetupControls();
                }
                finally
                {
                    _isEditMode = false;
                }
            }
            else { MessageBox.Show("Недоступно."); }
        }

        
        
        
        // для комбо бокса при инфв бланке (нью форма)
        private void LoadComboBoxData()
        {
            try
            {
                ObjectTypecomboBox.Items.Clear();
                string dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

                using (var connection = new SQLiteConnection(dbPath))
                using (var command = new SQLiteCommand("SELECT id, name FROM objects_types", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ObjectTypecomboBox.Items.Add(new ObjectTypeItem
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }

                ObjectTypecomboBox.DisplayMember = "Name";
                ObjectTypecomboBox.ValueMember = "Id";

                if (ObjectTypecomboBox.Items.Count > 0)
                { ObjectTypecomboBox.SelectedIndex = 0; }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки типов объектов: {ex.Message}"); }
        }
    }
}
