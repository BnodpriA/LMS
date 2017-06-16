using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;

namespace LibraryManagementSystem
{
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }
        BookClass bc = new BookClass();
        private void dgvBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAuthor.Text = dgvBookDetails.SelectedRows[0].Cells["AuthorName"].Value.ToString();
            lblBookName.Text = dgvBookDetails.SelectedRows[0].Cells["BookName"].Value.ToString();
            lblCategory.Text = dgvBookDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
            lblISBN.Text = dgvBookDetails.SelectedRows[0].Cells["ISBN"].Value.ToString();
            lblPublishedDate.Text = dgvBookDetails.SelectedRows[0].Cells["PublishedDate"].Value.ToString();
            lblEdition.Text = dgvBookDetails.SelectedRows[0].Cells["Edition"].Value.ToString();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            dgvBookDetails.DataSource = bc.GetBookDetailsByBookName(txtBookName.Text);
        }
    }
}
