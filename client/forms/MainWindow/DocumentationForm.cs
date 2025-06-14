using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.forms.MainWindow
{
    public partial class DocumentationForm : Form
    {
        private DBController _controller = new DBController(@"C:\Hackathon\dataBase.db");
        private readonly bool _isAdmin;
        private int _selectedObjectId = -1;
        public DocumentationForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;

            SetupControls();
            LoadObjects();
        }
        private void SetupControls()
        {
            DocumentsList.View = View.Details;
            DocumentsList.Columns.Add("Документ", 200);
            DocumentsList.Columns.Add("Тип", 100);
            DocumentsList.FullRowSelect = true;

            var deleteButton = new Button
            {
                Text = "Удалить",
                Enabled = _isAdmin,
                Size = new Size(90, 30),
                Location = new Point(782, 487)
            };
            deleteButton.Click += DeleteDocument_Click;
            this.Controls.Add(deleteButton);
        }

        private void LoadObjects()
        {
            ObjectLayout.Controls.Clear();
            try
            {
                var objects = _controller.objectsModel.Query();
                foreach (var obj in objects)
                {
                    var objButton = new Button
                    {
                        Size = new Size(240, 30),
                        Text = $"{obj.name}, {obj.number}",
                        Tag = obj.id,
                        BackColor = Color.FromArgb(185, 209, 234)
                    };
                    objButton.Click += (s, e) => ShowDocumentsForObject(obj.id);

                    var addButton = new Button
                    {
                        Size = new Size(90, 30),
                        Text = "Добавить",
                        Enabled = _isAdmin,
                        Tag = obj.id,
                    };
                    addButton.Click += (s, e) => AddDocument(obj.id);

                    ObjectLayout.Controls.Add(objButton);
                    ObjectLayout.Controls.Add(addButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки объектов: {ex.Message}");
            }
        }

        private void ShowDocumentsForObject(int objectId)
        {
            _selectedObjectId = objectId;
            DocumentsList.Items.Clear();

            try
            {
                var documents = _controller.GetDocumentsForObject(objectId);
                foreach (var doc in documents)
                {
                    var item = new ListViewItem(doc.name);
                    item.SubItems.Add(Path.GetExtension(doc.link).ToUpper());
                    item.Tag = doc.id;
                    DocumentsList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки документов: {ex.Message}");
            }
        }

        private void AddDocument(int objectId)
        {
            var addForm = new NewDocumentatioForm(objectId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                ShowDocumentsForObject(objectId);
            }
        }

        private void DocumentsList_DoubleClick(object sender, EventArgs e)
        {
            if (DocumentsList.SelectedItems.Count == 0) return;

            int docId = (int)DocumentsList.SelectedItems[0].Tag;

            try
            {
                var doc = _controller.GetDocumentById(docId);

                if (doc == null)
                {
                    MessageBox.Show("Документ не найден в базе данных");
                    return;
                }

                if (!File.Exists(doc.link))
                {
                    MessageBox.Show($"Файл не найден по пути: {doc.link}");
                    return;
                }

                var ext = Path.GetExtension(doc.link).ToLower();

                if (ext == ".pdf")
                {
                    var viewer = new DocumentViewerForm(docId);
                    viewer.ShowDialog();
                }
                else
                { Process.Start(new ProcessStartInfo(doc.link) { UseShellExecute = true }); }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка при открытии документа: {ex.Message}"); }
        }
        private void DeleteDocument_Click(object sender, EventArgs e)
        {
            if (DocumentsList.SelectedItems.Count == 0) return;

            if (MessageBox.Show("Удалить документ?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int docId = (int)DocumentsList.SelectedItems[0].Tag;
                if (_controller.DeleteDocument(docId))
                {
                    ShowDocumentsForObject(_selectedObjectId);
                }
                else
                {  MessageBox.Show("Не удалось удалить документ"); }
            }
        }

        private void ShowObjects_Click(object sender, EventArgs e)
        {
            LoadObjects();
        }
    }
}
