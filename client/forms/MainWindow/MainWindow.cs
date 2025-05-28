using client.forms.MainWindow;
using SqliteDB;

namespace client {
    public partial class MainWindow : Form
    {
        private DBController controller = new DBController("dataBase.db");
        public MainWindow()
        {
            InitializeComponent();
            SetupUI();
            LoadData();

            
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
        private void TestLabel_Click(object sender, EventArgs e)
        {

        }

        private void SetupUI()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "ОБЪЕКТЫ";

            this.BackgroundImage = Image.FromFile(@"C:\Hackathon\images\bck_1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            CollapsibleSidebar sidebar = new CollapsibleSidebar
            {
                Parent = this,
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White
            };

            sidebar.MenuItemClicked += (menuItem) =>
            {
                if (menuItem == "Выход")
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"В работе"); // ДОДЕЛАТЬ
                }
            };

            var toggleButton = new ToolStripButton
            {
                Text = "≡",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Alignment = ToolStripItemAlignment.Left,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White
            };
            toggleButton.Click += (s, e) => sidebar.ToggleSidebar();
            sidebar.Items.Insert(0, toggleButton);

            var contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Parent = this
            };
            contentPanel.BringToFront();

            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                Parent = contentPanel
            };
        }
    }
}
