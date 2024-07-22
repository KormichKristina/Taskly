namespace Taskly
{
    partial class ShowInfoAboutWishControl
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
            nameLabel = new Label();
            dateOfCreateLabel = new Label();
            myColorPanel = new Panel();
            deleteButton = new Guna.UI2.WinForms.Guna2CircleButton();
            showMoreButton = new Guna.UI2.WinForms.Guna2GradientButton();
            completedLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(54, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(71, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // dateOfCreateLabel
            // 
            dateOfCreateLabel.AutoSize = true;
            dateOfCreateLabel.Font = new Font("Segoe UI", 12F);
            dateOfCreateLabel.ForeColor = Color.FromArgb(255, 0, 139);
            dateOfCreateLabel.Location = new Point(54, 79);
            dateOfCreateLabel.Name = "dateOfCreateLabel";
            dateOfCreateLabel.Size = new Size(106, 21);
            dateOfCreateLabel.TabIndex = 1;
            dateOfCreateLabel.Text = "Date of create";
            // 
            // myColorPanel
            // 
            myColorPanel.BackColor = Color.White;
            myColorPanel.Location = new Point(28, 22);
            myColorPanel.Name = "myColorPanel";
            myColorPanel.Size = new Size(20, 20);
            myColorPanel.TabIndex = 2;
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
            deleteButton.Location = new Point(444, 13);
            deleteButton.Name = "deleteButton";
            deleteButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            deleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            deleteButton.Size = new Size(42, 42);
            deleteButton.TabIndex = 3;
            deleteButton.Click += deleteButton_Click;
            // 
            // showMoreButton
            // 
            showMoreButton.CustomizableEdges = customizableEdges2;
            showMoreButton.DisabledState.BorderColor = Color.DarkGray;
            showMoreButton.DisabledState.CustomBorderColor = Color.DarkGray;
            showMoreButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            showMoreButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            showMoreButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            showMoreButton.FillColor = Color.FromArgb(255, 9, 150);
            showMoreButton.FillColor2 = Color.Yellow;
            showMoreButton.Font = new Font("Segoe UI", 11F);
            showMoreButton.ForeColor = Color.White;
            showMoreButton.Location = new Point(353, 79);
            showMoreButton.Name = "showMoreButton";
            showMoreButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            showMoreButton.Size = new Size(133, 34);
            showMoreButton.TabIndex = 4;
            showMoreButton.Text = "Show more";
            showMoreButton.Click += showMoreButton_Click;
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Font = new Font("Segoe UI", 12F);
            completedLabel.ForeColor = Color.FromArgb(255, 0, 139);
            completedLabel.Location = new Point(215, 27);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(91, 21);
            completedLabel.TabIndex = 5;
            completedLabel.Text = "Completed!";
            // 
            // ShowInfoAboutWishControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(completedLabel);
            Controls.Add(showMoreButton);
            Controls.Add(deleteButton);
            Controls.Add(myColorPanel);
            Controls.Add(dateOfCreateLabel);
            Controls.Add(nameLabel);
            Name = "ShowInfoAboutWishControl";
            Size = new Size(506, 129);
            Load += ShowInfoAboutAspirationControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label dateOfCreateLabel;
        private Panel myColorPanel;
        private Guna.UI2.WinForms.Guna2CircleButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton showMoreButton;
        private Label completedLabel;
    }
}
