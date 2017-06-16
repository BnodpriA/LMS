using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using System.IO;
using System.Media;

namespace LibraryManagementSystem
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        private void SearchMember_Load(object sender, EventArgs e)
        {
            //SoundPlayer sdSearchMember = new SoundPlayer("");
            //sdSearchMember.Play();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMemberDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MemoryStream ms = new MemoryStream((byte[])mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberImage"]);
            //MemoryStream ms = new MemoryStream((byte[])mc.SearchMember((Convert.ToInt32(txtMemberName.Text), (txtMemberName.Text)).Rows[0]["MemberImage"]));
            MemoryStream ms = new MemoryStream((byte[])dgvMemberDetails.SelectedRows[0].Cells["MemberImage"].Value);
            pbImage.Image = Image.FromStream(ms);
            lblMemberName.Text = dgvMemberDetails.SelectedRows[0].Cells["MemberName"].Value.ToString();
            lblContact.Text = dgvMemberDetails.SelectedRows[0].Cells["ContactNumber"].Value.ToString();
            lblEmail.Text = dgvMemberDetails.SelectedRows[0].Cells["Email"].Value.ToString();
            lblGender.Text = dgvMemberDetails.SelectedRows[0].Cells["Gender"].Value.ToString();
            lblDateOfBirth.Text = dgvMemberDetails.SelectedRows[0].Cells["DOB"].Value.ToString();
            lblJoinedDate.Text = dgvMemberDetails.SelectedRows[0].Cells["DOJ"].Value.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMemberName_TextChanged_1(object sender, EventArgs e)
        {
            dgvMemberDetails.DataSource = mc.SearchMember(txtMemberName.Text);
        }

        private void dgvMemberDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MemoryStream ms = new MemoryStream((byte[])mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberImage"]);
                //MemoryStream ms = new MemoryStream((byte[])mc.SearchMember((Convert.ToInt32(txtMemberName.Text), (txtMemberName.Text)).Rows[0]["MemberImage"]));
                MemoryStream ms = new MemoryStream((byte[])dgvMemberDetails.SelectedRows[0].Cells["MemberImage"].Value);
                pbImage.Image = Image.FromStream(ms);
                lblMemberName.Text = dgvMemberDetails.SelectedRows[0].Cells["MemberName"].Value.ToString();
                lblContact.Text = dgvMemberDetails.SelectedRows[0].Cells["ContactNumber"].Value.ToString();
                lblEmail.Text = dgvMemberDetails.SelectedRows[0].Cells["Email"].Value.ToString();
                lblGender.Text = dgvMemberDetails.SelectedRows[0].Cells["Gender"].Value.ToString();
                lblDateOfBirth.Text = dgvMemberDetails.SelectedRows[0].Cells["DOB"].Value.ToString();
                lblJoinedDate.Text = dgvMemberDetails.SelectedRows[0].Cells["DOJ"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
