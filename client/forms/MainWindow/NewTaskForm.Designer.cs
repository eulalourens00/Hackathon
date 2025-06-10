namespace client.forms.MainWindow
{
    partial class NewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaskForm));
            label1 = new Label();
            nameBox = new TextBox();
            linkBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            EmployeeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 11;
            label1.Text = "Новое задание";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 70);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Заголовок";
            nameBox.Size = new Size(309, 27);
            nameBox.TabIndex = 12;
            // 
            // linkBox
            // 
            linkBox.Location = new Point(12, 177);
            linkBox.Multiline = true;
            linkBox.Name = "linkBox";
            linkBox.PlaceholderText = "Ссылка на документ";
            linkBox.Size = new Size(309, 160);
            linkBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(173, 376);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonHighlight;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(12, 376);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(148, 32);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Выйти";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Location = new Point(13, 127);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new Size(308, 28);
            EmployeeComboBox.TabIndex = 16;
            // 
            // NewTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(EmployeeComboBox);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(linkBox);
            Controls.Add(nameBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private TextBox linkBox;
        private Button SaveButton;
        private Button CancelButton;
        private ComboBox EmployeeComboBox;
    }
}