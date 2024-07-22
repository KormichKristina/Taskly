using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class WarningForm : Form
    {

        public Aspiration MyAspiration { get; set; }
        public User MyUser { get; set; }

        public WarningForm(Aspiration myAsp, User myUs)
        {
            InitializeComponent();
            MyAspiration = myAsp;
            MyUser = myUs;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var us = new UserContext())
            {
                if (MyAspiration is Wish)
                {
                    MyUser.WishesId.Remove(MyAspiration.Id);
                    us.Update(MyUser);
                    us.SaveChanges();

                    us.Wishes.Remove((Wish)MyAspiration);
                    us.SaveChanges();


                }
                else
                {
                    MyUser.TasksId.Remove(MyAspiration.Id);
                    us.Update(MyUser);
                    us.SaveChanges();

                    us.Tasks.Remove((MyTask)MyAspiration);
                    us.SaveChanges();
                }
            }
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void WarningForm_Load(object sender, EventArgs e)
        {
            if (MyAspiration is Wish)
            {
                warningLabel.Text = "Do you really want to\r\n remove the wish?\r\n";
            }
            else
            {
                warningLabel.Text = "Do you really want to\r\n remove the task?\r\n";
            }
        }
    }
}
