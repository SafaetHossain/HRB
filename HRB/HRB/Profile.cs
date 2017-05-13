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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        User user = new User();
        UserServices userServices = new UserServices();
        private void EditUser(User user)
        {
            if (userServices.update(user) == 1)
            {
                MessageBox.Show("Record are updated");
            }
            else
            {
                MessageBox.Show("Record could not update");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "EditEmployee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                user.Name = txtName.Text;
                user.Phone = txtPhone.Text;
                user.Address = txtAddress.Text;
                user.Education = txtEducation.Text;
                EditUser(user);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtPhone.Text = LogInForm.userPhone;

            List <User> userList = new List <User> ();
            userList = userServices.GetAllByPhone(LogInForm.userPhone);

            foreach (User user in userList)
            {
                txtName.Text = user.Name.ToString();
                txtPhone.Text = user.Phone.ToString();
                txtAddress.Text = user.Address.ToString();
                txtEducation.Text = user.Education.ToString();
            }
        }
    }
}
