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
namespace LibraryManagementSystem
{
    public partial class ManageCompanyInfoFrm : Form
    {
        public ManageCompanyInfoFrm()
        {
            InitializeComponent();
        }
        CompanyInfoClass cic = new CompanyInfoClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int Id;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                { pbLogo.Image = Image.FromFile(ofd.FileName);
                
                }
                else
                {
                    MessageBox.Show("Please select a logo");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ManageCompanyInfoFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (cic.GetCompanyInfo().Rows.Count > 0)
                {
                    Id = Convert.ToInt32(cic.GetCompanyInfo().Rows[0]["CompanyId"].ToString());
                    txtCompanyName.Text = cic.GetCompanyInfo().Rows[0]["CompanyName"].ToString();
                    txtAddress.Text = cic.GetCompanyInfo().Rows[0]["Address"].ToString();
                    txtContact.Text = cic.GetCompanyInfo().Rows[0]["Contact"].ToString();
                    txtEmail.Text = cic.GetCompanyInfo().Rows[0]["Email"].ToString();
                    txtVat.Text = cic.GetCompanyInfo().Rows[0]["VatRegistrationNumber"].ToString();
                    txtPan.Text = cic.GetCompanyInfo().Rows[0]["PanNumber"].ToString();
                    MemoryStream ms = new MemoryStream((byte[])cic.GetCompanyInfo().Rows[0]["Logo"]);
                    pbLogo.Image = Image.FromStream(ms);
                    btnAddInfo.Enabled = false;

                }
                else
                {
                    btnAddInfo.Enabled = true;
                    btnUpdateInfo.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected void AddCompanyInfo()
        {
            try
            {
                bool result = blc.ManageCompanyInfo(0, txtCompanyName.Text,
                txtAddress.Text,
                txtContact.Text,
                txtEmail.Text,
                txtVat.Text,
                txtPan.Text,
                HelperClass.ImageConverter(pbLogo), 1);
                if (result == true)
                {
                    MessageBox.Show("COMPANY INFORMATION SUCCESSFULLY SAVED");
                    btnAddInfo.Enabled = false;
                    btnUpdateInfo.Enabled = true;
                }
                else { MessageBox.Show("ERROR IN PROCESSING THE REQUEST"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Provide the name of the Comapny");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Provide Address of the Company");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Provide Email address of the Company");
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Provide Contact Number of the Company");
            }
            else if (txtPan.Text == "")
            {
                MessageBox.Show("Provide Pan number of the company");
            }
            else if (txtVat.Text == "")
            {
                MessageBox.Show("Provide VAT Redg Number");
            }
            else
            {
                AddCompanyInfo();
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("Provide the name of the Comapny");
                }
                else if(txtAddress.Text=="")
                {
                    MessageBox.Show("Provide Address of the Company");
                }
                else if (txtEmail.Text=="")
                {
                    MessageBox.Show("Provide Email address of the Company");
                }
                else if(txtContact.Text=="")
                {
                    MessageBox.Show("Provide Contact Number of the Company");
                }
                else if(txtPan.Text=="")
                {
                    MessageBox.Show("Provide Pan number of the company");
                }
                else if (txtVat.Text=="")
                {
                    MessageBox.Show("Provide VAT Redg Number");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to save changes?", "Confirms Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr==DialogResult.Yes)
                    {
                        UpdateCompanyInfo();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        protected void UpdateCompanyInfo()
        {
            try
            {
                bool result = blc.ManageCompanyInfo(Id, txtCompanyName.Text,
                txtAddress.Text,
                txtContact.Text,
                txtEmail.Text,
                txtVat.Text,
                txtPan.Text,
                HelperClass.ImageConverter(pbLogo), 2);
                if (result == true)
                {
                    MessageBox.Show("COMPANY INFORMATION SUCCESSFULLY SAVED");
                    btnAddInfo.Enabled = false;
                    btnUpdateInfo.Enabled = true;
                }
                else { MessageBox.Show("ERROR IN PROCESSING THE REQUEST"); }
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
    }
}