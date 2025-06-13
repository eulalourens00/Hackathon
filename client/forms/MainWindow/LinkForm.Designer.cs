namespace client.forms.MainWindow
{
    partial class LinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkForm));
            textBox1 = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ссылка для нового изображения";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonHighlight;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(12, 127);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(148, 32);
            CancelButton.TabIndex = 24;
            CancelButton.Text = "Выйти";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(187, 127);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 25;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 28);
            label1.TabIndex = 26;
            label1.Text = "Новое изображение";
            // 
            // LinkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(359, 177);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(textBox1);
            Name = "LinkForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button CancelButton;
        private Button SaveButton;
        private Label label1;
    }
}