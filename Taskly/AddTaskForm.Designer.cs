namespace Taskly
{
    partial class AddTaskForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cancelButton = new Guna.UI2.WinForms.Guna2Button();
            createButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            colorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            descTextBox = new RichTextBox();
            nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            deadlineDateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            deadlineLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.CustomizableEdges = customizableEdges1;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.FromArgb(255, 0, 139);
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(46, 315);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cancelButton.Size = new Size(96, 31);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.CustomizableEdges = customizableEdges3;
            createButton.DisabledState.BorderColor = Color.DarkGray;
            createButton.DisabledState.CustomBorderColor = Color.DarkGray;
            createButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createButton.FillColor = Color.FromArgb(255, 0, 139);
            createButton.Font = new Font("Segoe UI", 10F);
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(235, 315);
            createButton.Name = "createButton";
            createButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            createButton.Size = new Size(96, 31);
            createButton.TabIndex = 12;
            createButton.Text = "Create";
            createButton.Click += createButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(254, 18, 154);
            label1.Location = new Point(90, 260);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 11;
            label1.Text = "Color";
            // 
            // colorComboBox
            // 
            colorComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Green", "Mint", "Blue", "Dark blue", "Violet", "Pink", "Orange", "Yellow", "White", "Black" });
            colorComboBox.BackColor = Color.Transparent;
            colorComboBox.BorderColor = Color.FromArgb(254, 18, 154);
            colorComboBox.CustomizableEdges = customizableEdges5;
            colorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            colorComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            colorComboBox.Font = new Font("Segoe UI", 10F);
            colorComboBox.ForeColor = Color.FromArgb(254, 18, 154);
            colorComboBox.ItemHeight = 30;
            colorComboBox.Items.AddRange(new object[] { "Yellow", "Orange", "Pink", "Violet", "Dark blue", "Blue", "Mint", "Green", "White", "Black" });
            colorComboBox.Location = new Point(169, 254);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            colorComboBox.Size = new Size(162, 36);
            colorComboBox.TabIndex = 10;
            // 
            // descTextBox
            // 
            descTextBox.BorderStyle = BorderStyle.None;
            descTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            descTextBox.Location = new Point(46, 95);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(285, 64);
            descTextBox.TabIndex = 8;
            descTextBox.Text = "Description";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderColor = Color.FromArgb(254, 18, 154);
            nameTextBox.CustomizableEdges = customizableEdges7;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.ForeColor = Color.FromArgb(254, 18, 154);
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(46, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderForeColor = Color.FromArgb(255, 128, 255);
            nameTextBox.PlaceholderText = "name";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            nameTextBox.Size = new Size(285, 36);
            nameTextBox.TabIndex = 7;
            // 
            // deadlineDateTimePicker1
            // 
            deadlineDateTimePicker1.Checked = true;
            deadlineDateTimePicker1.CustomizableEdges = customizableEdges9;
            deadlineDateTimePicker1.FillColor = Color.FromArgb(255, 0, 139);
            deadlineDateTimePicker1.FocusedColor = Color.White;
            deadlineDateTimePicker1.Font = new Font("Segoe UI", 9F);
            deadlineDateTimePicker1.ForeColor = Color.White;
            deadlineDateTimePicker1.Format = DateTimePickerFormat.Long;
            deadlineDateTimePicker1.Location = new Point(131, 190);
            deadlineDateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            deadlineDateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            deadlineDateTimePicker1.Name = "deadlineDateTimePicker1";
            deadlineDateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            deadlineDateTimePicker1.Size = new Size(200, 36);
            deadlineDateTimePicker1.TabIndex = 14;
            deadlineDateTimePicker1.Value = new DateTime(2024, 7, 13, 21, 45, 6, 80);
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Segoe UI", 14F);
            deadlineLabel.ForeColor = Color.FromArgb(254, 18, 154);
            deadlineLabel.Location = new Point(38, 201);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(87, 25);
            deadlineLabel.TabIndex = 15;
            deadlineLabel.Text = "Deadline";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(376, 366);
            Controls.Add(deadlineLabel);
            Controls.Add(deadlineDateTimePicker1);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(label1);
            Controls.Add(colorComboBox);
            Controls.Add(descTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button createButton;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox colorComboBox;
        private RichTextBox descTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker deadlineDateTimePicker1;
        private Label deadlineLabel;
    }
}