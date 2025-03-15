 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumagang_Jon_Mickyl
{
    public partial class LoginForm : Form
    {
        private int loginAttempts = 0;
        private Database dbHelper = new Database(); // Using your DatabaseHelper class

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginAttempts++;
            if (loginAttempts > 5)
            {
                MessageBox.Show("Too many failed login attempts. Please reset your password using the link below.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Reset Password Link: www.example.com/resetpassword", "Reset Password Link", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;
            }

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (dbHelper.Login(username, password)) // Checking login from MySQL database
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentForm studentForm = new StudentForm();
                this.Hide();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show($"Incorrect Username or Password.\nAttempt: {loginAttempts} of 5", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
            }
        }
    }
}