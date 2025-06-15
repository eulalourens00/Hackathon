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
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            EditButton = new Button();
            RoleBox = new TextBox();
            PositionBox = new TextBox();
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
            EditButton.BackColor = Color.Silver;
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditButton.Location = new Point(14, 368);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(309, 32);
            EditButton.TabIndex = 24;
            EditButton.Text = "Выйти";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // RoleBox
            // 
            RoleBox.Location = new Point(12, 212);
            RoleBox.Name = "RoleBox";
            RoleBox.PlaceholderText = "Роль";
            RoleBox.Size = new Size(148, 27);
            RoleBox.TabIndex = 26;
            // 
            // PositionBox
            // 
            PositionBox.Location = new Point(173, 212);
            PositionBox.Name = "PositionBox";
            PositionBox.PlaceholderText = "Должность";
            PositionBox.Size = new Size(148, 27);
            PositionBox.TabIndex = 27;
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(335, 412);
            Controls.Add(PositionBox);
            Controls.Add(RoleBox);
            Controls.Add(EditButton);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(EmailBox);
            Controls.Add(LnameBox);
            Controls.Add(FnameBox);
            Controls.Add(label1);
            Name = "InfoEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FnameBox;
        private TextBox LnameBox;
        private TextBox EmailBox;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button EditButton;
        private TextBox RoleBox;
        private TextBox PositionBox;
    }
}