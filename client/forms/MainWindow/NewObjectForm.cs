using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;
using SqliteDB;

namespace client.forms.MainWindow
{
    public partial class NewObjectForm : Form
    {
        public class ObjectTypeItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Objects NewObject { get; private set; }

        private readonly DBController controller;

        public NewObjectForm()
        {
            InitializeComponent();
            controller = new DBController(@"C:\Hackathon\dataBase.db");
            LoadComboBoxData();
        }

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
                    ObjectTypecomboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка загрузки типов объектов: {ex.Message}");}
        }

        private void EndMakeObject_Click(object sender, EventArgs e)
        {
            if (ObjectTypecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип объекта.");
                return;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(LocationBox.Text) ||
                string.IsNullOrWhiteSpace(NumberBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            if (!int.TryParse(NumberBox.Text, out int number))
            {
                MessageBox.Show("Некорректный номер.");
                return;
            }

            try
            {
                var selectedType = (ObjectTypeItem)ObjectTypecomboBox.SelectedItem;

                NewObject = new Objects
                {
                    name = NameBox.Text.Trim(),
                    object_type = selectedType.Id,
                    description = DescriptionBox.Text?.Trim() ?? "",
                    location = LocationBox.Text.Trim(),
                    number = number
                };

                controller.objectsModel.CreateRecord(NewObject);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SQLiteException ex) when (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
            { MessageBox.Show("Ошибка: нарушение ограничений базы данных. Проверьте введенные данные."); }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка при создании объекта: {ex.Message}");}
        }

        private void CancelObject_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}