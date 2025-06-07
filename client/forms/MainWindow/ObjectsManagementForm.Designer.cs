namespace client {
    partial class ObjectsManagementForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsManagementForm));
            TestLabel = new Label();
            MakeObject = new Button();
            collapsibleSidebar1 = new forms.MainWindow.CollapsibleSidebar();
            ObjectLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.BackColor = Color.Transparent;
            TestLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TestLabel.Location = new Point(75, 9);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(292, 32);
            TestLabel.TabIndex = 0;
            TestLabel.Text = "Управление объектами";
            // 
            // MakeObject
            // 
            MakeObject.BackColor = SystemColors.InactiveCaption;
            MakeObject.FlatAppearance.BorderColor = Color.Black;
            MakeObject.Font = new Font("Segoe UI", 9F);
            MakeObject.ForeColor = Color.Black;
            MakeObject.Location = new Point(616, 501);
            MakeObject.Name = "MakeObject";
            MakeObject.Size = new Size(102, 31);
            MakeObject.TabIndex = 3;
            MakeObject.Text = "Создать ";
            MakeObject.UseVisualStyleBackColor = false;
            MakeObject.Click += MakeObject_Click;
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
            collapsibleSidebar1.TabIndex = 4;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // ObjectLayout
            // 
            ObjectLayout.BackColor = Color.Transparent;
            ObjectLayout.ColumnCount = 2;
            ObjectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.15459F));
            ObjectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8454113F));
            ObjectLayout.Location = new Point(75, 51);
            ObjectLayout.Name = "ObjectLayout";
            ObjectLayout.RowCount = 1;
            ObjectLayout.RowStyles.Add(new RowStyle());
            ObjectLayout.Size = new Size(414, 409);
            ObjectLayout.TabIndex = 5;
            // 
            // ObjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(ObjectLayout);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(MakeObject);
            Controls.Add(TestLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "ObjectsManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TestLabel;
        private Button MakeObject;
        private forms.MainWindow.CollapsibleSidebar collapsibleSidebar1;
        private TableLayoutPanel ObjectLayout;
    }
}