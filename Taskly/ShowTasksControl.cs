using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowTasksControl : UserControl
    {
        public User MyUser { get; set; }
        public ShowTasksControl()
        {
            InitializeComponent();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (colorComboBox.SelectedItem.ToString() != "All")
            {
                string myColor = colorComboBox.SelectedItem.ToString().Substring(5, colorComboBox.SelectedItem.ToString().Length - 5);


                using (var us = new UserContext())
                {
                    var tasks = us.Tasks.ToList();

                    foreach (var i in tasks)
                    {
                        if (MyUser.TasksId.Contains(i.Id) && i.MyColor == myColor && !i.IsComplete)
                        {
                            flowLayoutPanel1.Controls.Add(new TaskControl(i));
                        }
                    }

                }

            }
            else if (MyUser != null)
            {
                SetInfo();
            }
        }

        private void ShowTasksControl_Load(object sender, EventArgs e)
        {
            colorComboBox.Text = "All";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddTaskForm(((TaskViewForm)ParentForm).MyUser).Show();
            ParentForm.Hide();
        }
        public void SetInfo()
        {
            using (var us = new UserContext())
            {
                var tasks = us.Tasks.ToList();

                foreach (var i in tasks)
                {
                    if (MyUser.TasksId.Contains(i.Id) && !i.IsComplete)
                    {
                        flowLayoutPanel1.Controls.Add(new TaskControl(i));
                    }
                }

            }
        }
    }
}
