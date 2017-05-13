using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRB.Entity;
using HRB.Core;

namespace HRB
{
    public partial class LogInForm : Form
    {
        UserServices userServices = new UserServices();
        public LogInForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        MainForm mainForm = new MainForm();
        public static string userPhone;
        public static string userName;
        public static string userAddress;
        public static string userEducation;
        private void LoginCheck()
        {
            List<User> userList = new List<User>();
            userList = userServices.GetAllByPhone(txtUserId.Text);
            foreach (User user in userList)
            {
                {
                    if (txtUserId.Text == user.Phone && txtPassword.Text == user.Password)
                    {
                        userName = user.Name;
                        userPhone = user.Phone;
                        userAddress = user.Address;
                        userEducation = user.Education;
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtUserId.Clear();
                        txtPassword.Clear();
                        MessageBox.Show("Please enter a valid combination of ID and Password");
                    }
                }
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
