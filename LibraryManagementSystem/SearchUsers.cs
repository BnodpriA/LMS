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
    public partial class SearchUsers : Form
    {
        public SearchUsers()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            dgvUsersDetails.DataSource = uc.GetUserByUserName(txtUserName.Text);
        }

        private void SearchUsers_Load(object sender, EventArgs e)
        {
            dgvUsersDetails.DataSource = uc.GetAllUsers(); 
            
        }
    }
}
