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
            FnameBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // FnameBox
            // 
            FnameBox.Location = new Point(12, 70);
            FnameBox.Name = "FnameBox";
            FnameBox.PlaceholderText = "Ссылка";
            FnameBox.Size = new Size(309, 27);
            FnameBox.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Примечания";
            textBox1.Size = new Size(309, 162);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 126);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "XAML";
            textBox2.Size = new Size(309, 27);
            textBox2.TabIndex = 17;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(173, 386);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonHighlight;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(12, 386);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(148, 32);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Выйти";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // NewDocumentatioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(FnameBox);
            Controls.Add(label1);
            Name = "NewDocumentatioForm";
            Text = "NewDocumentatioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FnameBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SaveButton;
        private Button CancelButton;
    }
}