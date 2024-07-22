using Taskly.Properties;

namespace Taskly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            loginControl1 = new LoginControl();
            signInControl1 = new SignInControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Resources.task;
            pictureBox1.Location = new Point(346, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // loginControl1
            // 
            loginControl1.BackColor = Color.White;
            loginControl1.Location = new Point(0, 0);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(347, 371);
            loginControl1.TabIndex = 2;
            // 
            // signInControl1
            // 
            signInControl1.Location = new Point(0, 0);
            signInControl1.Name = "signInControl1";
            signInControl1.Size = new Size(347, 371);
            signInControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            ClientSize = new Size(632, 371);
            Controls.Add(signInControl1);
            Controls.Add(loginControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private LoginControl loginControl1;
        private SignInControl signInControl1;
    }
}
