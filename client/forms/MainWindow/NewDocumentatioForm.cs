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
    public partial class NewDocumentatioForm : Form
    {
        private readonly int _objectId;
        private readonly DBController _controller;

        public NewDocumentatioForm(int objectId)
        {
            InitializeComponent();
            _objectId = objectId;
            _controller = new DBController(@"C:\Hackathon\dataBase.db");
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Filter = "Документы|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.xml|Все файлы|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FilePathTextBox.Text = openFile.FileName;
                    if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                    {
                        NameTextBox.Text = Path.GetFileNameWithoutExtension(openFile.FileName);
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(FilePathTextBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            try
            {
                string destPath = Path.Combine(@"C:\Hackathon\Documents",
                    $"{Guid.NewGuid()}{Path.GetExtension(FilePathTextBox.Text)}");

                Directory.CreateDirectory(Path.GetDirectoryName(destPath));
                File.Copy(FilePathTextBox.Text, destPath, true);

                var document = new Documents
                {
                    name = NameTextBox.Text,
                    link = destPath
                };

                if (_controller.AddDocumentToObject(document, _objectId))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {  MessageBox.Show($"Ошибка при добавлении документа: {ex.Message}"); }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
