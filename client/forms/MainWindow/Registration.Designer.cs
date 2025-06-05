namespace client.forms.MainWindow
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            LoginReg = new TextBox();
            PasswordReg = new TextBox();
            RepPasswordReg = new TextBox();
            EmailReg = new TextBox();
            regbutton = new Button();
            existuserlink = new LinkLabel();
            showPassword = new Button();
            showRepPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 105);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(722, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 106);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(54, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 106);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(171, 120);
            label1.Name = "label1";
            label1.Size = new Size(525, 20);
            label1.TabIndex = 7;
            label1.Text = "______________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(272, 145);
            label5.Name = "label5";
            label5.Size = new Size(309, 41);
            label5.TabIndex = 14;
            label5.Text = "Добро пожаловать!";
            // 
            // LoginReg
            // 
            LoginReg.BackColor = Color.FromArgb(224, 216, 208);
            LoginReg.Location = new Point(307, 253);
            LoginReg.Name = "LoginReg";
            LoginReg.PlaceholderText = "Логин";
            LoginReg.Size = new Size(214, 27);
            LoginReg.TabIndex = 15;
            // 
            // PasswordReg
            // 
            PasswordReg.BackColor = Color.FromArgb(224, 216, 208);
            PasswordReg.Location = new Point(307, 300);
            PasswordReg.Name = "PasswordReg";
            PasswordReg.PasswordChar = '*';
            PasswordReg.PlaceholderText = "Пароль";
            PasswordReg.Size = new Size(214, 27);
            PasswordReg.TabIndex = 16;
            PasswordReg.UseSystemPasswordChar = true;
            // 
            // RepPasswordReg
            // 
            RepPasswordReg.BackColor = Color.FromArgb(224, 216, 208);
            RepPasswordReg.Location = new Point(307, 350);
            RepPasswordReg.Name = "RepPasswordReg";
            RepPasswordReg.PasswordChar = '*';
            RepPasswordReg.PlaceholderText = "Подтвердите пароль";
            RepPasswordReg.Size = new Size(214, 27);
            RepPasswordReg.TabIndex = 17;
            RepPasswordReg.UseSystemPasswordChar = true;
            // 
            // EmailReg
            // 
            EmailReg.BackColor = Color.FromArgb(224, 216, 208);
            EmailReg.Location = new Point(307, 207);
            EmailReg.Name = "EmailReg";
            EmailReg.PlaceholderText = "Email";
            EmailReg.Size = new Size(214, 27);
            EmailReg.TabIndex = 18;
            // 
            // regbutton
            // 
            regbutton.BackColor = Color.FromArgb(199, 44, 65);
            regbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            regbutton.ForeColor = Color.White;
            regbutton.Location = new Point(307, 409);
            regbutton.Name = "regbutton";
            regbutton.Size = new Size(214, 38);
            regbutton.TabIndex = 19;
            regbutton.Text = "Создать";
            regbutton.UseVisualStyleBackColor = false;
            regbutton.Click += regbutton_Click;
            // 
            // existuserlink
            // 
            existuserlink.ActiveLinkColor = Color.CornflowerBlue;
            existuserlink.AutoSize = true;
            existuserlink.BackColor = Color.Transparent;
            existuserlink.Cursor = Cursors.Hand;
            existuserlink.LinkColor = Color.FromArgb(119, 119, 119);
            existuserlink.Location = new Point(327, 450);
            existuserlink.Name = "existuserlink";
            existuserlink.Size = new Size(176, 20);
            existuserlink.TabIndex = 20;
            existuserlink.TabStop = true;
            existuserlink.Text = "Я являюсь сотрудником";
            existuserlink.LinkClicked += existuserlink_LinkClicked;
            // 
            // showPassword
            // 
            showPassword.BackColor = Color.FromArgb(224, 216, 208);
            showPassword.BackgroundImageLayout = ImageLayout.Zoom;
            showPassword.FlatAppearance.BorderColor = Color.Red;
            showPassword.FlatAppearance.BorderSize = 0;
            showPassword.FlatStyle = FlatStyle.System;
            showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showPassword.ForeColor = Color.Transparent;
            showPassword.Location = new Point(496, 301);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(23, 25);
            showPassword.TabIndex = 22;
            showPassword.Text = "👁️";
            showPassword.UseVisualStyleBackColor = false;
            showPassword.Click += showPassword_Click;
            // 
            // showRepPassword
            // 
            showRepPassword.BackColor = Color.FromArgb(224, 216, 208);
            showRepPassword.BackgroundImageLayout = ImageLayout.Zoom;
            showRepPassword.FlatAppearance.BorderColor = Color.Red;
            showRepPassword.FlatAppearance.BorderSize = 0;
            showRepPassword.FlatStyle = FlatStyle.System;
            showRepPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showRepPassword.ForeColor = Color.Transparent;
            showRepPassword.Location = new Point(496, 351);
            showRepPassword.Name = "showRepPassword";
            showRepPassword.Size = new Size(23, 25);
            showRepPassword.TabIndex = 23;
            showRepPassword.Text = "👁️";
            showRepPassword.UseVisualStyleBackColor = false;
            showRepPassword.Click += showRepPassword_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(showRepPassword);
            Controls.Add(showPassword);
            Controls.Add(existuserlink);
            Controls.Add(regbutton);
            Controls.Add(EmailReg);
            Controls.Add(RepPasswordReg);
            Controls.Add(PasswordReg);
            Controls.Add(LoginReg);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label5;
        private TextBox LoginReg;
        private TextBox PasswordReg;
        private TextBox RepPasswordReg;
        private TextBox EmailReg;
        private Button regbutton;
        private LinkLabel existuserlink;
        private Button showPassword;
        private Button showRepPassword;
    }
}