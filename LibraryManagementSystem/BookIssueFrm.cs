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
using System.Data.SqlClient;
using System.Media;
namespace LibraryManagementSystem
{
    public partial class BookIssueFrm : Form
    {
        public BookIssueFrm()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        BookClass bc = new BookClass();
        BookIssueClass bic = new BookIssueClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int Id;

        public string BookName, Author, MemberName;
        private void txtMemberId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblMemberName.Text = mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberName"].ToString();
                MemoryStream ms = new MemoryStream((byte[])mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberImage"]);
                pbImage.Image = Image.FromStream(ms);
                pnlMember.Visible = true;
               
            }
            catch (Exception)
            {


            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (txtISBN.Text != "")
            {
                try
                {
                    //dgvBookDetails.DataSource = bc.GetAllBooks();
                    dgvBookDetails.DataSource = bc.GetBookDetailsByBookName(txtISBN.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
              
                dgvBookDetails.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lblBookName.Text = bc.AvaibleDate(txtISBN.Text);
            pnlBooks.Visible = true;
        }

        public void dgvBookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               BookName = dgvBookDetails.SelectedRows[0].Cells[0].Value.ToString();
               Author = dgvBookDetails.SelectedRows[0].Cells["AuthorName"].Value.ToString();
               lblBookName.Text = dgvBookDetails.SelectedRows[0].Cells["BookName"].Value.ToString();
               txtISBN.Text = dgvBookDetails.SelectedRows[0].Cells["ISBN"].Value.ToString();

               if (HelperClass.CheckExistence(dgvIssueDetails, "ISBN", txtISBN) == true)
               {
                   lblStatus.Text = "Unavailable";
                   lblStatus.ForeColor.Equals("red");
                   dgvBookDetails.Visible = false;
                   lblAvailableDate.Text = dgvIssueDetails.Rows[0].Cells["ReturnDate"].Value.ToString();
               }
               else
               {

                   lblStatus.Text = "Available";
                   lblStatus.ForeColor.Equals("green");
                   lblAvailableDate.Text = DateTime.Now.Date.ToShortDateString();
               }
               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BookIssueFrm_Load(object sender, EventArgs e)
        {
            //dgvBookDetails.DataSource = bc.GetBookDetailsByBookName(txtISBN.Text);
            dgvIssueDetails.DataSource = bic.GetAllIssuedBooks();
        }

        public void IssueBook()
        {
            //MemberName = mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).ToString();
            //SqlCommand cmd = new SqlCommand("select MemberName from MemberTable where MemberId =" + MemberName);
            //cmd.CommandType = CommandType.Text;
            MemberName = lblMemberName.Text.ToString();

            try
            {
                bool result = blc.ManageIssuedBooks(0, Convert.ToInt32(txtMemberId.Text), txtISBN.Text, dtpIssuedDate.Text, dtpReturnDate.Text, 1);
                if (result == true)
                {
                    SoundPlayer bookIssued = new SoundPlayer("bookIssued.wav");
                    bookIssued.Play();
                    MessageBox.Show( "The book named " + BookName + " of Author " + Author+ " has been issued to " + MemberName);
                    dgvIssueDetails.DataSource = bic.GetAllIssuedBooks();
                    HelperClass.makeFieldsBlank(groupBox1);
                    pbImage.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(groupBox1);
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            IssueBook();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CancelIssue()
        {
            //if (dgvIssueDetails.SelectedRows[0].Cells["IssuedDate"].ToString() == DateTime.Now.Date)
            //{
            //    SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("select * from BookIssueTable where IssueId = (select max(IssueId) from BookIssueTable)");
            //    cmd.CommandType = CommandType.Text;
                            
            //    conn.Close();
            //}

            try
            {
                bool result = blc.ManageIssuedBooks(Id, Convert.ToInt32(txtMemberId.Text), txtISBN.Text, dtpIssuedDate.Text, dtpReturnDate.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("The book named " + BookName + " of Author " + Author + " has been cancelled from being issued to " + lblMemberName.Text.ToString());
                    dgvIssueDetails.DataSource = bic.GetAllIssuedBooks();
                    HelperClass.makeFieldsBlank(groupBox1);
                    pbImage.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    HelperClass.makeFieldsBlank(groupBox1);
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvIssueDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    Id = Convert.ToInt32(dgvIssueDetails.SelectedRows[0].Cells["IssueId"].Value.ToString());
                    txtMemberId.Text = dgvIssueDetails.SelectedRows[0].Cells["MemberId"].Value.ToString();
                    txtISBN.Text = dgvIssueDetails.SelectedRows[0].Cells["ISBN"].Value.ToString();
                   // lblBookName.Text = dgvIssueDetails.SelectedRows[0].Cells["BookName"].ToString();
                    //dtpIssuedDate.Text = (dgvIssueDetails.SelectedRows[0].Cells["IssuedDate"].ToString());
                    //dtpReturnDate.Text = dgvIssueDetails.SelectedRows[0].Cells["ReturnDate"].ToString();
                 if (dgvIssueDetails.SelectedRows[0].Cells["IssuedDate"].Value.ToString() == DateTime.Now.Date.ToString())
                 {
                     //txtMemberId.Text = dgvIssueDetails.SelectedRows[0].Cells["MemberId"].ToString();
                     //txtISBN.Text = dgvIssueDetails.SelectedRows[0].Cells["ISBN"].ToString();
                     //lblBookName.Text = dgvIssueDetails.SelectedRows[0].Cells["BookName"].ToString();
                     //dtpIssuedDate.Text = (dgvIssueDetails.SelectedRows[0].Cells["IssuedDate"].ToString());
                     //dtpReturnDate.Text = dgvIssueDetails.SelectedRows[0].Cells["ReturnDate"].ToString();
                        btnUndoIssue.Enabled = true;
                    }
                 else
                 {
                     MessageBox.Show("This book can not selected for issue cacellation.");
                     HelperClass.makeFieldsBlank(groupBox1);
                     btnUndoIssue.Enabled = false;
                 }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "")
            {
                MessageBox.Show("Please provide the member to whom book is to be issued.");
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Please provide the ISBN of the book to be issued.");
            }
            else if (lblStatus.Text == "Unavailable")
            {
                MessageBox.Show("This book is not Available");
                txtISBN.Text = "";
                txtISBN.Focus();
            }
            else
            {
               
                IssueBook();
            }

        }

        private void btnUndoIssue_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "")
            {
                MessageBox.Show("Please provide the member to whom book is to be issued.");
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Please provide the ISBN of the book to be issued.");
            }
            else
            CancelIssue();
        }
    }

}