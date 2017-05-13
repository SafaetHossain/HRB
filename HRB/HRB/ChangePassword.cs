using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRB.Data;
using HRB.Core;

namespace HRB
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            txtCurrentPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }
        UserServices userServices = new UserServices();
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text.Trim().Length == 0))
            {
                MessageBox.Show("Please enter current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((txtNewPassword.Text.Trim().Length == 0))
            {
                MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtConfirmPassword.Text.Trim().Length == 0))
            {
                MessageBox.Show("Please confirm new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtNewPassword.TextLength < 5))
            {
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else if ((txtNewPassword.Text != txtConfirmPassword.Text))
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Text = "";
                txtCurrentPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else if ((txtCurrentPassword.Text == txtNewPassword.Text))
            {
                MessageBox.Show("Password is same.Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {
                if (userServices.UpdatePassword(lblPhone.Text, txtNewPassword.Text) > 0)
                {
                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewPassword.Text = "";
                    txtCurrentPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("invalid userID or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtCurrentPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
            }

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblPhone.Text = LogInForm.userPhone;
        }
    }
}
