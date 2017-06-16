using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using System.Media;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();
        int progress = 0;
        private void txtmemberName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = null;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = null;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor.Equals("Red");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                SoundPlayer sdEmptyUsername = new SoundPlayer("provideUsername.wav");
                sdEmptyUsername.Play();
                MessageBox.Show("Provide Username");
            }
            else if (txtPassword.Text == "")
            {
                SoundPlayer sdProvidePassword = new SoundPlayer("providePassword.wav");
                sdProvidePassword.Play();
                MessageBox.Show("Provide password for " + txtUserName.Text.ToString());
            }
            else
               //Login(); 
                Progress();
        }

        public void Progress()
        {

            try
            {
                PB_Timer.Enabled = true;
                PB_Timer.Interval = 20;
                pbLogin.Visible = true;
                SoundPlayer sdProcess = new SoundPlayer("VerifyingAuthentication.wav");
                sdProcess.Play();
                //Role();
               // Login();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Login()
        {
            try
            {
                DataTable login = uc.Login(txtUserName.Text, txtPassword.Text);
                if (login.Rows.Count > 0)
                {
                    this.Hide();
                    Role();
                }
                else
                {
                    SoundPlayer sdAuthenticationFailed = new SoundPlayer("IncorrectUsernamePassword.wav");
                    sdAuthenticationFailed.Play();
                    MessageBox.Show("Username or Password in correct");
                    pbLogin.Visible = false;
                    progress = 0;
                }

               // if (txtUserName.Text == "Binod" && txtPassword.Text == "binod" || txtUserName.Text == "Bunny" && txtPassword.Text == "bunny")
               //    {
               //        //Progress();
               //       Role(); 
               //    }
               //else
               //    {
                      
               //    }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        public void Role()
        {
            DataTable UserType = uc.UserType(txtUserName.Text, txtPassword.Text);
            String Role = UserType.Rows[0][0].ToString();
            if (UserType.Rows.Count > 0)
            {
                Role = UserType.Rows[0][0].ToString();
            }
            if (Role == "Admin")
            {
                MainForm frm = new MainForm();
                frm.Show();
                frm.lblLoggedUser.Text = txtUserName.Text.ToString();
                frm.sETTINGToolStripMenuItem.Enabled = true;

            }
            else
            {
                MainForm frm = new MainForm();
                SearchUsers su = new SearchUsers();
             //   su.dgvUsersDetails.Columns[3].Visible = false;
                frm.Show();
                frm.lblLoggedUser.Text = txtUserName.Text.ToString();
                frm.sETTINGToolStripMenuItem.Enabled = false;
                frm.uSERSToolStripMenuItem.Enabled = false;
                

            }

            //if (txtUserName.Text == "Binod")
            //{
            //       this.Hide();
            //       MainForm frm = new MainForm();
            //       frm.Show();
            //       frm.lblLoggedUser.Text = txtUserName.Text.ToString();
            //}
            //else
            //{
            //    MainForm frm = new MainForm();
            //    frm.Show();
            //    frm.lblLoggedUser.Text = txtUserName.Text.ToString();
            //    frm.sETTINGToolStripMenuItem.Enabled = false;
            //}
            
        }

        private void PB_Timer_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {

              //  this.Hide();
                PB_Timer.Enabled = false;
                PB_Timer.Stop();
               // Progress();
                Login();
            }

            else
            {
                pbLogin.Value = progress;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SoundPlayer sdEnterUserPassword = new SoundPlayer("enterUsernamePassword.wav");
            sdEnterUserPassword.Play();
        }
    }
}
