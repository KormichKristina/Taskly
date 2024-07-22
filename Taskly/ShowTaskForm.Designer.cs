namespace Taskly
{
    partial class ShowTaskForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            descTextBox = new RichTextBox();
            nameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cancelButton = new Guna.UI2.WinForms.Guna2GradientButton();
            completeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            completeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            colorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // descTextBox
            // 
            descTextBox.BackColor = Color.White;
            descTextBox.BorderStyle = BorderStyle.None;
            descTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            descTextBox.Location = new Point(61, 101);
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.Size = new Size(285, 64);
            descTextBox.TabIndex = 5;
            descTextBox.Text = "Description";
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 16F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(61, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 32);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // cancelButton
            // 
            cancelButton.CustomizableEdges = customizableEdges1;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.FromArgb(255, 9, 150);
            cancelButton.FillColor2 = Color.Yellow;
            cancelButton.Font = new Font("Segoe UI", 11F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(61, 352);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cancelButton.Size = new Size(120, 34);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // completeButton
            // 
            completeButton.CustomizableEdges = customizableEdges3;
            completeButton.DisabledState.BorderColor = Color.DarkGray;
            completeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            completeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            completeButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            completeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            completeButton.FillColor = Color.FromArgb(255, 9, 150);
            completeButton.FillColor2 = Color.Yellow;
            completeButton.Font = new Font("Segoe UI", 11F);
            completeButton.ForeColor = Color.White;
            completeButton.Location = new Point(222, 352);
            completeButton.Name = "completeButton";
            completeButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            completeButton.Size = new Size(139, 34);
            completeButton.TabIndex = 11;
            completeButton.Text = "Complete a task";
            completeButton.Click += completeButton_Click;
            // 
            // completeLabel
            // 
            completeLabel.BackColor = Color.Transparent;
            completeLabel.Font = new Font("Segoe UI", 16F);
            completeLabel.ForeColor = Color.FromArgb(255, 0, 139);
            completeLabel.Location = new Point(61, 272);
            completeLabel.Name = "completeLabel";
            completeLabel.Size = new Size(176, 32);
            completeLabel.TabIndex = 10;
            completeLabel.Text = "wish is not fulfilled";
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.Transparent;
            colorLabel.Font = new Font("Segoe UI", 16F);
            colorLabel.ForeColor = Color.FromArgb(255, 0, 139);
            colorLabel.Location = new Point(61, 204);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(57, 32);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "Color:";
            // 
            // ShowTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(419, 412);
            Controls.Add(cancelButton);
            Controls.Add(completeButton);
            Controls.Add(completeLabel);
            Controls.Add(colorLabel);
            Controls.Add(descTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowTaskForm";
            Load += ShowTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox descTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton cancelButton;
        private Guna.UI2.WinForms.Guna2GradientButton completeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel completeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel colorLabel;
    }
}