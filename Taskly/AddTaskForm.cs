using System;
using Taskly.Classes;

namespace Taskly
{
    public partial class AddTaskForm : Form
    {
        public User MyUser { get; set; }
        public AddTaskForm(User MyUser)
        {
            InitializeComponent();
            this.MyUser = MyUser;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            using (var u = new UserContext())
            {
                MyTask task = new MyTask(nameTextBox.Text, descTextBox.Text, deadlineDateTimePicker1.Value);
                task.MyColor = colorComboBox.Text;
                task.UserId = MyUser.Id;

                u.Tasks.Add(task);
                u.SaveChanges();

                MyUser.TasksId.Add(task.Id);
                u.Update(MyUser);
                u.SaveChanges();

            }

            new TaskViewForm(MyUser).Show();
            Hide();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            deadlineDateTimePicker1.MinDate = DateTime.Now;
            colorComboBox.Text = "White";
        }
    }
}
