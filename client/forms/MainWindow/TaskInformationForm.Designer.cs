namespace client.forms.MainWindow
{
    partial class TaskInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskInformationForm));
            label1 = new Label();
            nameBox = new TextBox();
            EmployeeComboBox = new ComboBox();
            linkBox = new TextBox();
            EditTaskButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 12;
            label1.Text = "Информационный бланк";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 68);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Заголовок";
            nameBox.Size = new Size(324, 27);
            nameBox.TabIndex = 13;
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Location = new Point(13, 127);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new Size(323, 28);
            EmployeeComboBox.TabIndex = 17;
            // 
            // linkBox
            // 
            linkBox.Location = new Point(13, 191);
            linkBox.Multiline = true;
            linkBox.Name = "linkBox";
            linkBox.PlaceholderText = "Ссылка на документ";
            linkBox.Size = new Size(323, 160);
            linkBox.TabIndex = 18;
            // 
            // EditTaskButton
            // 
            EditTaskButton.BackColor = Color.LightGray;
            EditTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditTaskButton.Location = new Point(13, 377);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(323, 32);
            EditTaskButton.TabIndex = 20;
            EditTaskButton.Text = "Выйти";
            EditTaskButton.UseVisualStyleBackColor = false;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // TaskInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(EditTaskButton);
            Controls.Add(linkBox);
            Controls.Add(EmployeeComboBox);
            Controls.Add(nameBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskInformationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private ComboBox EmployeeComboBox;
        private TextBox linkBox;
        private Button EditTaskButton;
    }
}