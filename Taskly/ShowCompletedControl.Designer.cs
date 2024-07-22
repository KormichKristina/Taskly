namespace Taskly
{
    partial class ShowCompletedControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sortComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.Transparent;
            sortComboBox.BorderColor = Color.FromArgb(255, 192, 128);
            sortComboBox.CustomizableEdges = customizableEdges3;
            sortComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            sortComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sortComboBox.Font = new Font("Segoe UI", 10F);
            sortComboBox.ForeColor = Color.FromArgb(255, 192, 128);
            sortComboBox.ItemHeight = 30;
            sortComboBox.Items.AddRange(new object[] { "All", "Only wishes", "Only tasks" });
            sortComboBox.Location = new Point(155, 16);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            sortComboBox.Size = new Size(219, 36);
            sortComboBox.TabIndex = 7;
            sortComboBox.SelectedIndexChanged += SortComboBox_IndexChanged;
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
            // ShowCompletedControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(sortComboBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ShowCompletedControl";
            Size = new Size(521, 376);
            Load += ShowCompletedControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox sortComboBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
