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
            ObjectLayout = new TableLayoutPanel();
            DocumentsList = new ListView();
            ShowObjects = new Button();
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
            // ObjectLayout
            // 
            ObjectLayout.AutoScroll = true;
            ObjectLayout.BackColor = Color.Transparent;
            ObjectLayout.ColumnCount = 2;
            ObjectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            ObjectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ObjectLayout.Location = new Point(82, 55);
            ObjectLayout.Name = "ObjectLayout";
            ObjectLayout.RowCount = 1;
            ObjectLayout.RowStyles.Add(new RowStyle());
            ObjectLayout.Size = new Size(433, 409);
            ObjectLayout.TabIndex = 7;
            // 
            // DocumentsList
            // 
            DocumentsList.Location = new Point(548, 55);
            DocumentsList.Name = "DocumentsList";
            DocumentsList.Size = new Size(322, 409);
            DocumentsList.TabIndex = 12;
            DocumentsList.UseCompatibleStateImageBehavior = false;
            DocumentsList.DoubleClick += DocumentsList_DoubleClick;
            // 
            // ShowObjects
            // 
            ShowObjects.BackColor = SystemColors.GradientActiveCaption;
            ShowObjects.FlatAppearance.BorderColor = Color.Black;
            ShowObjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowObjects.ForeColor = Color.Black;
            ShowObjects.Location = new Point(82, 487);
            ShowObjects.Name = "ShowObjects";
            ShowObjects.Size = new Size(298, 31);
            ShowObjects.TabIndex = 13;
            ShowObjects.Text = "Показать объекты";
            ShowObjects.UseVisualStyleBackColor = false;
            ShowObjects.Click += ShowObjects_Click;
            // 
            // DocumentationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(ShowObjects);
            Controls.Add(DocumentsList);
            Controls.Add(ObjectLayout);
            Controls.Add(label1);
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
        private TableLayoutPanel ObjectLayout;
        private ListView DocumentsList;
        private Button ShowObjects;
    }
}