namespace client.forms.MainWindow
{
    partial class InfoEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmployeeForm));
            label1 = new Label();
            FnameBox = new TextBox();
            LnameBox = new TextBox();
            EmailBox = new TextBox();
            RoleComboBox = new ComboBox();
            PositionComboBox = new ComboBox();
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 13;
            label1.Text = "Сотрудник";
            // 
            // FnameBox
            // 
            FnameBox.Location = new Point(12, 63);
            FnameBox.Name = "FnameBox";
            FnameBox.PlaceholderText = "Имя";
            FnameBox.Size = new Size(309, 27);
            FnameBox.TabIndex = 14;
            // 
            // LnameBox
            // 
            LnameBox.Location = new Point(12, 109);
            LnameBox.Name = "LnameBox";
            LnameBox.PlaceholderText = "Фамилия";
            LnameBox.Size = new Size(309, 27);
            LnameBox.TabIndex = 15;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(12, 156);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(309, 27);
            EmailBox.TabIndex = 16;
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(12, 206);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(141, 28);
            RoleComboBox.TabIndex = 20;
            // 
            // PositionComboBox
            // 
            PositionComboBox.FormattingEnabled = true;
            PositionComboBox.Location = new Point(180, 206);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new Size(141, 28);
            PositionComboBox.TabIndex = 21;
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(12, 262);
            LoginBox.Name = "LoginBox";
            LoginBox.PlaceholderText = "Логин";
            LoginBox.Size = new Size(309, 27);
            LoginBox.TabIndex = 22;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(12, 306);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Пароль";
            PasswordBox.Size = new Size(309, 27);
            PasswordBox.TabIndex = 23;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.ButtonHighlight;
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditButton.Location = new Point(12, 370);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(148, 32);
            EditButton.TabIndex = 24;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(173, 370);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 25;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(PositionComboBox);
            Controls.Add(RoleComboBox);
            Controls.Add(EmailBox);
            Controls.Add(LnameBox);
            Controls.Add(FnameBox);
            Controls.Add(label1);
            Name = "InfoEmployeeForm";
            Text = "InfoEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FnameBox;
        private TextBox LnameBox;
        private TextBox EmailBox;
        private ComboBox RoleComboBox;
        private ComboBox PositionComboBox;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button EditButton;
        private Button SaveButton;
    }
}