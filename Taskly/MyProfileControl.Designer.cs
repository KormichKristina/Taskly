namespace Taskly
{
    partial class MyProfileControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nameLabel = new Label();
            passwordLabel = new Label();
            panel1 = new Panel();
            redactButton = new Guna.UI2.WinForms.Guna2Button();
            tasksCompletedLabel = new Label();
            wishedFulfilledLabel = new Label();
            signOutButton = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 15F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(66, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(68, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 15F);
            passwordLabel.ForeColor = Color.FromArgb(255, 0, 139);
            passwordLabel.Location = new Point(37, 80);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 28);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 239, 217);
            panel1.Controls.Add(redactButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(passwordLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 147);
            panel1.TabIndex = 2;
            // 
            // redactButton
            // 
            redactButton.CustomizableEdges = customizableEdges1;
            redactButton.DisabledState.BorderColor = Color.DarkGray;
            redactButton.DisabledState.CustomBorderColor = Color.DarkGray;
            redactButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            redactButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            redactButton.FillColor = Color.FromArgb(255, 0, 139);
            redactButton.Font = new Font("Segoe UI", 10F);
            redactButton.ForeColor = Color.White;
            redactButton.Location = new Point(365, 95);
            redactButton.Name = "redactButton";
            redactButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            redactButton.Size = new Size(143, 39);
            redactButton.TabIndex = 2;
            redactButton.Text = "Redact an account";
            redactButton.Click += redactButton_Click;
            // 
            // tasksCompletedLabel
            // 
            tasksCompletedLabel.AutoSize = true;
            tasksCompletedLabel.Font = new Font("Segoe UI", 15F);
            tasksCompletedLabel.ForeColor = Color.FromArgb(255, 0, 139);
            tasksCompletedLabel.Location = new Point(37, 168);
            tasksCompletedLabel.Name = "tasksCompletedLabel";
            tasksCompletedLabel.Size = new Size(159, 28);
            tasksCompletedLabel.TabIndex = 2;
            tasksCompletedLabel.Text = "Tasks completed:";
            // 
            // wishedFulfilledLabel
            // 
            wishedFulfilledLabel.AutoSize = true;
            wishedFulfilledLabel.Font = new Font("Segoe UI", 15F);
            wishedFulfilledLabel.ForeColor = Color.FromArgb(255, 0, 139);
            wishedFulfilledLabel.Location = new Point(37, 223);
            wishedFulfilledLabel.Name = "wishedFulfilledLabel";
            wishedFulfilledLabel.Size = new Size(147, 28);
            wishedFulfilledLabel.TabIndex = 4;
            wishedFulfilledLabel.Text = "Wishes fulfilled:";
            // 
            // signOutButton
            // 
            signOutButton.CustomizableEdges = customizableEdges3;
            signOutButton.DisabledState.BorderColor = Color.DarkGray;
            signOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signOutButton.FillColor = Color.White;
            signOutButton.Font = new Font("Segoe UI", 10F);
            signOutButton.ForeColor = Color.FromArgb(255, 128, 0);
            signOutButton.Image = Properties.Resources.exit;
            signOutButton.ImageAlign = HorizontalAlignment.Left;
            signOutButton.Location = new Point(365, 319);
            signOutButton.Name = "signOutButton";
            signOutButton.PressedColor = Color.FromArgb(255, 224, 192);
            signOutButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            signOutButton.Size = new Size(143, 45);
            signOutButton.TabIndex = 2;
            signOutButton.Text = "Sign out";
            signOutButton.Click += signOutButton_Click;
            // 
            // MyProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(signOutButton);
            Controls.Add(wishedFulfilledLabel);
            Controls.Add(tasksCompletedLabel);
            Controls.Add(panel1);
            Name = "MyProfileControl";
            Size = new Size(521, 376);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label passwordLabel;
        private Panel panel1;
        private Label tasksCompletedLabel;
        private Label wishedFulfilledLabel;
        private Guna.UI2.WinForms.Guna2Button signOutButton;
        private Guna.UI2.WinForms.Guna2Button redactButton;
    }
}
