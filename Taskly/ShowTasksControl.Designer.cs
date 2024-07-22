namespace Taskly
{
    partial class ShowTasksControl
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
            colorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            addButton = new Guna.UI2.WinForms.Guna2CircleButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // colorComboBox
            // 
            colorComboBox.BackColor = Color.Transparent;
            colorComboBox.BorderColor = Color.FromArgb(255, 192, 128);
            colorComboBox.CustomizableEdges = customizableEdges1;
            colorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            colorComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            colorComboBox.Font = new Font("Segoe UI", 10F);
            colorComboBox.ForeColor = Color.FromArgb(255, 192, 128);
            colorComboBox.ItemHeight = 30;
            colorComboBox.Items.AddRange(new object[] { "All", "Only Yellow", "Only Orange", "Only Pink", "Only Violet", "Only Dark blue", "Only Blue", "Only Mint", "Only Green", "Only White", "Only Black" });
            colorComboBox.Location = new Point(54, 15);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            colorComboBox.Size = new Size(140, 36);
            colorComboBox.TabIndex = 7;
            colorComboBox.SelectedIndexChanged += colorComboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.DisabledState.BorderColor = Color.DarkGray;
            addButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addButton.FillColor = Color.FromArgb(255, 239, 217);
            addButton.Font = new Font("Segoe UI", 9F);
            addButton.ForeColor = Color.White;
            addButton.Image = Properties.Resources.plus;
            addButton.Location = new Point(437, 6);
            addButton.Name = "addButton";
            addButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            addButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            addButton.Size = new Size(52, 52);
            addButton.TabIndex = 6;
            addButton.Click += addButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(521, 289);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 239, 217);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 10);
            panel1.TabIndex = 4;
            // 
            // ShowTasksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(colorComboBox);
            Controls.Add(addButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ShowTasksControl";
            Size = new Size(521, 376);
            Load += ShowTasksControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox colorComboBox;
        private Guna.UI2.WinForms.Guna2CircleButton addButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
