namespace Taskly
{
    partial class ShowWishForm
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
            nameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            howWillYouFulfillTextBox = new RichTextBox();
            descTextBox = new RichTextBox();
            colorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            fulfillWishLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            fulfillWishButton = new Guna.UI2.WinForms.Guna2GradientButton();
            cancelButton = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 16F);
            nameLabel.ForeColor = Color.FromArgb(255, 0, 139);
            nameLabel.Location = new Point(61, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // howWillYouFulfillTextBox
            // 
            howWillYouFulfillTextBox.BackColor = Color.White;
            howWillYouFulfillTextBox.BorderStyle = BorderStyle.None;
            howWillYouFulfillTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            howWillYouFulfillTextBox.Location = new Point(61, 194);
            howWillYouFulfillTextBox.Name = "howWillYouFulfillTextBox";
            howWillYouFulfillTextBox.ReadOnly = true;
            howWillYouFulfillTextBox.Size = new Size(285, 118);
            howWillYouFulfillTextBox.TabIndex = 4;
            howWillYouFulfillTextBox.Text = "How will you fulfill this wish?";
            // 
            // descTextBox
            // 
            descTextBox.BackColor = Color.White;
            descTextBox.BorderStyle = BorderStyle.None;
            descTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            descTextBox.Location = new Point(61, 100);
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.Size = new Size(285, 64);
            descTextBox.TabIndex = 3;
            descTextBox.Text = "Description";
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.Transparent;
            colorLabel.Font = new Font("Segoe UI", 16F);
            colorLabel.ForeColor = Color.FromArgb(255, 0, 139);
            colorLabel.Location = new Point(61, 336);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(57, 32);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color:";
            // 
            // fulfillWishLabel
            // 
            fulfillWishLabel.BackColor = Color.Transparent;
            fulfillWishLabel.Font = new Font("Segoe UI", 16F);
            fulfillWishLabel.ForeColor = Color.FromArgb(255, 0, 139);
            fulfillWishLabel.Location = new Point(61, 394);
            fulfillWishLabel.Name = "fulfillWishLabel";
            fulfillWishLabel.Size = new Size(176, 32);
            fulfillWishLabel.TabIndex = 6;
            fulfillWishLabel.Text = "wish is not fulfilled";
            // 
            // fulfillWishButton
            // 
            fulfillWishButton.CustomizableEdges = customizableEdges1;
            fulfillWishButton.DisabledState.BorderColor = Color.DarkGray;
            fulfillWishButton.DisabledState.CustomBorderColor = Color.DarkGray;
            fulfillWishButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            fulfillWishButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            fulfillWishButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            fulfillWishButton.FillColor = Color.FromArgb(255, 9, 150);
            fulfillWishButton.FillColor2 = Color.Yellow;
            fulfillWishButton.Font = new Font("Segoe UI", 11F);
            fulfillWishButton.ForeColor = Color.White;
            fulfillWishButton.Location = new Point(241, 461);
            fulfillWishButton.Name = "fulfillWishButton";
            fulfillWishButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            fulfillWishButton.Size = new Size(120, 34);
            fulfillWishButton.TabIndex = 7;
            fulfillWishButton.Text = "Fulfill a wish";
            fulfillWishButton.Click += fulfillWishButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.CustomizableEdges = customizableEdges3;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.FromArgb(255, 9, 150);
            cancelButton.FillColor2 = Color.Yellow;
            cancelButton.Font = new Font("Segoe UI", 11F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(61, 461);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cancelButton.Size = new Size(120, 34);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // ShowWishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(419, 507);
            Controls.Add(cancelButton);
            Controls.Add(fulfillWishButton);
            Controls.Add(fulfillWishLabel);
            Controls.Add(colorLabel);
            Controls.Add(howWillYouFulfillTextBox);
            Controls.Add(descTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowWishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowWishForm";
            Load += ShowWishForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel nameLabel;
        private RichTextBox howWillYouFulfillTextBox;
        private RichTextBox descTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel colorLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel fulfillWishLabel;
        private Guna.UI2.WinForms.Guna2GradientButton fulfillWishButton;
        private Guna.UI2.WinForms.Guna2GradientButton cancelButton;
    }
}