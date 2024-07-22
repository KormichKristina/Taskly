using System;
using Taskly.Properties;
using Taskly.Classes;

namespace Taskly
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void goToSignInlabel_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm)?.ShowSigninControl();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            

            if (nameTextBox.Text.Length < 3 || nameTextBox.Text.Contains(' '))
            {
                MessageBox.Show("name must contain at least 3 characters without spaces");
            }
            else if (passwordTextBox.Text.Length < 3 || passwordTextBox.Text.Contains(' '))
            {
                MessageBox.Show("password must contain at least 3 characters without spaces");
            }
            else if (passwordTextBox.Text != conPasswordTextBox.Text)
            {
                MessageBox.Show("failed to confirm password");
            }
            else
            {
                User user = new User { Name = nameTextBox.Text, Password = passwordTextBox.Text,TasksCompleted=0,WishesFulfilled=0,WishesId=new List<int>(),TasksId=new List<int>() };

                using (UserContext userCon = new UserContext())
                {
                    bool isFound = false;
                    var users = userCon.Users.ToList();

                    foreach (var i in users)
                    {
                        if (i.Name == nameTextBox.Text)
                        {
                            isFound = true;
                            MessageBox.Show("this user already exists");
                        }
                    }

                    if (!isFound)
                    {
                        userCon.Add(user);
                        userCon.SaveChanges();
                        MessageBox.Show("you have successfully registered");
                        new TaskViewForm(user).Show();
                        ParentForm.Hide();
                    }


                }


            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeButton2_Click(object sender, EventArgs e)
        {
            if (!conPasswordTextBox.UseSystemPasswordChar)
            {
                eyeButton2.Image = Resources.hidden;
                conPasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                eyeButton2.Image = Resources.eye;
                conPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void eyeButton1_Click(object sender, EventArgs e)
        {
            if (!passwordTextBox.UseSystemPasswordChar)
            {
                eyeButton1.Image = Resources.hidden;
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                eyeButton1.Image = Resources.eye;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
