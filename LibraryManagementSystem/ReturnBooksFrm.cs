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
using System.Media;

namespace LibraryManagementSystem
{
    public partial class ReturnBooksFrm : Form
    {
        public ReturnBooksFrm()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        MemberClass mc = new MemberClass();
        BookIssueClass bic = new BookIssueClass();
        BookReturnClass brc = new BookReturnClass();
        public int MemberId;
        public string MemberName;
        public string BookName;
        public string AuthorName;

        private void txtMemberId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblMemberName.Text = mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberName"].ToString();
                MemoryStream ms = new MemoryStream((byte[])mc.GetMemberById(Convert.ToInt32(txtMemberId.Text)).Rows[0]["MemberImage"]);
                pbImage.Image = Image.FromStream(ms);
                pnlMember.Visible = true;
                dgvDetailsOfBooks.DataSource = bic.GetAllIssuedBookByMemeberId(Convert.ToInt32(txtMemberId.Text));
                dgvReturedBookDetails.DataSource = brc.GetReturnedBooksByMemberId(Convert.ToInt32(txtMemberId.Text));
                dgvDetailsOfBooks.Columns["chkChoose"].Visible = true;
                if (true)
                {
                    
                }
                else{}
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnBooksFrm_Load(object sender, EventArgs e)
        {
            dgvReturedBookDetails.DataSource = brc.GetReturnedBooks();
        }

        public void ReturnBook() 
        {
            try
            {
                MemberName = lblMemberName.Text.ToString();
                //   // MemberId = Convert.ToInt32(dgvDetailsOfBooks.SelectedRows[0].Cells["MemberId"].Value.ToString());
                //    txtMemberId.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["MemberId"].Value.ToString();
                //    ISBN = dgvDetailsOfBooks.SelectedRows[0].Cells["ISBN"].Value.ToString();
                //    IssueDate = (dgvDetailsOfBooks.SelectedRows[0].Cells["IssuedDate"].Value.ToString());
                //    ReturnDate = (dgvDetailsOfBooks.SelectedRows[0].Cells["ReturnDate"].Value.ToString());
                //    ActualReturnDate =(DateTime.Now.Date.ToString());
                //    string isbn = ISBN.ToString();
                txtMemberId.Text = txtMemberId.Text;
                lblBookName.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["BookName"].Value.ToString();
                lblISBN.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["ISBN"].Value.ToString();
                lblIssuedDate.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["IssuedDate"].Value.ToString();
                lblReturnDate.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["ReturnDate"].Value.ToString();
                lblActualReturnDate.Text = DateTime.Now.Date.ToString();
                bool result = blc.ManageBooksReturn(0, Convert.ToInt32(txtMemberId.Text), lblISBN.Text, lblIssuedDate.Text, lblReturnDate.Text, lblActualReturnDate.Text, 1);
                if (result == true)
                {
                    SoundPlayer bookReturned = new SoundPlayer("BookReturned.wav");
                    bookReturned.Play();
                    MessageBox.Show(MemberName + " has returned the book named " + BookName);
                    lblMemberName.Text = null;
                    pbImage.Image = null;
                    dgvReturedBookDetails.DataSource = brc.GetReturnedBooksByMemberId(Convert.ToInt32(txtMemberId.Text));
                }
                else
                {
                    MessageBox.Show("ERROR IN PERFORMING THE REQUIRED OPERATION");
                    lblMemberName.Text = null;
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                lblISBN.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["ISBN"].Value.ToString();
                if(HelperClass.CheckExistence(dgvReturedBookDetails, "ISBN", lblISBN) == true)
                {
                    SoundPlayer bookRetured = new SoundPlayer("bookRetured.wav");
                    bookRetured.Play();
                    MessageBox.Show("This book has already been returned by " + lblMemberName.Text.ToString());
                    MainForm frm = new MainForm();
                    frm.dgvTodaysReturnList.DataSource = brc.GetReturnedBooksByDate(DateTime.Now.Date);
                }
                else
                {
                    ReturnBook();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetailsOfBooks_SelectionChanged(object sender, EventArgs e)
        {
            btnReturnBook.Enabled = true;
        }

        private void dgvDetailsOfBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMemberId.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["MemberId"].Value.ToString();
                lblISB.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["ISBN"].Value.ToString();
                lblIssuedDate.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["IssuedDate"].Value.ToString();
                lblReturnDate.Text = dgvDetailsOfBooks.SelectedRows[0].Cells["ReturnDate"].Value.ToString();
                lblActualReturnDate.Text = DateTime.Now.Date.ToString();
                //pnlBookDetails.Size.Height.Equals(107);
                //pnlBookToBeReturn.Visible = true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnBook_MouseHover(object sender, EventArgs e)
        {
            btnReturnBook.BackColor.Equals("Red");
        }

        private void ReturnBooksFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            MainForm frm = new MainForm();
            frm.dgvTodaysReturnList.DataSource = brc.GetReturnedBooksByDate(DateTime.Now.Date);
        }
    }
}
