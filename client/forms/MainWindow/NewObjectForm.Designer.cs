namespace client.forms.MainWindow
{
    partial class NewObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewObjectForm));
            NameBox = new TextBox();
            DescriptionBox = new TextBox();
            LocationBox = new TextBox();
            NumberBox = new TextBox();
            ObjectTypecomboBox = new ComboBox();
            label1 = new Label();
            EndMakeObject = new Button();
            CancelObject = new Button();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 52);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Название ";
            NameBox.Size = new Size(200, 27);
            NameBox.TabIndex = 1;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(12, 204);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.PlaceholderText = "Описание";
            DescriptionBox.Size = new Size(324, 154);
            DescriptionBox.TabIndex = 2;
            // 
            // LocationBox
            // 
            LocationBox.Location = new Point(12, 149);
            LocationBox.Name = "LocationBox";
            LocationBox.PlaceholderText = "Расположение";
            LocationBox.Size = new Size(200, 27);
            LocationBox.TabIndex = 3;
            // 
            // NumberBox
            // 
            NumberBox.Location = new Point(229, 96);
            NumberBox.Name = "NumberBox";
            NumberBox.PlaceholderText = "Кад. номер";
            NumberBox.Size = new Size(107, 27);
            NumberBox.TabIndex = 4;
            // 
            // ObjectTypecomboBox
            // 
            ObjectTypecomboBox.ForeColor = Color.DimGray;
            ObjectTypecomboBox.FormattingEnabled = true;
            ObjectTypecomboBox.Location = new Point(12, 95);
            ObjectTypecomboBox.Name = "ObjectTypecomboBox";
            ObjectTypecomboBox.Size = new Size(200, 28);
            ObjectTypecomboBox.TabIndex = 5;
            ObjectTypecomboBox.Text = "Тип объекта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 6;
            label1.Text = "Новый объект";
            // 
            // EndMakeObject
            // 
            EndMakeObject.BackColor = SystemColors.InactiveCaption;
            EndMakeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EndMakeObject.Location = new Point(217, 386);
            EndMakeObject.Name = "EndMakeObject";
            EndMakeObject.Size = new Size(119, 32);
            EndMakeObject.TabIndex = 7;
            EndMakeObject.Text = "Создать";
            EndMakeObject.UseVisualStyleBackColor = false;
            EndMakeObject.Click += EndMakeObject_Click;
            // 
            // CancelObject
            // 
            CancelObject.BackColor = SystemColors.Control;
            CancelObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelObject.Location = new Point(12, 386);
            CancelObject.Name = "CancelObject";
            CancelObject.Size = new Size(119, 32);
            CancelObject.TabIndex = 8;
            CancelObject.Text = "Отмена";
            CancelObject.UseVisualStyleBackColor = false;
            CancelObject.Click += CancelObject_Click;
            // 
            // NewObjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 430);
            Controls.Add(CancelObject);
            Controls.Add(EndMakeObject);
            Controls.Add(label1);
            Controls.Add(ObjectTypecomboBox);
            Controls.Add(NumberBox);
            Controls.Add(LocationBox);
            Controls.Add(DescriptionBox);
            Controls.Add(NameBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewObjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewObjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameBox;
        private TextBox DescriptionBox;
        private TextBox LocationBox;
        private TextBox NumberBox;
        private ComboBox ObjectTypecomboBox;
        private Label label1;
        private Button EndMakeObject;
        private Button CancelObject;
    }
}