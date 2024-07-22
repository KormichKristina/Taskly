using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowWishForm : Form
    {
        public Wish MyWish { get; set; }
        public User MyUser { get; set; }
        public ShowWishForm(Wish myWish, User myUser)
        {
            InitializeComponent();
            MyWish = myWish;
            MyUser = myUser;
        }

        private void ShowWishForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text += " " + MyWish.Name;
            descTextBox.Text = MyWish.Description;
            howWillYouFulfillTextBox.Text = MyWish.HowWillYouAchive;
            colorLabel.Text += " "+MyWish.MyColor;
            if (MyWish.IsComplete)
            {
                fulfillWishLabel.Text = "wish is fulfilled";
            }
            else
            {
                fulfillWishLabel.Text = "wish is not fulfilled";
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void fulfillWishButton_Click(object sender, EventArgs e)
        {

            if (MyWish.IsComplete)
            {
                MessageBox.Show("This wish has already been fulfilled");
            }
            else
            {
                using (var us = new UserContext())
                {
                    MyWish.IsComplete = true;
                    us.Update(MyWish);
                    us.SaveChanges();
                    MyUser.WishesFulfilled++;
                    us.Update(MyUser);
                    us.SaveChanges();

                }
                new TaskViewForm(MyUser).Show();
                Hide();
            }

            
        }
    }
}
