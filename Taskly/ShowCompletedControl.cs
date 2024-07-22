using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class ShowCompletedControl : UserControl
    {
        public User MyUser { get; set; }
        public ShowCompletedControl()
        {
            InitializeComponent();
        }

        private void ShowCompletedControl_Load(object sender, EventArgs e)
        {
            sortComboBox.Text = "All";
        }
        private void SortComboBox_IndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (sortComboBox.SelectedItem.ToString() == "All"&&MyUser!=null)
            {
                SetInfo();
            }
            else if(sortComboBox.SelectedItem.ToString() == "Only wishes")
            {
                using (var us = new UserContext())
                {
                    var wishes = us.Wishes.ToList();

                    foreach (var i in wishes)
                    {
                        if (MyUser.WishesId.Contains(i.Id) && i.IsComplete)
                        {
                            flowLayoutPanel1.Controls.Add(new ShowInfoAboutWishControl(i));
                        }
                    }

                }
            }
            else if(sortComboBox.SelectedItem.ToString() == "Only tasks")
            {
                using (var us = new UserContext())
                {
                    var tasks = us.Tasks.ToList();

                    foreach (var i in tasks)
                    {
                        if (MyUser.TasksId.Contains(i.Id) && i.IsComplete)
                        {
                            flowLayoutPanel1.Controls.Add(new TaskControl(i));
                        }
                    }

                }
            }
        }
        public void SetInfo()
        {
            using (var us = new UserContext())
            {
                var wishes = us.Wishes.ToList();

                foreach (var i in wishes)
                {
                    if (MyUser.WishesId.Contains(i.Id) && i.IsComplete)
                    {
                        flowLayoutPanel1.Controls.Add(new ShowInfoAboutWishControl(i));
                    }
                }

                var tasks = us.Tasks.ToList();
                foreach(var i in tasks)
                {
                    if (MyUser.TasksId.Contains(i.Id)&&i.IsComplete)
                    {
                        flowLayoutPanel1.Controls.Add(new TaskControl(i));
                    }
                }

            }
        }
    }
}
