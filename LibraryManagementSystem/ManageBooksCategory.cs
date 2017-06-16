using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using BusinessLogicLayer;
using DataAccessLayer;
namespace LibraryManagementSystem
{
    public partial class ManageBooksCategory : Form
    {
        public ManageBooksCategory()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        BookCategoryClass bcc = new BookCategoryClass();
        public int Id;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCategoryName.Text == "")///Checking empty field validation before addition operation
                {
                    MessageBox.Show("Provide Category Name.");
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Provide Description.");
                }
                else if (HelperClass.CheckExistence(dgvCategoryDetails, "CategoryName", txtCategoryName) == true)
                {
                    MessageBox.Show("This Category Already exit");
                    HelperClass.makeFieldsBlank(grpBookCategoryDetails);
                }

                else
                {
                    AddBookCategory();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddBookCategory()
        {
            try
            {
                bool result = blc.ManageBooksCategory(0,
                    txtCategoryName.Text,
                    txtDescription.Text,
                    1);
                if (result == true)
                {
                    SoundPlayer categoryAdded = new SoundPlayer("bookCategoryAdded.wav");
                    categoryAdded.Play();
                    MessageBox.Show("BOOK CATEGORY SUCCESSFULLY CREATED");
                    dgvCategoryDetails.DataSource = bcc.GetAllCategories();
                    HelperClass.makeFieldsBlank(grpBookCategoryDetails);

                }
                else { MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ManageBooksCategory_Load(object sender, EventArgs e)
        {
            dgvCategoryDetails.DataSource = bcc.GetAllCategories();
            MainForm frm = new MainForm();
            frm.gbReturnList.Visible = false;
        }

        private void dgvCategoryDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvCategoryDetails.SelectedRows[0].Cells["CategoryId"].Value.ToString());
                txtCategoryName.Text = dgvCategoryDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                txtDescription.Text = dgvCategoryDetails.SelectedRows[0].Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCategoryName.Text == "")///Checking empty field validation before addition operation
                {
                    MessageBox.Show("Provide Category Name.");
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Provide Description.");
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to save changes", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        UpdateBookCategory();
                        HelperClass.makeFieldsBlank(grpBookCategoryDetails);
                    }
                    else
                    {
                        HelperClass.makeFieldsBlank(grpBookCategoryDetails);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateBookCategory()
        {
            try
            {
                bool result = blc.ManageBooksCategory(Id,
                    txtCategoryName.Text,
                    txtDescription.Text,
                   2);
                if (result == true)
                {
                    SoundPlayer categoryUpdated = new SoundPlayer("bookCategoryUpdated.wav");
                    categoryUpdated.Play();
                    MessageBox.Show("BOOK CATEGORY SUCCESSFULLY UPDATED");
                    dgvCategoryDetails.DataSource = bcc.GetAllCategories();
                    HelperClass.makeFieldsBlank(grpBookCategoryDetails);

                }
                else { MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DeleteBookCategory();
                HelperClass.makeFieldsBlank(grpBookCategoryDetails);
            }
            else
            {

                HelperClass.makeFieldsBlank(grpBookCategoryDetails);
                return;
            }
            
        }
        public void DeleteBookCategory()
        {
            try
            {
                bool result = blc.ManageBooksCategory(Id,
                    txtCategoryName.Text,
                    txtDescription.Text,
                   3);
                if (result == true)
                {
                    SoundPlayer bookCategoryDeleted = new SoundPlayer("bookCategoryDeleted.wav");
                    bookCategoryDeleted.Play();
                    MessageBox.Show("BOOK CATEGORY SUCCESSFULLY DELETED");
                    dgvCategoryDetails.DataSource = bcc.GetAllCategories();
                    HelperClass.makeFieldsBlank(grpBookCategoryDetails);

                }
                else { MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm frm = new MainForm();
            frm.gbReturnList.Visible = true;
        }
    }
}
