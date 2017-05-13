﻿using System;
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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        User user = new User();

        public void AddUserDetails()
        {
            user.Name = txtName.Text;
            user.Phone = txtPhone.Text;
            user.Address = txtAddress.Text;
            user.Education = txtEducation.Text;

            UserServices userServices = new UserServices();
            if(txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtEducation.Text == "")
            {
                MessageBox.Show("Please fill all the items");
            }
            else
            {
                if (userServices.Add(user) == 1)
                {
                    MessageBox.Show("Record Added Successfully!");
                }
                else
                {
                    MessageBox.Show("Could not store data!!");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddUserDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all the items");
            }
        }
    }
}
