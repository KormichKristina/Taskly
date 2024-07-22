using System;
using Taskly.Classes;
using Taskly.Properties;

namespace Taskly
{
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            using (UserContext userCon = new UserContext())
            {
                var users = userCon.Users.ToList();

                bool isFound = false;
                foreach(var i in users)
                {
                    if (i.Name==nameTextBox.Text&&passwordTextBox.Text==i.Password)
                    {
                        isFound = true;
                        MessageBox.Show("Welcome!");
                        new TaskViewForm(i).Show();
                        ParentForm.Hide();
                    }
                }
                if (!isFound)
                {
                    MessageBox.Show("this user doesnt exist");
                }

            }
        }

        private void eyeButton_Click(object sender, EventArgs e)
        {

            if (!passwordTextBox.UseSystemPasswordChar)
            {
                eyeButton.Image = Resources.hidden;
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                eyeButton.Image = Resources.eye;
                passwordTextBox.UseSystemPasswordChar = false;
            }


        }

        private void goToLoginLabel_Click_1(object sender, EventArgs e)
        {
            ((Form1)ParentForm)?.ShowLoginControl();
        }
    }
}
