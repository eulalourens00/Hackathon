namespace client.forms.MainWindow
{
    partial class InformationFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationFormcs));
            NameBox = new TextBox();
            ObjectTypecomboBox = new ComboBox();
            LocationBox = new TextBox();
            NumberBox = new TextBox();
            DescriptionBox = new TextBox();
            label1 = new Label();
            CancelObject = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 64);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Название ";
            NameBox.Size = new Size(200, 27);
            NameBox.TabIndex = 2;
            // 
            // ObjectTypecomboBox
            // 
            ObjectTypecomboBox.ForeColor = Color.DimGray;
            ObjectTypecomboBox.FormattingEnabled = true;
            ObjectTypecomboBox.Location = new Point(12, 111);
            ObjectTypecomboBox.Name = "ObjectTypecomboBox";
            ObjectTypecomboBox.Size = new Size(200, 28);
            ObjectTypecomboBox.TabIndex = 6;
            ObjectTypecomboBox.Text = "Тип объекта";
            // 
            // LocationBox
            // 
            LocationBox.Location = new Point(12, 155);
            LocationBox.Name = "LocationBox";
            LocationBox.PlaceholderText = "Расположение";
            LocationBox.Size = new Size(200, 27);
            LocationBox.TabIndex = 7;
            // 
            // NumberBox
            // 
            NumberBox.Location = new Point(229, 111);
            NumberBox.Name = "NumberBox";
            NumberBox.PlaceholderText = "Кад. номер";
            NumberBox.Size = new Size(107, 27);
            NumberBox.TabIndex = 8;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(12, 202);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.PlaceholderText = "Описание";
            DescriptionBox.Size = new Size(324, 154);
            DescriptionBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 10;
            label1.Text = "Информационный бланк";
            // 
            // CancelObject
            // 
            CancelObject.BackColor = SystemColors.Control;
            CancelObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelObject.Location = new Point(12, 372);
            CancelObject.Name = "CancelObject";
            CancelObject.Size = new Size(119, 32);
            CancelObject.TabIndex = 11;
            CancelObject.Text = "Выйти";
            CancelObject.UseVisualStyleBackColor = false;
            CancelObject.Click += CancelObject_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.GradientInactiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(188, 372);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 32);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Редактировать";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // InformationFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(SaveButton);
            Controls.Add(CancelObject);
            Controls.Add(label1);
            Controls.Add(DescriptionBox);
            Controls.Add(NumberBox);
            Controls.Add(LocationBox);
            Controls.Add(ObjectTypecomboBox);
            Controls.Add(NameBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InformationFormcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformationFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private ComboBox ObjectTypecomboBox;
        private TextBox LocationBox;
        private TextBox NumberBox;
        private TextBox DescriptionBox;
        private Label label1;
        private Button CancelObject;
        private Button SaveButton;
    }
}