using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class MyProfileControl : UserControl
    {
        public User MyUser { get; set; } = new User();
        public MyProfileControl()
        {
            InitializeComponent();
        }

        public void SetInfoAboutUser()
        {
            nameLabel.Text += " " + MyUser.Name;
            passwordLabel.Text += " " + MyUser.Password;
            tasksCompletedLabel.Text += " " + MyUser.TasksCompleted;
            wishedFulfilledLabel.Text += " " + MyUser.WishesFulfilled;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            ParentForm.Hide();
        }

        private void redactButton_Click(object sender, EventArgs e)
        {
            new RedactForm(MyUser).Show();
            ParentForm.Hide();
        }
    }
}
