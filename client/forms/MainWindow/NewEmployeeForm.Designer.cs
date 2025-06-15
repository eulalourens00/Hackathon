namespace client.forms.MainWindow
{
    partial class NewEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeForm));
            label1 = new Label();
            FnameBox = new TextBox();
            LnameBox = new TextBox();
            EmailBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            RoleComboBox = new ComboBox();
            PositionComboBox = new ComboBox();
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
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 12;
            label1.Text = "Новый сотрудник";
            // 
            // FnameBox
            // 
            FnameBox.Location = new Point(12, 57);
            FnameBox.Name = "FnameBox";
            FnameBox.PlaceholderText = "Имя";
            FnameBox.Size = new Size(309, 27);
            FnameBox.TabIndex = 13;
            // 
            // LnameBox
            // 
            LnameBox.Location = new Point(12, 102);
            LnameBox.Name = "LnameBox";
            LnameBox.PlaceholderText = "Фамилия";
            LnameBox.Size = new Size(309, 27);
            LnameBox.TabIndex = 14;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(12, 146);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(309, 27);
            EmailBox.TabIndex = 15;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(12, 250);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Логин";
            UsernameBox.Size = new Size(309, 27);
            UsernameBox.TabIndex = 17;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(12, 308);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Пароль";
            PasswordBox.Size = new Size(309, 27);
            PasswordBox.TabIndex = 18;
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(12, 197);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(141, 28);
            RoleComboBox.TabIndex = 19;
            // 
            // PositionComboBox
            // 
            PositionComboBox.FormattingEnabled = true;
            PositionComboBox.Location = new Point(180, 197);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new Size(141, 28);
            PositionComboBox.TabIndex = 20;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(173, 373);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonHighlight;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(12, 373);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(148, 32);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Выйти";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // NewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(PositionComboBox);
            Controls.Add(RoleComboBox);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(EmailBox);
            Controls.Add(LnameBox);
            Controls.Add(FnameBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FnameBox;
        private TextBox LnameBox;
        private TextBox EmailBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private ComboBox RoleComboBox;
        private ComboBox PositionComboBox;
        private Button SaveButton;
        private Button CancelButton;
    }
}