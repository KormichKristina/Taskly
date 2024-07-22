using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowWishesControl : UserControl
    {
        public User MyUser { get; set; }
        public ShowWishesControl()
        {
            InitializeComponent();
        }
        public void SetInfo()
        {
            using (var us = new UserContext())
            {
                var wishes = us.Wishes.ToList();

                foreach (var i in wishes)
                {
                    if (MyUser.WishesId.Contains(i.Id)&&!i.IsComplete)
                    {
                        flowLayoutPanel1.Controls.Add(new ShowInfoAboutWishControl(i));
                    }
                }

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddWish(MyUser).Show();
            ParentForm.Hide();
        }

        private void ShowWishesControl_Load(object sender, EventArgs e)
        {
            colorComboBox.Text = "All";
        }

        private void ColorComboBox_IndexChanged(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            if (colorComboBox.SelectedItem.ToString()!="All")
            {
                string myColor = colorComboBox.SelectedItem.ToString().Substring(5, colorComboBox.SelectedItem.ToString().Length-5);
                

                using (var us = new UserContext())
                {
                    var wishes = us.Wishes.ToList();

                    foreach (var i in wishes)
                    {
                        if (MyUser.WishesId.Contains(i.Id) && i.MyColor==myColor&&!i.IsComplete)
                        {
                            flowLayoutPanel1.Controls.Add(new ShowInfoAboutWishControl(i));
                        }
                    }

                }

            }
            else if(MyUser!=null)
            {
                SetInfo();
            }
        }

    }
}
