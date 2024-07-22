using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class TaskControl : UserControl
    {
        public MyTask MyTask { get; set; }
        public TaskControl(MyTask myTask)
        {
            InitializeComponent();
            MyTask = myTask;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var us = new UserContext())
            {
                User myUser = new User();
                var users = us.Users.ToList();
                foreach (var i in users)
                {
                    if (i.TasksId.Contains(MyTask.Id))
                    {
                        myUser = i;
                    }
                }
                new WarningForm(MyTask, myUser).Show();
                ParentForm.Hide();

            }
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyTask.Name;
            deadlineLabel.Text += " " + MyTask.Deadline.Year + "." + MyTask.Deadline.Month + "." + MyTask.Deadline.Day;
            myColorPanel.BackColor = MyTask.MyColor.GetColor();
            completedLabel.Visible = MyTask.IsComplete;
            deleteButton.Visible = !MyTask.IsComplete;


            if (DateTime.Now.Year > MyTask.Deadline.Year || (DateTime.Now.Month > MyTask.Deadline.Month && DateTime.Now.Year == MyTask.Deadline.Year) || (DateTime.Now.Day > MyTask.Deadline.Day && DateTime.Now.Month == MyTask.Deadline.Month && DateTime.Now.Year == MyTask.Deadline.Year) && !MyTask.IsComplete)
            {
                completedLabel.Visible = true;
                completedLabel.Text = "Task is not completed";
            }
            else
            {
                completedLabel.Text = "Completed!";
            }


        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            new ShowTaskForm(MyTask, ((TaskViewForm)ParentForm).MyUser).Show();
            ParentForm.Hide();
        }

        
    }
}
