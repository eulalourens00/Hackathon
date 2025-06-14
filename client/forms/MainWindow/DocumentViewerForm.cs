using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace client.forms.MainWindow
{
    public partial class DocumentViewerForm : Form
    {
        private string _filePath;
        private readonly PdfiumViewer.PdfViewer pdfViewer;
        private readonly WebBrowser webBrowser;
        private readonly ToolStrip pdfToolbar;

        public DocumentViewerForm(int documentId)
        {
            InitializeComponent();
            pdfViewer = new PdfiumViewer.PdfViewer();
            webBrowser = new WebBrowser();
            pdfToolbar = AddPdfToolbar();

            pdfViewer.Dock = DockStyle.Fill;
            webBrowser.Dock = DockStyle.Fill;
            pdfViewer.Visible = false;
            webBrowser.Visible = false;

            Controls.Add(pdfToolbar);
            Controls.Add(pdfViewer);
            Controls.Add(webBrowser);

            var controller = new DBController(@"C:\Hackathon\dataBase.db");
            var doc = controller.GetDocumentById(documentId);

            if (doc == null || !File.Exists(doc.link))
            {
                MessageBox.Show("Документ не найден или файл отсутствует");
                Close();
                return;
            }

            _filePath = doc.link;
            Text = $"Документ: {doc.name}";
            LoadDocument();
        }

        private void LoadDocument()
        {
            if (!File.Exists(_filePath))
            {
                var result = MessageBox.Show("Файл не найден. Хотите указать новый путь?",
                                           "Ошибка",
                                           MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var dialog = new OpenFileDialog())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            _filePath = dialog.FileName;
                            LoadDocument();
                        }
                    }
                }
                Close();
                return;
            }

            try
            {
                string extension = Path.GetExtension(_filePath).ToLower();

                switch (extension)
                {
                    case ".pdf":
                        pdfToolbar.Visible = true;
                        pdfViewer.Visible = true;
                        pdfViewer.Document?.Dispose();
                        pdfViewer.Document = PdfiumViewer.PdfDocument.Load(_filePath);
                        break;

                    case ".xml":
                    case ".txt":
                        webBrowser.Visible = true;
                        webBrowser.Navigate(File.ReadAllText(_filePath));
                        break;

                    default:
                        webBrowser.Visible = true;
                        webBrowser.Navigate(_filePath);
                        break;
                }

                webBrowser.Navigated += (s, e) => {
                    if (webBrowser.DocumentText.Contains("404") || webBrowser.DocumentText.Contains("Error"))
                    {  MessageBox.Show("Не удалось загрузить документ"); }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия документа: {ex.Message}\n\nПопробуйте открыть файл вручную: {_filePath}");
                Close();
            }
        }

        private ToolStrip AddPdfToolbar()
        {
            var toolbar = new ToolStrip();
            var zoomIn = new ToolStripButton("+") { Tag = "zoomIn" };
            var zoomOut = new ToolStripButton("-") { Tag = "zoomOut" };

            //zoomIn.Click += (s, e) => pdfViewer.Zoom();
            //zoomOut.Click += (s, e) => pdfViewer.ZoomMode();

            toolbar.Items.Add(zoomIn);
            toolbar.Items.Add(zoomOut);
            toolbar.Dock = DockStyle.Top;
            toolbar.Visible = false;

            return toolbar;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            pdfViewer.Document?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
