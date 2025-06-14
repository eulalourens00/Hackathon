namespace client.forms.MainWindow
{
    partial class NewDocumentatioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDocumentatioForm));
            label1 = new Label();
            NameTextBox = new TextBox();
            FilePathTextBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(89, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 14;
            label1.Text = "Документация";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 70);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Название";
            NameTextBox.Size = new Size(309, 27);
            NameTextBox.TabIndex = 15;
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(12, 126);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.PlaceholderText = "Путь к файлу";
            FilePathTextBox.Size = new Size(309, 27);
            FilePathTextBox.TabIndex = 17;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(173, 188);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonHighlight;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(12, 188);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(148, 32);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Выйти";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // NewDocumentatioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 242);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(FilePathTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "NewDocumentatioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewDocumentatioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private TextBox FilePathTextBox;
        private Button SaveButton;
        private Button CancelButton;
    }
}