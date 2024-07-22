using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowTaskForm : Form
    {
        public User MyUser { get; set; }
        public MyTask MyTask { get; set; }
        public ShowTaskForm(MyTask myTask, User myUser)
        {
            InitializeComponent();
            MyTask = myTask;
            MyUser = myUser;
        }

        private void ShowTaskForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text += " " + MyTask.Name;
            descTextBox.Text = MyTask.Description;
            colorLabel.Text += " " + MyTask.MyColor;
            if (MyTask.IsComplete)
            {
                completeLabel.Text = "This task was completed";
            }
            else
            {
                completeLabel.Text = "This task is not completed";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (MyTask.IsComplete)
            {
                MessageBox.Show("This task has already been completed");
            }
            else
            {
                using (var us = new UserContext())
                {
                    MyTask.IsComplete = true;
                    us.Update(MyTask);
                    us.SaveChanges();
                    MyUser.TasksCompleted++;
                    us.Update(MyUser);
                    us.SaveChanges();
                }
                new TaskViewForm(MyUser).Show();
                Hide();
            }

        }
    }
}
