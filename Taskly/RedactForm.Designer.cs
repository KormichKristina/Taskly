namespace Taskly
{
    partial class RedactForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            cancelButton = new Guna.UI2.WinForms.Guna2Button();
            applyButton = new Guna.UI2.WinForms.Guna2Button();
            passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            nameLabel = new Label();
            passwordLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 239, 217);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(applyButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(passwordLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 207);
            panel1.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.CustomizableEdges = customizableEdges9;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.FromArgb(255, 0, 139);
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(28, 156);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cancelButton.Size = new Size(143, 39);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // applyButton
            // 
            applyButton.CustomizableEdges = customizableEdges11;
            applyButton.DisabledState.BorderColor = Color.DarkGray;
            applyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            applyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            applyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            applyButton.FillColor = Color.FromArgb(255, 0, 139);
            applyButton.Font = new Font("Segoe UI", 10F);
            applyButton.ForeColor = Color.White;
            applyButton.Location = new Point(211, 156);
            applyButton.Name = "applyButton";
            applyButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            applyButton.Size = new Size(143, 39);
            applyButton.TabIndex = 4;
            applyButton.Text = "Apply";
            applyButton.Click += applyButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.CustomizableEdges = customizableEdges13;
            passwordTextBox.DefaultText = "";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 9F);
            passwordTextBox.ForeColor = Color.FromArgb(255, 0, 139);
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(122, 82);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.PlaceholderText = "";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            passwordTextBox.Size = new Size(232, 36);
            passwordTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.CustomizableEdges = customizableEdges15;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.ForeColor = Color.FromArgb(255, 0, 139);
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(122, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderText = "";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            nameTextBox.Size = new Size(232, 36);
            nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 15F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(48, 20);
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
            passwordLabel.Location = new Point(19, 82);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 28);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // RedactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 207);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RedactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedactForm";
            Load += RedactForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label nameLabel;
        private Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button applyButton;
    }
}