namespace Taskly
{
    partial class LoginControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            goToSignInlabel = new Label();
            eyeButton1 = new Guna.UI2.WinForms.Guna2Button();
            eyeButton2 = new Guna.UI2.WinForms.Guna2Button();
            exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            conPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            panel1.Controls.Add(goToSignInlabel);
            panel1.Controls.Add(eyeButton1);
            panel1.Controls.Add(eyeButton2);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(conPasswordTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(guna2GradientPanel1);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 371);
            panel1.TabIndex = 1;
            // 
            // goToSignInlabel
            // 
            goToSignInlabel.AutoSize = true;
            goToSignInlabel.Cursor = Cursors.Hand;
            goToSignInlabel.ForeColor = Color.FromArgb(255, 0, 139);
            goToSignInlabel.Location = new Point(103, 269);
            goToSignInlabel.Name = "goToSignInlabel";
            goToSignInlabel.Size = new Size(141, 15);
            goToSignInlabel.TabIndex = 10;
            goToSignInlabel.Text = "I already have an account";
            goToSignInlabel.Click += goToSignInlabel_Click;
            // 
            // eyeButton1
            // 
            eyeButton1.CustomizableEdges = customizableEdges1;
            eyeButton1.DisabledState.BorderColor = Color.DarkGray;
            eyeButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            eyeButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            eyeButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            eyeButton1.FillColor = Color.Transparent;
            eyeButton1.Font = new Font("Segoe UI", 9F);
            eyeButton1.ForeColor = Color.White;
            eyeButton1.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            eyeButton1.Image = Properties.Resources.eye;
            eyeButton1.Location = new Point(294, 166);
            eyeButton1.Name = "eyeButton1";
            eyeButton1.PressedColor = Color.FromArgb(255, 192, 128);
            eyeButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            eyeButton1.Size = new Size(46, 36);
            eyeButton1.TabIndex = 8;
            eyeButton1.Click += eyeButton1_Click;
            // 
            // eyeButton2
            // 
            eyeButton2.CustomizableEdges = customizableEdges3;
            eyeButton2.DisabledState.BorderColor = Color.DarkGray;
            eyeButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            eyeButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            eyeButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            eyeButton2.FillColor = Color.Transparent;
            eyeButton2.Font = new Font("Segoe UI", 9F);
            eyeButton2.ForeColor = Color.White;
            eyeButton2.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            eyeButton2.Image = Properties.Resources.eye;
            eyeButton2.Location = new Point(294, 219);
            eyeButton2.Name = "eyeButton2";
            eyeButton2.PressedColor = Color.FromArgb(255, 192, 128);
            eyeButton2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            eyeButton2.Size = new Size(46, 36);
            eyeButton2.TabIndex = 7;
            eyeButton2.Click += eyeButton2_Click;
            // 
            // exitButton
            // 
            exitButton.CustomizableEdges = customizableEdges5;
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
            exitButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exitButton.Size = new Size(141, 41);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.Click += exitButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.CustomizableEdges = customizableEdges7;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.FromArgb(253, 0, 139);
            LoginButton.FillColor2 = Color.FromArgb(255, 128, 0);
            LoginButton.Font = new Font("Segoe UI", 9F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(184, 318);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginButton.Size = new Size(141, 41);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.Click += LoginButton_Click;
            // 
            // conPasswordTextBox
            // 
            conPasswordTextBox.BorderColor = Color.FromArgb(253, 0, 139);
            conPasswordTextBox.BorderThickness = 2;
            conPasswordTextBox.CustomizableEdges = customizableEdges9;
            conPasswordTextBox.DefaultText = "";
            conPasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            conPasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            conPasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            conPasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            conPasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            conPasswordTextBox.Font = new Font("Segoe UI", 9F);
            conPasswordTextBox.ForeColor = Color.FromArgb(253, 0, 139);
            conPasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            conPasswordTextBox.Location = new Point(61, 219);
            conPasswordTextBox.Name = "conPasswordTextBox";
            conPasswordTextBox.PasswordChar = '\0';
            conPasswordTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            conPasswordTextBox.PlaceholderText = "Confirm password";
            conPasswordTextBox.SelectedText = "";
            conPasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            conPasswordTextBox.Size = new Size(227, 36);
            conPasswordTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderColor = Color.FromArgb(253, 0, 139);
            passwordTextBox.BorderThickness = 2;
            passwordTextBox.CustomizableEdges = customizableEdges11;
            passwordTextBox.DefaultText = "";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 9F);
            passwordTextBox.ForeColor = Color.FromArgb(253, 0, 139);
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(61, 166);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            passwordTextBox.PlaceholderText = "Your password";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            passwordTextBox.Size = new Size(227, 36);
            passwordTextBox.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.CustomizableEdges = customizableEdges13;
            guna2GradientPanel1.FillColor = Color.FromArgb(253, 0, 139);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 128, 0);
            guna2GradientPanel1.Location = new Point(0, 65);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2GradientPanel1.Size = new Size(347, 10);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderColor = Color.FromArgb(253, 0, 139);
            nameTextBox.BorderThickness = 2;
            nameTextBox.CustomizableEdges = customizableEdges15;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.ForeColor = Color.FromArgb(253, 0, 139);
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(61, 114);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            nameTextBox.PlaceholderText = "Your name";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            nameTextBox.Size = new Size(227, 36);
            nameTextBox.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 25F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(128, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(84, 47);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Login";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "LoginControl";
            Size = new Size(347, 371);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button eyeButton1;
        private Guna.UI2.WinForms.Guna2Button eyeButton2;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox conPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label goToSignInlabel;
    }
}
