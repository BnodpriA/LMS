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
    public partial class ManageBooksFrm : Form
    {
        public ManageBooksFrm()
        {
            InitializeComponent();
        }
        BookClass bc = new BookClass();
        BookCategoryClass bcc = new BookCategoryClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        MainForm frm = new MainForm();
        public int Id;
        private void ManageBooksFrm_Load(object sender, EventArgs e)
        {
            try
            {
                frm.gbReturnList.Visible = false;
                cmbCategory.DataSource = bcc.GetAllCategories();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = -1;
                dgvBookDetails.DataSource = bc.GetAllBooks();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtBookName.Text == "")
            {
                MessageBox.Show("Provide Book Name.");
            }
            else if(txtISBN.Text == "")
            {
                MessageBox.Show("Provide ISBN of the book.");
            }
            else if (txtAuthorName.Text == "")
            {
                MessageBox.Show("Provide the Author's name of the book.");
            }
            else if (txtEdition.Text == "")
            {
                MessageBox.Show("Provide Edition Information of the book.");
            }
            else if (cmbCategory.Text == "")
            {
                MessageBox.Show("Select a book Category.");
            }
            else
            {
                AddBook();
            }
        }

        public void AddBook()
        {
            try
            {
                bool result = blc.ManageBooks(0,
                    Convert.ToInt32(cmbCategory.SelectedValue.ToString()),
                    txtBookName.Text,
                    txtISBN.Text,
                    txtAuthorName.Text,
                    dtpPublishedDate.Text,
                    txtEdition.Text,
                    1);
                if (result == true)
                {
                    SoundPlayer bookAdded = new SoundPlayer("bookAdded.wav");
                    bookAdded.Play();
                    MessageBox.Show("BOOK INFORMATION SUCCESSFULLY SAVED");
                    dgvBookDetails.DataSource = bc.GetAllBooks();
                    HelperClass.makeFieldsBlank(grbManageBooks);
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageBooks);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvBookDetails.SelectedRows[0].Cells["BookId"].Value.ToString());
                cmbCategory.Text = dgvBookDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                txtBookName.Text = dgvBookDetails.SelectedRows[0].Cells["BookName"].Value.ToString();
                txtISBN.Text = dgvBookDetails.SelectedRows[0].Cells["ISBN"].Value.ToString();
                txtAuthorName.Text = dgvBookDetails.SelectedRows[0].Cells["AuthorName"].Value.ToString();
                dtpPublishedDate.Text = dgvBookDetails.SelectedRows[0].Cells["PublishedDate"].Value.ToString();
                txtEdition.Text = dgvBookDetails.SelectedRows[0].Cells["Edition"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "")
            {
                MessageBox.Show("Provide Book Name.");
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Provide ISBN of the book.");
            }
            else if (txtAuthorName.Text == "")
            {
                MessageBox.Show("Provide the Author's name of the book.");
            }
            else if (txtEdition.Text == "")
            {
                MessageBox.Show("Provide Edition Information of the book.");
            }
            else if (cmbCategory.Text == "")
            {
                MessageBox.Show("Select a book Category.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UpdateBook();
                    HelperClass.makeFieldsBlank(grbManageBooks);
                }
                else
                {
                    HelperClass.makeFieldsBlank(grbManageBooks);
                    return;
                }
            }
        }

        public void UpdateBook()
        {
            try
            {
                bool result = blc.ManageBooks(Id,
                    Convert.ToInt32(cmbCategory.SelectedValue.ToString()),
                    txtBookName.Text,
                    txtISBN.Text,
                    txtAuthorName.Text,
                    dtpPublishedDate.Text,
                    txtEdition.Text,
                   2);
                if (result == true)
                {
                    SoundPlayer bookUpdated = new SoundPlayer("bookUpdated.wav");
                    bookUpdated.Play();
                    MessageBox.Show("BOOK INFORMATION SUCCESSFULLY UPDATED");
                    dgvBookDetails.DataSource = bc.GetAllBooks();
                    HelperClass.makeFieldsBlank(grbManageBooks);
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageBooks);
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
                    DeleteBook();
                    HelperClass.makeFieldsBlank(grbManageBooks);/// making field blank of all the user information fields
                }
                else
                {
                    HelperClass.makeFieldsBlank(grbManageBooks);/// making field blank of all the user information fields
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteBook()
        {
            try
            {
                bool result = blc.ManageBooks(Id,
                    Convert.ToInt32(cmbCategory.SelectedValue.ToString()),
                    txtBookName.Text,
                    txtISBN.Text,
                    txtAuthorName.Text,
                    dtpPublishedDate.Text,
                    txtEdition.Text,
                    3);
                if (result == true)
                {
                    SoundPlayer deleteBook = new SoundPlayer("bookDeleted.wav");
                    deleteBook.Play();
                    MessageBox.Show("BOOK INFORMATION SUCCESSFULLY DELETED");
                    dgvBookDetails.DataSource = bc.GetAllBooks();
                    HelperClass.makeFieldsBlank(grbManageBooks);
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(grbManageBooks);
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
            frm.gbReturnList.Visible = true;
        }
    }
}
