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
            collapsibleSidebar1 = new CollapsibleSidebar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(181, 23);
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
            pictureBox2.Location = new Point(83, 79);
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
            loginbutton.BackColor = Color.FromArgb(115, 10, 10);
            loginbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginbutton.Location = new Point(361, 388);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(156, 38);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Войти";
            loginbutton.UseVisualStyleBackColor = false;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(loginbutton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "WelcomeScreen";
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginbutton;
    }
}