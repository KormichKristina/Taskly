using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taskly.Classes;

namespace Taskly
{
    public partial class RedactForm : Form
    {
        public User MyUser { get; set; }
        public RedactForm(User my)
        {
            InitializeComponent();
            MyUser = my;

        }
        private void applyButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text.Length < 3 || nameTextBox.Text.Contains(' '))
            {
                MessageBox.Show("name must contain at least 3 characters without spaces");
            }
            else if (passwordTextBox.Text.Length < 3 || passwordTextBox.Text.Contains(' '))
            {
                MessageBox.Show("password must contain at least 3 characters without spaces");
            }
            else
            {
                MyUser.Name = nameTextBox.Text;
                MyUser.Password = passwordTextBox.Text;

                using (var us = new UserContext())
                {
                    us.Update(MyUser);
                    us.SaveChanges();
                }
                MessageBox.Show("you have successfully changed the data!!");
                new TaskViewForm(MyUser).Show();
                Hide();
            }

            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void RedactForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = MyUser.Name;
            passwordTextBox.Text = MyUser.Password;

        }
    }
}
