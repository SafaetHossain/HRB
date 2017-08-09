using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region ToolStripMenuItem

        #region FileToolStripMenuItem
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHuman addHuman = new AddHuman();
            addHuman.Show();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region ProfileToolStripMenuItem
        private void profileEditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
        private void passwordChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        #endregion

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        #region Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            //toolStripLabel1.Text = LogInForm.userName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #endregion
        #region imageToolStripMenuItem
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
