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
using System.IO;
using System.Text.RegularExpressions;
using System.Media;
namespace LibraryManagementSystem
{
    public partial class MemberFrm : Form
    {
        public MemberFrm()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int Id;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    pbImage.Image = Image.FromFile(ofd.FileName);
            //}
            //else { return; }
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(ofd.FileName);

                }
                else
                {
                    MessageBox.Show("Please select a profile picture");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsValidEmailId(string InputEmail)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(InputEmail);
                if (match.Success)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String UserEmail = txtEmail.Text;
                if (txtMemberName.Text == "")
                {
                    MessageBox.Show("Provide Member name.");
                }
                else if (pbImage.Image == null)
                {
                    MessageBox.Show("Please select image profile for the member.");
                }
                else if (txtContact.Text == "")
                {
                    MessageBox.Show("Provide Contact");
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please provide the email address of the member.");
                }
                else if (IsValidEmailId(UserEmail) == false)
                {
                    MessageBox.Show("This email is not in valid format");
                    txtEmail.Text = "";
                }
                else if (cmbGender.Text == "")
                {
                    MessageBox.Show("Please select a gender.");
                }
                else
                {
                    AddMember();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dgvMemberDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvMemberDetails.SelectedRows[0].Cells["MemberId"].Value.ToString());
                txtMemberName.Text = dgvMemberDetails.SelectedRows[0].Cells["MemberName"].Value.ToString();
                txtContact.Text = dgvMemberDetails.SelectedRows[0].Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = dgvMemberDetails.SelectedRows[0].Cells["Email"].Value.ToString();
                cmbGender.Text = dgvMemberDetails.SelectedRows[0].Cells["Gender"].Value.ToString();
                dtpDOB.Text = dgvMemberDetails.SelectedRows[0].Cells["DOB"].Value.ToString();
                dtpDOJ.Text = dgvMemberDetails.SelectedRows[0].Cells["DOJ"].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgvMemberDetails.SelectedRows[0].Cells["MemberImage"].Value);
                pbImage.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MemberFrm_Load(object sender, EventArgs e)
        {
            MainForm mb = new MainForm();
            mb.gbReturnList.Visible = false;
            dgvMemberDetails.DataSource = mc.GetAllMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String UserEmail = txtEmail.Text;
                if (txtMemberName.Text == "")
                {
                    MessageBox.Show("Provide Member name.");
                }
                else if (pbImage.Image == null)
                {
                    MessageBox.Show("Please select image profile for the member.");
                }
                else if (txtContact.Text == "")
                {
                    MessageBox.Show("Provide Contact");
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please provide the email address of the member.");
                }
                else if (IsValidEmailId(UserEmail) == false)
                {
                    MessageBox.Show("This email is not in valid format");
                    txtEmail.Text = "";
                }
                else if (cmbGender.Text == "")
                {
                    MessageBox.Show("Please select a gender.");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to save changes", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        UpdateMember();
                        HelperClass.makeFieldsBlank(grbManageMembers);
                    }
                    else
                    {
                        HelperClass.makeFieldsBlank(grbManageMembers);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you really want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DeleteMember();
                    HelperClass.makeFieldsBlank(grbManageMembers);/// making field blank of all the user information fields
                }
                else
                {
                    HelperClass.makeFieldsBlank(grbManageMembers);/// making field blank of all the user information fields
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
        }

        private void MemberFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mb = new MainForm();
            mb.gbReturnList.Visible = true;
        }

        public void AddMember()
        {
            try
            {
                bool result = blc.ManageMembers(0,
                    txtMemberName.Text,
                    txtContact.Text,
                    txtEmail.Text,
                    cmbGender.Text,
                    dtpDOB.Text,
                    dtpDOJ.Text,
                    HelperClass.ImageConverter(pbImage),
                    1);
                if (result == true)
                {
                    SoundPlayer memeberAdded = new SoundPlayer("memberAdded.wav");
                    memeberAdded.Play();
                    MessageBox.Show("MEMBER INFORMATION SUCCESSFULLY ADDED");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public  void UpdateMember()
        {
            try
            {
                bool result = blc.ManageMembers(Id,
                    txtMemberName.Text,
                    txtContact.Text,
                    txtEmail.Text,
                    cmbGender.Text,
                    dtpDOB.Text,
                    dtpDOJ.Text,
                    HelperClass.ImageConverter(pbImage),
                    2);
                if (result == true)
                {
                    SoundPlayer memberUpdate = new SoundPlayer("memberUpdated.wav");
                    memberUpdate.Play();
                    MessageBox.Show("MEMBER INFORMATION SUCCESSFULLY UPDATED");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteMember()
        {
            try
            {
                bool result = blc.ManageMembers(Id,
                    txtMemberName.Text,
                    txtContact.Text,
                    txtEmail.Text,
                    cmbGender.Text,
                    dtpDOB.Text,
                    dtpDOJ.Text,
                    HelperClass.ImageConverter(pbImage),
                    3);
                if (result == true)
                {
                    SoundPlayer memberDelete = new SoundPlayer("memberDeleted.wav");
                    memberDelete.Play();
                    MessageBox.Show("MEMBER INFORMATION SUCCESSFULLY DELETED");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageMembers);
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("You cannot use alphanumreic characters in phone number");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
