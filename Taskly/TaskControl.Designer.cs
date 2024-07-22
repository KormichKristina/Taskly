namespace Taskly
{
    partial class TaskControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            completedLabel = new Label();
            showMoreButton = new Guna.UI2.WinForms.Guna2GradientButton();
            deleteButton = new Guna.UI2.WinForms.Guna2CircleButton();
            myColorPanel = new Panel();
            deadlineLabel = new Label();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Font = new Font("Segoe UI", 12F);
            completedLabel.ForeColor = Color.FromArgb(255, 0, 139);
            completedLabel.Location = new Point(211, 28);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(91, 21);
            completedLabel.TabIndex = 11;
            completedLabel.Text = "Completed!";
            // 
            // showMoreButton
            // 
            showMoreButton.CustomizableEdges = customizableEdges1;
            showMoreButton.DisabledState.BorderColor = Color.DarkGray;
            showMoreButton.DisabledState.CustomBorderColor = Color.DarkGray;
            showMoreButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            showMoreButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            showMoreButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            showMoreButton.FillColor = Color.FromArgb(255, 9, 150);
            showMoreButton.FillColor2 = Color.Yellow;
            showMoreButton.Font = new Font("Segoe UI", 11F);
            showMoreButton.ForeColor = Color.White;
            showMoreButton.Location = new Point(375, 80);
            showMoreButton.Name = "showMoreButton";
            showMoreButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            showMoreButton.Size = new Size(107, 34);
            showMoreButton.TabIndex = 10;
            showMoreButton.Text = "Show more";
            showMoreButton.Click += showMoreButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.DisabledState.BorderColor = Color.DarkGray;
            deleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteButton.FillColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 9F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Image = Properties.Resources.minus;
            deleteButton.ImageSize = new Size(40, 40);
            deleteButton.Location = new Point(440, 14);
            deleteButton.Name = "deleteButton";
            deleteButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            deleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            deleteButton.Size = new Size(42, 42);
            deleteButton.TabIndex = 9;
            deleteButton.Click += deleteButton_Click;
            // 
            // myColorPanel
            // 
            myColorPanel.BackColor = Color.White;
            myColorPanel.Location = new Point(24, 23);
            myColorPanel.Name = "myColorPanel";
            myColorPanel.Size = new Size(20, 20);
            myColorPanel.TabIndex = 8;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Segoe UI", 12F);
            deadlineLabel.ForeColor = Color.FromArgb(255, 0, 139);
            deadlineLabel.Location = new Point(50, 80);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(74, 21);
            deadlineLabel.TabIndex = 7;
            deadlineLabel.Text = "Deadline:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(50, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(71, 30);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(completedLabel);
            Controls.Add(showMoreButton);
            Controls.Add(deleteButton);
            Controls.Add(myColorPanel);
            Controls.Add(deadlineLabel);
            Controls.Add(nameLabel);
            Name = "TaskControl";
            Size = new Size(506, 129);
            Load += TaskControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label completedLabel;
        private Guna.UI2.WinForms.Guna2GradientButton showMoreButton;
        private Guna.UI2.WinForms.Guna2CircleButton deleteButton;
        private Panel myColorPanel;
        private Label deadlineLabel;
        private Label nameLabel;
    }
}
