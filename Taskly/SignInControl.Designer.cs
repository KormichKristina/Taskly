namespace Taskly
{
    partial class SignInControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            goToLoginLabel = new Label();
            eyeButton = new Guna.UI2.WinForms.Guna2Button();
            exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            signInButton = new Guna.UI2.WinForms.Guna2GradientButton();
            passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(goToLoginLabel);
            panel1.Controls.Add(eyeButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(signInButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(guna2GradientPanel1);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 371);
            panel1.TabIndex = 2;
            // 
            // goToLoginLabel
            // 
            goToLoginLabel.AutoSize = true;
            goToLoginLabel.Cursor = Cursors.Hand;
            goToLoginLabel.ForeColor = Color.FromArgb(253, 0, 139);
            goToLoginLabel.Location = new Point(97, 243);
            goToLoginLabel.Name = "goToLoginLabel";
            goToLoginLabel.Size = new Size(150, 15);
            goToLoginLabel.TabIndex = 10;
            goToLoginLabel.Text = "I don't have an account yet";
            goToLoginLabel.Click += goToLoginLabel_Click_1;
            // 
            // eyeButton
            // 
            eyeButton.CustomizableEdges = customizableEdges1;
            eyeButton.DisabledState.BorderColor = Color.DarkGray;
            eyeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            eyeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            eyeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            eyeButton.FillColor = Color.Transparent;
            eyeButton.Font = new Font("Segoe UI", 9F);
            eyeButton.ForeColor = Color.White;
            eyeButton.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            eyeButton.Image = Properties.Resources.eye;
            eyeButton.Location = new Point(294, 189);
            eyeButton.Name = "eyeButton";
            eyeButton.PressedColor = Color.FromArgb(255, 192, 128);
            eyeButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            eyeButton.Size = new Size(46, 36);
            eyeButton.TabIndex = 8;
            eyeButton.Click += eyeButton_Click;
            // 
            // exitButton
            // 
            exitButton.CustomizableEdges = customizableEdges3;
            exitButton.DisabledState.BorderColor = Color.DarkGray;
            exitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            exitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            exitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitButton.FillColor = Color.FromArgb(253, 0, 139);
            exitButton.FillColor2 = Color.FromArgb(255, 128, 0);
            exitButton.Font = new Font("Segoe UI", 9F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(25, 318);
            exitButton.Name = "exitButton";
            exitButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            exitButton.Size = new Size(141, 41);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.Click += exitButton_Click;
            // 
            // signInButton
            // 
            signInButton.CustomizableEdges = customizableEdges5;
            signInButton.DisabledState.BorderColor = Color.DarkGray;
            signInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            signInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInButton.FillColor = Color.FromArgb(253, 0, 139);
            signInButton.FillColor2 = Color.FromArgb(255, 128, 0);
            signInButton.Font = new Font("Segoe UI", 9F);
            signInButton.ForeColor = Color.White;
            signInButton.Location = new Point(184, 318);
            signInButton.Name = "signInButton";
            signInButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            signInButton.Size = new Size(141, 41);
            signInButton.TabIndex = 5;
            signInButton.Text = "Sign in";
            signInButton.Click += signInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderColor = Color.FromArgb(253, 0, 139);
            passwordTextBox.BorderThickness = 2;
            passwordTextBox.CustomizableEdges = customizableEdges7;
            passwordTextBox.DefaultText = "";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 9F);
            passwordTextBox.ForeColor = Color.FromArgb(253, 0, 139);
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(61, 189);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            passwordTextBox.PlaceholderText = "Your password";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            passwordTextBox.Size = new Size(227, 36);
            passwordTextBox.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.FillColor = Color.FromArgb(253, 0, 139);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 128, 0);
            guna2GradientPanel1.Location = new Point(0, 65);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientPanel1.Size = new Size(347, 10);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderColor = Color.FromArgb(253, 0, 139);
            nameTextBox.BorderThickness = 2;
            nameTextBox.CustomizableEdges = customizableEdges11;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.ForeColor = Color.FromArgb(253, 0, 139);
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(61, 137);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            nameTextBox.PlaceholderText = "Your name";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            nameTextBox.Size = new Size(227, 36);
            nameTextBox.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 25F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(116, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(103, 47);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Sign in";
            // 
            // SignInControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SignInControl";
            Size = new Size(347, 371);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button eyeButton;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
        private Guna.UI2.WinForms.Guna2GradientButton signInButton;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label goToLoginLabel;
    }
}
