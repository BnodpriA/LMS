using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using DataAccessLayer;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        BookReturnClass brc = new BookReturnClass();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void mANAGECOMPANYINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCompanyInfoFrm frm = new ManageCompanyInfoFrm();
           
            frm.ShowDialog();
        }

        private void mANAGEUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUserFrm frm = new ManageUserFrm();
            frm.ShowDialog();
        }

        private void mANAGEBOOKSCATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooksCategory frm = new ManageBooksCategory();
            frm.ShowDialog();
        }

        private void mANAGEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooksFrm frm = new ManageBooksFrm();
            frm.ShowDialog();
        }

        private void mEMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberFrm frm = new MemberFrm();
            frm.ShowDialog();
        }

        private void iSSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookIssueFrm frm = new BookIssueFrm();
            frm.ShowDialog();
        }

        private void bORROWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooksFrm frm = new ReturnBooksFrm();
            frm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUserFrm frm = new ManageUserFrm();
            frm.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberFrm frm = new MemberFrm();
            frm.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ManageBooksFrm frm = new ManageBooksFrm();
            frm.ShowDialog();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            BookIssueFrm frm = new BookIssueFrm();
            frm.ShowDialog();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBooksFrm frm = new ReturnBooksFrm();
            frm.ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            ManageCompanyInfoFrm frm = new ManageCompanyInfoFrm();

            frm.ShowDialog();
        }

        private void btnManageUsers_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnManageUsers, "MANAGE USERS");
        }

        private void btnMembers_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnMembers, "MANAGE MEMBERS");
        }

        private void btnBooks_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnBooks, "MANAGE BOOKS");
        }

        private void btnIssueBooks_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnIssueBooks, "ISSUE BOOKS");
        }

        private void btnReturnBooks_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnReturnBooks, "RETURN BOOKS");
        }

        private void btnCompany_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnCompany, "MANAGE COMPANY");
        }

        private void mEMBERSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.ShowDialog();
        }

        private void bOOKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchBook sb = new SearchBook();
            sb.ShowDialog();
        }

        private void uSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUsers su = new SearchUsers();
            su.ShowDialog();
        }

        private void msLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SoundPlayer sdWelcome = new SoundPlayer("Welcome.wav");
            sdWelcome.Play();
            lblDateTime.Text = DateTime.Now.ToString();
            dgvTodaysReturnList.DataSource = brc.GetReturnedBooksByDate(DateTime.Now.Date);
        }

       
    }
}
