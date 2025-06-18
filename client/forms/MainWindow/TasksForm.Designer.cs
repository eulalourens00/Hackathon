namespace client.forms.MainWindow
{
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            collapsibleSidebar1 = new CollapsibleSidebar();
            label1 = new Label();
            MakeTaskButton = new Button();
            ShowAllTAsksButoon = new Button();
            TaskLayout = new TableLayoutPanel();
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
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 1;
            label1.Text = "Центр задач";
            // 
            // MakeTaskButton
            // 
            MakeTaskButton.BackColor = SystemColors.GradientActiveCaption;
            MakeTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MakeTaskButton.Location = new Point(394, 512);
            MakeTaskButton.Name = "MakeTaskButton";
            MakeTaskButton.Size = new Size(94, 29);
            MakeTaskButton.TabIndex = 2;
            MakeTaskButton.Text = "Создать";
            MakeTaskButton.UseVisualStyleBackColor = false;
            MakeTaskButton.Click += MakeTaskButton_Click;
            // 
            // ShowAllTAsksButoon
            // 
            ShowAllTAsksButoon.BackColor = Color.Silver;
            ShowAllTAsksButoon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowAllTAsksButoon.Location = new Point(80, 512);
            ShowAllTAsksButoon.Name = "ShowAllTAsksButoon";
            ShowAllTAsksButoon.Size = new Size(286, 29);
            ShowAllTAsksButoon.TabIndex = 3;
            ShowAllTAsksButoon.Text = "Все задачи";
            ShowAllTAsksButoon.UseVisualStyleBackColor = false;
            ShowAllTAsksButoon.Click += ShowAllTAsksButoon_Click;
            // 
            // TaskLayout
            // 
            TaskLayout.AutoScroll = true;
            TaskLayout.BackColor = Color.Transparent;
            TaskLayout.ColumnCount = 2;
            TaskLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TaskLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TaskLayout.Location = new Point(80, 67);
            TaskLayout.Name = "TaskLayout";
            TaskLayout.RowCount = 1;
            TaskLayout.RowStyles.Add(new RowStyle());
            TaskLayout.Size = new Size(433, 409);
            TaskLayout.TabIndex = 6;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(TaskLayout);
            Controls.Add(ShowAllTAsksButoon);
            Controls.Add(MakeTaskButton);
            Controls.Add(label1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TasksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label label1;
        private Button MakeTaskButton;
        private Button ShowAllTAsksButoon;
        private TableLayoutPanel TaskLayout;
    }
}