using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class TaskViewForm : Form
    {
        public User MyUser { get; set; }
        public TaskViewForm(User us)
        {
            InitializeComponent();
            MyUser = us;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            myProfileControl1.Visible = true;
            showWishesControl1.Visible = false;
            showCompletedControl1.Visible = false;
            showTasksControl1.Visible = false;
        }

        private void TaskViewForm_Load(object sender, EventArgs e)
        {
            myProfileControl1.Visible = true;
            myProfileControl1.MyUser = MyUser;
            myProfileControl1.SetInfoAboutUser();

            showWishesControl1.Visible = false;
            showWishesControl1.MyUser = MyUser;
            showWishesControl1.SetInfo();

            showCompletedControl1.Visible = false;
            showCompletedControl1.MyUser = MyUser;
            showCompletedControl1.SetInfo();

            showTasksControl1.Visible = false;
            showTasksControl1.MyUser = MyUser;
            showTasksControl1.SetInfo();
        }

        private void wishesButton_Click(object sender, EventArgs e)
        {
            showWishesControl1.Visible = true;
            myProfileControl1.Visible = false;
            showCompletedControl1.Visible = false;
            showTasksControl1.Visible = false;

        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            showWishesControl1.Visible = false;
            myProfileControl1.Visible = false;
            showCompletedControl1.Visible = true;
            showTasksControl1.Visible = false;

        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            showWishesControl1.Visible = false;
            myProfileControl1.Visible = false;
            showCompletedControl1.Visible = false;
            showTasksControl1.Visible = true;

        }
    }
}
