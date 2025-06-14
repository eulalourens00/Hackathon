namespace client.forms.MainWindow
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            collapsibleSidebar1 = new CollapsibleSidebar();
            avatarPictureBox = new PictureBox();
            ChangeAvaLik = new LinkLabel();
            label1 = new Label();
            FN_box = new TextBox();
            LN_box = new TextBox();
            RoleBox = new TextBox();
            PositionBox = new TextBox();
            AdminSMS = new Button();
            InfoButton = new Button();
            EmailBox = new TextBox();
            UsernameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
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
            // avatarPictureBox
            // 
            avatarPictureBox.Location = new Point(89, 55);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(207, 197);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 1;
            avatarPictureBox.TabStop = false;
            // 
            // ChangeAvaLik
            // 
            ChangeAvaLik.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            ChangeAvaLik.AutoSize = true;
            ChangeAvaLik.BackColor = Color.Transparent;
            ChangeAvaLik.LinkColor = Color.Gray;
            ChangeAvaLik.Location = new Point(107, 255);
            ChangeAvaLik.Name = "ChangeAvaLik";
            ChangeAvaLik.Size = new Size(178, 20);
            ChangeAvaLik.TabIndex = 2;
            ChangeAvaLik.TabStop = true;
            ChangeAvaLik.Text = "Изменить изображение";
            ChangeAvaLik.LinkClicked += ChangeAvaLik_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 3;
            label1.Text = "Личный кабинет";
            // 
            // FN_box
            // 
            FN_box.BackColor = Color.Lavender;
            FN_box.Location = new Point(454, 55);
            FN_box.Name = "FN_box";
            FN_box.Size = new Size(305, 27);
            FN_box.TabIndex = 4;
            // 
            // LN_box
            // 
            LN_box.BackColor = Color.Lavender;
            LN_box.Location = new Point(454, 106);
            LN_box.Name = "LN_box";
            LN_box.Size = new Size(305, 27);
            LN_box.TabIndex = 5;
            // 
            // RoleBox
            // 
            RoleBox.BackColor = Color.Lavender;
            RoleBox.Location = new Point(454, 270);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(305, 27);
            RoleBox.TabIndex = 7;
            // 
            // PositionBox
            // 
            PositionBox.BackColor = Color.Lavender;
            PositionBox.Location = new Point(454, 328);
            PositionBox.Name = "PositionBox";
            PositionBox.Size = new Size(305, 27);
            PositionBox.TabIndex = 8;
            // 
            // AdminSMS
            // 
            AdminSMS.BackColor = Color.Silver;
            AdminSMS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdminSMS.Location = new Point(454, 512);
            AdminSMS.Name = "AdminSMS";
            AdminSMS.Size = new Size(305, 29);
            AdminSMS.TabIndex = 9;
            AdminSMS.Text = "Обратиться в администрацию";
            AdminSMS.UseVisualStyleBackColor = false;
            AdminSMS.Click += AdminSMS_Click;
            // 
            // InfoButton
            // 
            InfoButton.BackColor = Color.Silver;
            InfoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InfoButton.Location = new Point(107, 512);
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(174, 29);
            InfoButton.TabIndex = 10;
            InfoButton.Text = "Информация";
            InfoButton.UseVisualStyleBackColor = false;
            InfoButton.Click += InfoButton_Click;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.Lavender;
            EmailBox.Location = new Point(454, 215);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(305, 27);
            EmailBox.TabIndex = 11;
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.Lavender;
            UsernameBox.Location = new Point(454, 161);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(305, 27);
            UsernameBox.TabIndex = 12;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(UsernameBox);
            Controls.Add(EmailBox);
            Controls.Add(InfoButton);
            Controls.Add(AdminSMS);
            Controls.Add(PositionBox);
            Controls.Add(RoleBox);
            Controls.Add(LN_box);
            Controls.Add(FN_box);
            Controls.Add(label1);
            Controls.Add(ChangeAvaLik);
            Controls.Add(avatarPictureBox);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private PictureBox avatarPictureBox;
        private LinkLabel ChangeAvaLik;
        private Label label1;
        private TextBox FN_box;
        private TextBox LN_box;
        private TextBox RoleBox;
        private TextBox PositionBox;
        private Button AdminSMS;
        private Button InfoButton;
        private TextBox EmailBox;
        private TextBox UsernameBox;
    }
}