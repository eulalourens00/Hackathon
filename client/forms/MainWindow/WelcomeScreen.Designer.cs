namespace client.forms.MainWindow
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginbutton = new Button();
            label2 = new Label();
            label3 = new Label();
            Login = new TextBox();
            Password = new TextBox();
            forgotpassword = new LinkLabel();
            newuserlink = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            showPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(160, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 105);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(199, 131);
            label1.Name = "label1";
            label1.Size = new Size(525, 20);
            label1.TabIndex = 2;
            label1.Text = "______________________________________________________________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(44, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 106);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(751, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 106);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(199, 44, 65);
            loginbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginbutton.ForeColor = Color.White;
            loginbutton.Location = new Point(302, 394);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(214, 38);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Войти";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(236, 203);
            label2.Name = "label2";
            label2.Size = new Size(363, 28);
            label2.TabIndex = 6;
            label2.Text = "Для начала работы войдите в систему";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 211);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(224, 216, 208);
            Login.Location = new Point(302, 252);
            Login.Name = "Login";
            Login.PlaceholderText = "Логин";
            Login.Size = new Size(214, 27);
            Login.TabIndex = 8;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 216, 208);
            Password.Location = new Point(302, 317);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Пароль";
            Password.Size = new Size(214, 27);
            Password.TabIndex = 9;
            Password.UseSystemPasswordChar = true;
            // 
            // forgotpassword
            // 
            forgotpassword.ActiveLinkColor = Color.CornflowerBlue;
            forgotpassword.AutoSize = true;
            forgotpassword.BackColor = Color.Transparent;
            forgotpassword.Cursor = Cursors.Hand;
            forgotpassword.LinkColor = Color.FromArgb(119, 119, 119);
            forgotpassword.Location = new Point(397, 347);
            forgotpassword.Name = "forgotpassword";
            forgotpassword.Size = new Size(124, 20);
            forgotpassword.TabIndex = 10;
            forgotpassword.TabStop = true;
            forgotpassword.Text = "Забыли пароль?";
            forgotpassword.LinkClicked += forgotpassword_LinkClicked;
            // 
            // newuserlink
            // 
            newuserlink.ActiveLinkColor = Color.CornflowerBlue;
            newuserlink.AutoSize = true;
            newuserlink.BackColor = Color.Transparent;
            newuserlink.Cursor = Cursors.Hand;
            newuserlink.LinkColor = Color.FromArgb(119, 119, 119);
            newuserlink.Location = new Point(342, 435);
            newuserlink.Name = "newuserlink";
            newuserlink.Size = new Size(143, 20);
            newuserlink.TabIndex = 11;
            newuserlink.TabStop = true;
            newuserlink.Text = "Я новый сотрудник";
            newuserlink.LinkClicked += newuserlink_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(397, 211);
            label4.Name = "label4";
            label4.Size = new Size(0, 38);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(271, 151);
            label5.Name = "label5";
            label5.Size = new Size(309, 41);
            label5.TabIndex = 13;
            label5.Text = "Добро пожаловать!";
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
            showPassword.Location = new Point(492, 318);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(23, 25);
            showPassword.TabIndex = 23;
            showPassword.Text = "👁️";
            showPassword.UseVisualStyleBackColor = false;
            showPassword.Click += showPassword_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(showPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(newuserlink);
            Controls.Add(forgotpassword);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginbutton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginbutton;
        private Label label2;
        private Label label3;
        private TextBox Login;
        private TextBox Password;
        private LinkLabel forgotpassword;
        private LinkLabel newuserlink;
        private Label label4;
        private Label label5;
        private Button showPassword;
    }
}