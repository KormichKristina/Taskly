namespace Taskly
{
    partial class AddWish
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            descTextBox = new RichTextBox();
            howWillYouFulfillTextBox = new RichTextBox();
            colorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            createButton = new Guna.UI2.WinForms.Guna2Button();
            cancelButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BorderColor = Color.FromArgb(254, 18, 154);
            nameTextBox.CustomizableEdges = customizableEdges1;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(46, 29);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            nameTextBox.PlaceholderText = "name";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            nameTextBox.Size = new Size(285, 36);
            nameTextBox.TabIndex = 0;
            // 
            // descTextBox
            // 
            descTextBox.BorderStyle = BorderStyle.None;
            descTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            descTextBox.Location = new Point(46, 104);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(285, 64);
            descTextBox.TabIndex = 1;
            descTextBox.Text = "Description";
            // 
            // howWillYouFulfillTextBox
            // 
            howWillYouFulfillTextBox.BorderStyle = BorderStyle.None;
            howWillYouFulfillTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            howWillYouFulfillTextBox.Location = new Point(46, 198);
            howWillYouFulfillTextBox.Name = "howWillYouFulfillTextBox";
            howWillYouFulfillTextBox.Size = new Size(285, 118);
            howWillYouFulfillTextBox.TabIndex = 2;
            howWillYouFulfillTextBox.Text = "How will you fulfill this wish?";
            // 
            // colorComboBox
            // 
            colorComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Green", "Mint", "Blue", "Dark blue", "Violet", "Pink", "Orange", "Yellow", "White", "Black" });
            colorComboBox.BackColor = Color.Transparent;
            colorComboBox.BorderColor = Color.FromArgb(254, 18, 154);
            colorComboBox.CustomizableEdges = customizableEdges3;
            colorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            colorComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            colorComboBox.Font = new Font("Segoe UI", 10F);
            colorComboBox.ForeColor = Color.FromArgb(254, 18, 154);
            colorComboBox.ItemHeight = 30;
            colorComboBox.Items.AddRange(new object[] { "Yellow", "Orange", "Pink", "Violet", "Dark blue", "Blue", "Mint", "Green", "White", "Black" });
            colorComboBox.Location = new Point(169, 337);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            colorComboBox.Size = new Size(162, 36);
            colorComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(254, 18, 154);
            label1.Location = new Point(90, 343);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 4;
            label1.Text = "Color";
            // 
            // createButton
            // 
            createButton.CustomizableEdges = customizableEdges5;
            createButton.DisabledState.BorderColor = Color.DarkGray;
            createButton.DisabledState.CustomBorderColor = Color.DarkGray;
            createButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createButton.FillColor = Color.FromArgb(255, 0, 139);
            createButton.Font = new Font("Segoe UI", 10F);
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(235, 398);
            createButton.Name = "createButton";
            createButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            createButton.Size = new Size(96, 31);
            createButton.TabIndex = 5;
            createButton.Text = "Create";
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.CustomizableEdges = customizableEdges7;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.FromArgb(255, 0, 139);
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(46, 398);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cancelButton.Size = new Size(96, 31);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // AddWish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(376, 441);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(label1);
            Controls.Add(colorComboBox);
            Controls.Add(howWillYouFulfillTextBox);
            Controls.Add(descTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddWish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddWish";
            Load += AddWish_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private RichTextBox descTextBox;
        private RichTextBox howWillYouFulfillTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox colorComboBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button createButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
    }
}