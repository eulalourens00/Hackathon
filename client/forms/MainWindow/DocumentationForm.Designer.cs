namespace client.forms.MainWindow
{
    partial class DocumentationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentationForm));
            collapsibleSidebar1 = new CollapsibleSidebar();
            label1 = new Label();
            EmployeesLayout = new TableLayoutPanel();
            SearchBox = new TextBox();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // collapsibleSidebar1
            // 
            collapsibleSidebar1.AutoSize = false;
            collapsibleSidebar1.BackColor = Color.FromArgb(50, 50, 50);
            collapsibleSidebar1.Dock = DockStyle.Left;
            collapsibleSidebar1.ForeColor = Color.White;
            collapsibleSidebar1.ImageScalingSize = new Size(20, 20);
            collapsibleSidebar1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            collapsibleSidebar1.Location = new Point(0, 0);
            collapsibleSidebar1.Name = "collapsibleSidebar1";
            collapsibleSidebar1.Size = new Size(62, 553);
            collapsibleSidebar1.TabIndex = 0;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 1;
            label1.Text = "Документация";
            // 
            // EmployeesLayout
            // 
            EmployeesLayout.AutoScroll = true;
            EmployeesLayout.BackColor = Color.Transparent;
            EmployeesLayout.ColumnCount = 2;
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            EmployeesLayout.Location = new Point(82, 55);
            EmployeesLayout.Name = "EmployeesLayout";
            EmployeesLayout.RowCount = 1;
            EmployeesLayout.RowStyles.Add(new RowStyle());
            EmployeesLayout.Size = new Size(433, 409);
            EmployeesLayout.TabIndex = 7;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(548, 55);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Поиск";
            SearchBox.Size = new Size(279, 27);
            SearchBox.TabIndex = 10;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(833, 53);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(37, 29);
            SearchButton.TabIndex = 11;
            SearchButton.Text = "🔍";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // DocumentationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(SearchButton);
            Controls.Add(SearchBox);
            Controls.Add(EmployeesLayout);
            Controls.Add(label1);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DocumentationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label label1;
        private TableLayoutPanel EmployeesLayout;
        private TextBox SearchBox;
        private Button SearchButton;
    }
}