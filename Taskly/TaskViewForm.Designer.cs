using Taskly.Properties;
using Taskly.Classes;

namespace Taskly
{
    partial class TaskViewForm
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
            User user1 = new User();
            panel1 = new Panel();
            myProfileButton = new Guna.UI2.WinForms.Guna2Button();
            tasksButton = new Guna.UI2.WinForms.Guna2Button();
            exitButton = new Guna.UI2.WinForms.Guna2Button();
            completedButton = new Guna.UI2.WinForms.Guna2Button();
            wishesButton = new Guna.UI2.WinForms.Guna2Button();
            myProfileControl1 = new MyProfileControl();
            showWishesControl1 = new ShowWishesControl();
            showCompletedControl1 = new ShowCompletedControl();
            showTasksControl1 = new ShowTasksControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(myProfileButton);
            panel1.Controls.Add(tasksButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(completedButton);
            panel1.Controls.Add(wishesButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 376);
            panel1.TabIndex = 0;
            // 
            // myProfileButton
            // 
            myProfileButton.CustomizableEdges = customizableEdges1;
            myProfileButton.DisabledState.BorderColor = Color.DarkGray;
            myProfileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            myProfileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            myProfileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            myProfileButton.FillColor = Color.FromArgb(255, 224, 192);
            myProfileButton.Font = new Font("Segoe UI", 13F);
            myProfileButton.ForeColor = Color.FromArgb(255, 0, 139);
            myProfileButton.Image = Resources.profile;
            myProfileButton.ImageAlign = HorizontalAlignment.Left;
            myProfileButton.Location = new Point(0, 61);
            myProfileButton.Name = "myProfileButton";
            myProfileButton.PressedColor = Color.White;
            myProfileButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            myProfileButton.Size = new Size(171, 45);
            myProfileButton.TabIndex = 6;
            myProfileButton.Text = "My profile";
            myProfileButton.TextOffset = new Point(5, 0);
            myProfileButton.Click += myProfileButton_Click;
            // 
            // tasksButton
            // 
            tasksButton.CustomizableEdges = customizableEdges3;
            tasksButton.DisabledState.BorderColor = Color.DarkGray;
            tasksButton.DisabledState.CustomBorderColor = Color.DarkGray;
            tasksButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tasksButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tasksButton.FillColor = Color.FromArgb(255, 224, 192);
            tasksButton.Font = new Font("Segoe UI", 13F);
            tasksButton.ForeColor = Color.FromArgb(255, 0, 139);
            tasksButton.Image = Resources.checklist;
            tasksButton.ImageAlign = HorizontalAlignment.Left;
            tasksButton.Location = new Point(0, 112);
            tasksButton.Name = "tasksButton";
            tasksButton.PressedColor = Color.White;
            tasksButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tasksButton.Size = new Size(171, 45);
            tasksButton.TabIndex = 5;
            tasksButton.Text = "My tasks";
            tasksButton.TextOffset = new Point(5, 0);
            tasksButton.Click += tasksButton_Click;
            // 
            // exitButton
            // 
            exitButton.CustomizableEdges = customizableEdges5;
            exitButton.DisabledState.BorderColor = Color.DarkGray;
            exitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            exitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitButton.FillColor = Color.FromArgb(255, 224, 192);
            exitButton.Font = new Font("Segoe UI", 13F);
            exitButton.ForeColor = Color.FromArgb(255, 0, 139);
            exitButton.Image = Resources.exit;
            exitButton.ImageAlign = HorizontalAlignment.Left;
            exitButton.Location = new Point(0, 265);
            exitButton.Name = "exitButton";
            exitButton.PressedColor = Color.White;
            exitButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exitButton.Size = new Size(171, 45);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextOffset = new Point(5, 0);
            exitButton.Click += exitButton_Click;
            // 
            // completedButton
            // 
            completedButton.CustomizableEdges = customizableEdges7;
            completedButton.DisabledState.BorderColor = Color.DarkGray;
            completedButton.DisabledState.CustomBorderColor = Color.DarkGray;
            completedButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            completedButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            completedButton.FillColor = Color.FromArgb(255, 224, 192);
            completedButton.Font = new Font("Segoe UI", 13F);
            completedButton.ForeColor = Color.FromArgb(255, 0, 139);
            completedButton.Image = Resources.tick;
            completedButton.ImageAlign = HorizontalAlignment.Left;
            completedButton.Location = new Point(0, 214);
            completedButton.Name = "completedButton";
            completedButton.PressedColor = Color.White;
            completedButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            completedButton.Size = new Size(171, 45);
            completedButton.TabIndex = 3;
            completedButton.Text = "Completed";
            completedButton.TextOffset = new Point(5, 0);
            completedButton.Click += completedButton_Click;
            // 
            // wishesButton
            // 
            wishesButton.CustomizableEdges = customizableEdges9;
            wishesButton.DisabledState.BorderColor = Color.DarkGray;
            wishesButton.DisabledState.CustomBorderColor = Color.DarkGray;
            wishesButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            wishesButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            wishesButton.FillColor = Color.FromArgb(255, 224, 192);
            wishesButton.Font = new Font("Segoe UI", 13F);
            wishesButton.ForeColor = Color.FromArgb(255, 0, 139);
            wishesButton.Image = Resources.star__1_;
            wishesButton.ImageAlign = HorizontalAlignment.Left;
            wishesButton.Location = new Point(0, 163);
            wishesButton.Name = "wishesButton";
            wishesButton.PressedColor = Color.White;
            wishesButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            wishesButton.Size = new Size(171, 45);
            wishesButton.TabIndex = 2;
            wishesButton.Text = "My wishes";
            wishesButton.TextOffset = new Point(5, 0);
            wishesButton.Click += wishesButton_Click;
            // 
            // myProfileControl1
            // 
            myProfileControl1.BackColor = Color.White;
            myProfileControl1.Location = new Point(171, 0);
            user1.Id = 0;
            user1.Name = null;
            user1.Password = null;
            user1.TasksCompleted = 0;
            user1.WishesFulfilled = 0;
            user1.WishesId = null;
            myProfileControl1.MyUser = user1;
            myProfileControl1.Name = "myProfileControl1";
            myProfileControl1.Size = new Size(521, 376);
            myProfileControl1.TabIndex = 1;
            // 
            // showWishesControl1
            // 
            showWishesControl1.BackColor = Color.White;
            showWishesControl1.Location = new Point(171, 0);
            showWishesControl1.MyUser = null;
            showWishesControl1.Name = "showWishesControl1";
            showWishesControl1.Size = new Size(521, 376);
            showWishesControl1.TabIndex = 2;
            // 
            // showCompletedControl1
            // 
            showCompletedControl1.BackColor = Color.White;
            showCompletedControl1.Location = new Point(171, 0);
            showCompletedControl1.MyUser = null;
            showCompletedControl1.Name = "showCompletedControl1";
            showCompletedControl1.Size = new Size(521, 376);
            showCompletedControl1.TabIndex = 3;
            // 
            // showTasksControl1
            // 
            showTasksControl1.BackColor = Color.White;
            showTasksControl1.Location = new Point(171, 0);
            showTasksControl1.Name = "showTasksControl1";
            showTasksControl1.Size = new Size(521, 376);
            showTasksControl1.TabIndex = 7;
            // 
            // TaskViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(692, 376);
            Controls.Add(showTasksControl1);
            Controls.Add(showCompletedControl1);
            Controls.Add(showWishesControl1);
            Controls.Add(myProfileControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskViewForm";
            Load += TaskViewForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button myProfileButton;
        private Guna.UI2.WinForms.Guna2Button tasksButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button completedButton;
        private Guna.UI2.WinForms.Guna2Button wishesButton;
        private MyProfileControl myProfileControl1;
        private ShowWishesControl showWishesControl1;
        private ShowCompletedControl showCompletedControl1;
        private ShowTasksControl showTasksControl1;
    }
}