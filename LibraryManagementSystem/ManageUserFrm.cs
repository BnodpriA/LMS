using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Media;
namespace LibraryManagementSystem
{
    public partial class ManageUserFrm : Form
    {
        public ManageUserFrm()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int Id;
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Provide Username.");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Provide Password");
                }
                else if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please confirm password");
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords doesnot match");
                }
                else if (cmbRole.Text == "")
                {
                    MessageBox.Show("Please select the role of the user");
                }

                else
                {
                    AddUser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void ManageUserFrm_Load(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.gbReturnList.Visible = false;
            dgvUserDetails.DataSource = uc.GetAllUsers();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Provide Username.");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Provide Password");
                }
                else if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please confirm password");
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords doesnot match");
                }
                else if (cmbRole.Text == "")
                {
                    MessageBox.Show("Please select the role of the user");
                }
                
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to save changes", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        UpdateUser();
                        HelperClass.makeFieldsBlank(grpManageUser);
                    }
                    else
                    {
                        HelperClass.makeFieldsBlank(grpManageUser);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void dgvUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvUserDetails.SelectedRows[0].Cells["UserId"].Value.ToString());
                txtUserName.Text = dgvUserDetails.SelectedRows[0].Cells["UserName"].Value.ToString();
                txtPassword.Text = dgvUserDetails.SelectedRows[0].Cells["Password"].Value.ToString();
                txtConfirmPassword.Text = dgvUserDetails.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbRole.Text = dgvUserDetails.SelectedRows[0].Cells["Role"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you really want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DeleteUser();
                    HelperClass.makeFieldsBlank(grpManageUser);/// making field blank of all the user information fields
                }
                else
                {
                    HelperClass.makeFieldsBlank(grpManageUser);/// making field blank of all the user information fields
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm fm = new MainForm();
            fm.gbReturnList.Visible = true;
        }
        public bool UserExistence()///Checking the existence of Username
        {

            bool result = false;
            for (int i = 0; i < dgvUserDetails.Rows.Count; i++)
            {
                String Username = dgvUserDetails.Rows[i].Cells["UserName"].Value.ToString();
                if (Username == txtUserName.Text)
                {
                    return true;
                }
                else { return false; }
            }
            return result;

        }

        public void AddUser()
        {
            try
            {
                bool result = blc.ManageUsers(0,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text,
                    1);
                if (result == true)
                {
                    SoundPlayer userAdded = new SoundPlayer("userAdded.wav");
                    //userAdded.Play();
                    MessageBox.Show("USER SUCCESSFULLY ADDED");
                    dgvUserDetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING THE USER");
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateUser()
        {
            try
            {
                bool result = blc.ManageUsers(Id,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text,
                   2);
                if (result == true)
                {
                    SoundPlayer userUpated = new SoundPlayer("userModified.wav");
                    userUpated.Play();
                    MessageBox.Show("USER SUCCESSFULLY UPDATED");
                    dgvUserDetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING THE USER");
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteUser()
        {
            try
            {
                bool result = blc.ManageUsers(Id,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text,
                   3);
                if (result == true)
                {
                    SoundPlayer deleteUser = new SoundPlayer("userDeleted.wav");
                    MessageBox.Show("USER SUCCESSFULLY DELETED");
                    dgvUserDetails.DataSource = uc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING THE USER");
                    HelperClass.makeFieldsBlank(grpManageUser);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
