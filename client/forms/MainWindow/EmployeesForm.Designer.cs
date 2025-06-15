namespace client.forms.MainWindow
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            collapsibleSidebar1 = new CollapsibleSidebar();
            label1 = new Label();
            EmployeesLayout = new TableLayoutPanel();
            ShowEmployees = new Button();
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
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 1;
            label1.Text = "Сотрудники";
            // 
            // EmployeesLayout
            // 
            EmployeesLayout.AutoScroll = true;
            EmployeesLayout.BackColor = Color.Transparent;
            EmployeesLayout.ColumnCount = 2;
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            EmployeesLayout.Location = new Point(78, 54);
            EmployeesLayout.Name = "EmployeesLayout";
            EmployeesLayout.RowCount = 1;
            EmployeesLayout.RowStyles.Add(new RowStyle());
            EmployeesLayout.Size = new Size(433, 409);
            EmployeesLayout.TabIndex = 6;
            // 
            // ShowEmployees
            // 
            ShowEmployees.BackColor = SystemColors.GradientActiveCaption;
            ShowEmployees.FlatAppearance.BorderColor = Color.Black;
            ShowEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowEmployees.ForeColor = Color.Black;
            ShowEmployees.Location = new Point(78, 495);
            ShowEmployees.Name = "ShowEmployees";
            ShowEmployees.Size = new Size(315, 31);
            ShowEmployees.TabIndex = 8;
            ShowEmployees.Text = "Показать сотрудников";
            ShowEmployees.UseVisualStyleBackColor = false;
            ShowEmployees.Click += ShowEmployees_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(ShowEmployees);
            Controls.Add(EmployeesLayout);
            Controls.Add(label1);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label label1;
        private TableLayoutPanel EmployeesLayout;
        private Button ShowEmployees;
    }
}