namespace Taskly
{
    partial class WarningForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            warningLabel = new Label();
            yesButton = new Guna.UI2.WinForms.Guna2GradientButton();
            noButton = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Font = new Font("Segoe UI", 18F);
            warningLabel.ForeColor = Color.FromArgb(255, 0, 139);
            warningLabel.Location = new Point(52, 43);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(243, 64);
            warningLabel.TabIndex = 0;
            warningLabel.Text = "Do you really want to\r\n remove the wish?";
            // 
            // yesButton
            // 
            yesButton.CustomizableEdges = customizableEdges5;
            yesButton.DisabledState.BorderColor = Color.DarkGray;
            yesButton.DisabledState.CustomBorderColor = Color.DarkGray;
            yesButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            yesButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            yesButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            yesButton.FillColor = Color.FromArgb(255, 9, 150);
            yesButton.FillColor2 = Color.Yellow;
            yesButton.Font = new Font("Segoe UI", 11F);
            yesButton.ForeColor = Color.White;
            yesButton.Location = new Point(190, 164);
            yesButton.Name = "yesButton";
            yesButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            yesButton.Size = new Size(116, 46);
            yesButton.TabIndex = 5;
            yesButton.Text = "Yes";
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.CustomizableEdges = customizableEdges7;
            noButton.DisabledState.BorderColor = Color.DarkGray;
            noButton.DisabledState.CustomBorderColor = Color.DarkGray;
            noButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            noButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            noButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            noButton.FillColor = Color.FromArgb(255, 9, 150);
            noButton.FillColor2 = Color.Yellow;
            noButton.Font = new Font("Segoe UI", 11F);
            noButton.ForeColor = Color.White;
            noButton.Location = new Point(43, 164);
            noButton.Name = "noButton";
            noButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            noButton.Size = new Size(116, 46);
            noButton.TabIndex = 6;
            noButton.Text = "No";
            noButton.Click += noButton_Click;
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(342, 222);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(warningLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarningForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarningForm";
            Load += WarningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label warningLabel;
        private Guna.UI2.WinForms.Guna2GradientButton yesButton;
        private Guna.UI2.WinForms.Guna2GradientButton noButton;
    }
}