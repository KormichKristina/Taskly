using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class AddWish : Form
    {
        public User MyUser { get; set; }
        public AddWish(User us)
        {

            InitializeComponent();
            MyUser = us;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Wish myWish = new Wish(nameTextBox.Text, descTextBox.Text, howWillYouFulfillTextBox.Text);
            myWish.MyColor = colorComboBox.Text;
            myWish.UserId = MyUser.Id;

            using (var us = new UserContext())
            {
                us.Wishes.Add(myWish);
                us.SaveChanges();

                MyUser.WishesId.Add(myWish.Id);
                us.Update(MyUser);
                us.SaveChanges();

            }
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void AddWish_Load(object sender, EventArgs e)
        {
            colorComboBox.Text = "White";
        }
    }
}
