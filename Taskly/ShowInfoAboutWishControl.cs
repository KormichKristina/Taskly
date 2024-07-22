using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowInfoAboutWishControl : UserControl
    {
        public Wish MyWish { get; set; }
        public ShowInfoAboutWishControl(Wish wish)
        {
            InitializeComponent();
            MyWish = wish;
        }

        private void ShowInfoAboutAspirationControl_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyWish.Name;
            dateOfCreateLabel.Text = MyWish.DateOfCreate.ToString();
            myColorPanel.BackColor = MyWish.MyColor.GetColor();
            completedLabel.Visible = MyWish.IsComplete;
            deleteButton.Visible = !MyWish.IsComplete;

        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            using (var us = new UserContext())
            {
                User myUser = new User();
                var users = us.Users.ToList();
                foreach (var i in users)
                {
                    if (i.WishesId.Contains(MyWish.Id))
                    {
                        myUser = i;
                    }
                }
                new ShowWishForm(MyWish, myUser).Show();
                ParentForm.Hide();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var us = new UserContext())
            {
                User myUser = new User();
                var users = us.Users.ToList();
                foreach(var i in users)
                {
                    if (i.WishesId.Contains(MyWish.Id))
                    {
                        myUser = i;
                    }
                }
                new WarningForm(MyWish, myUser).Show();
                ParentForm.Hide();

            }

            

        }
    }
}
