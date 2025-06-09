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

            SaveButton.Enabled = _isAdmin;
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

                    if (_currentObject.object_type > 0)
                    {
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка загрузки данных: {ex.Message}"); }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!_isAdmin) return;

            try
            {
                _currentObject.name = NameBox.Text;
                _currentObject.number = int.Parse(NumberBox.Text);
                _currentObject.description = DescriptionBox.Text;
                _currentObject.location = LocationBox.Text;

                _controller.objectsModel.UpdateRecord(_currentObject);

                MessageBox.Show("Данные успешно сохранены");
                DialogResult = DialogResult.OK;
                Close();

                SetupControls();
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка сохранения: {ex.Message}"); }
        }

        private void EditObject_Click(object sender, EventArgs e)
        {
            NameBox.ReadOnly = false;
            NumberBox.ReadOnly = false;
            DescriptionBox.ReadOnly = false;
            LocationBox.ReadOnly = false;

            SaveButton.Enabled = true;

            ((Button)sender).Enabled = false;
        }
    }
}
