﻿namespace client.forms.MainWindow
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            collapsibleSidebar1 = new CollapsibleSidebar();
            label1 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 160);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "ЮЗЕРЫ";
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(label1);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label label1;
    }
}