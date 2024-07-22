namespace Taskly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signInControl1.Visible = false;
            loginControl1.Visible = true;
        }
        public void ShowLoginControl()
        {
            signInControl1.Visible = false;
            loginControl1.Visible = true;
        }
        public void ShowSigninControl()
        {
            signInControl1.Visible = true;
            loginControl1.Visible = false;
        }
    }
}
