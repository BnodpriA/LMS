namespace LibraryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.sETTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECOMPANYINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEUSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEBOOKSCATEGORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORROWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbReturnList = new System.Windows.Forms.GroupBox();
            this.dgvTodaysReturnList = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbReturnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysReturnList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Sienna;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.Menu);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(975, 59);
            this.pnlHeader.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.SaddleBrown;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sETTINGToolStripMenuItem,
            this.bOOKSToolStripMenuItem,
            this.mEMBERSToolStripMenuItem,
            this.iSSUEToolStripMenuItem,
            this.bORROWToolStripMenuItem,
            this.sEARCHToolStripMenuItem,
            this.msLogout});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(971, 55);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // sETTINGToolStripMenuItem
            // 
            this.sETTINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGECOMPANYINFOToolStripMenuItem,
            this.mANAGEUSERSToolStripMenuItem});
            this.sETTINGToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sETTINGToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sETTINGToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sETTINGToolStripMenuItem.Image")));
            this.sETTINGToolStripMenuItem.Name = "sETTINGToolStripMenuItem";
            this.sETTINGToolStripMenuItem.Size = new System.Drawing.Size(119, 51);
            this.sETTINGToolStripMenuItem.Text = "SETTING";
            // 
            // mANAGECOMPANYINFOToolStripMenuItem
            // 
            this.mANAGECOMPANYINFOToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGECOMPANYINFOToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mANAGECOMPANYINFOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mANAGECOMPANYINFOToolStripMenuItem.Image")));
            this.mANAGECOMPANYINFOToolStripMenuItem.Name = "mANAGECOMPANYINFOToolStripMenuItem";
            this.mANAGECOMPANYINFOToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.mANAGECOMPANYINFOToolStripMenuItem.Text = "MANAGE COMPANY INFO";
            this.mANAGECOMPANYINFOToolStripMenuItem.Click += new System.EventHandler(this.mANAGECOMPANYINFOToolStripMenuItem_Click);
            // 
            // mANAGEUSERSToolStripMenuItem
            // 
            this.mANAGEUSERSToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGEUSERSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mANAGEUSERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mANAGEUSERSToolStripMenuItem.Image")));
            this.mANAGEUSERSToolStripMenuItem.Name = "mANAGEUSERSToolStripMenuItem";
            this.mANAGEUSERSToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.mANAGEUSERSToolStripMenuItem.Text = "MANAGE USERS";
            this.mANAGEUSERSToolStripMenuItem.Click += new System.EventHandler(this.mANAGEUSERSToolStripMenuItem_Click);
            // 
            // bOOKSToolStripMenuItem
            // 
            this.bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGEBOOKSCATEGORYToolStripMenuItem,
            this.mANAGEBOOKSToolStripMenuItem});
            this.bOOKSToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOOKSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKSToolStripMenuItem.Image")));
            this.bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            this.bOOKSToolStripMenuItem.Size = new System.Drawing.Size(103, 51);
            this.bOOKSToolStripMenuItem.Text = "BOOKS";
            // 
            // mANAGEBOOKSCATEGORYToolStripMenuItem
            // 
            this.mANAGEBOOKSCATEGORYToolStripMenuItem.Name = "mANAGEBOOKSCATEGORYToolStripMenuItem";
            this.mANAGEBOOKSCATEGORYToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.mANAGEBOOKSCATEGORYToolStripMenuItem.Text = "MANAGE BOOKS CATEGORY";
            this.mANAGEBOOKSCATEGORYToolStripMenuItem.Click += new System.EventHandler(this.mANAGEBOOKSCATEGORYToolStripMenuItem_Click);
            // 
            // mANAGEBOOKSToolStripMenuItem
            // 
            this.mANAGEBOOKSToolStripMenuItem.Name = "mANAGEBOOKSToolStripMenuItem";
            this.mANAGEBOOKSToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.mANAGEBOOKSToolStripMenuItem.Text = "MANAGE BOOKS";
            this.mANAGEBOOKSToolStripMenuItem.Click += new System.EventHandler(this.mANAGEBOOKSToolStripMenuItem_Click);
            // 
            // mEMBERSToolStripMenuItem
            // 
            this.mEMBERSToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEMBERSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mEMBERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mEMBERSToolStripMenuItem.Image")));
            this.mEMBERSToolStripMenuItem.Name = "mEMBERSToolStripMenuItem";
            this.mEMBERSToolStripMenuItem.Size = new System.Drawing.Size(131, 51);
            this.mEMBERSToolStripMenuItem.Text = "MEMBERS";
            this.mEMBERSToolStripMenuItem.Click += new System.EventHandler(this.mEMBERSToolStripMenuItem_Click);
            // 
            // iSSUEToolStripMenuItem
            // 
            this.iSSUEToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSSUEToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.iSSUEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iSSUEToolStripMenuItem.Image")));
            this.iSSUEToolStripMenuItem.Name = "iSSUEToolStripMenuItem";
            this.iSSUEToolStripMenuItem.Size = new System.Drawing.Size(148, 51);
            this.iSSUEToolStripMenuItem.Text = "BOOK ISSUE";
            this.iSSUEToolStripMenuItem.Click += new System.EventHandler(this.iSSUEToolStripMenuItem_Click);
            // 
            // bORROWToolStripMenuItem
            // 
            this.bORROWToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bORROWToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bORROWToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bORROWToolStripMenuItem.Image")));
            this.bORROWToolStripMenuItem.Name = "bORROWToolStripMenuItem";
            this.bORROWToolStripMenuItem.Size = new System.Drawing.Size(172, 51);
            this.bORROWToolStripMenuItem.Text = "BOOK RETURN";
            this.bORROWToolStripMenuItem.Click += new System.EventHandler(this.bORROWToolStripMenuItem_Click);
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKSToolStripMenuItem1,
            this.uSERSToolStripMenuItem,
            this.mEMBERSToolStripMenuItem1});
            this.sEARCHToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEARCHToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sEARCHToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sEARCHToolStripMenuItem.Image")));
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(113, 51);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
            // 
            // bOOKSToolStripMenuItem1
            // 
            this.bOOKSToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.bOOKSToolStripMenuItem1.Name = "bOOKSToolStripMenuItem1";
            this.bOOKSToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.bOOKSToolStripMenuItem1.Text = "BOOKS";
            this.bOOKSToolStripMenuItem1.Click += new System.EventHandler(this.bOOKSToolStripMenuItem1_Click);
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.uSERSToolStripMenuItem.Text = "USERS";
            this.uSERSToolStripMenuItem.Click += new System.EventHandler(this.uSERSToolStripMenuItem_Click);
            // 
            // mEMBERSToolStripMenuItem1
            // 
            this.mEMBERSToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.mEMBERSToolStripMenuItem1.Name = "mEMBERSToolStripMenuItem1";
            this.mEMBERSToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.mEMBERSToolStripMenuItem1.Text = "MEMBERS";
            this.mEMBERSToolStripMenuItem1.Click += new System.EventHandler(this.mEMBERSToolStripMenuItem1_Click);
            // 
            // msLogout
            // 
            this.msLogout.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLogout.Image = ((System.Drawing.Image)(resources.GetObject("msLogout.Image")));
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(106, 51);
            this.msLogout.Text = "Log out";
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblLoggedUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 73);
            this.panel1.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateTime.Location = new System.Drawing.Point(697, 25);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(68, 22);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "GUEST";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoggedUser.Location = new System.Drawing.Point(137, 25);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(68, 22);
            this.lblLoggedUser.TabIndex = 1;
            this.lblLoggedUser.Text = "GUEST";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCompany);
            this.panel2.Controls.Add(this.btnReturnBooks);
            this.panel2.Controls.Add(this.btnIssueBooks);
            this.panel2.Controls.Add(this.btnBooks);
            this.panel2.Controls.Add(this.btnMembers);
            this.panel2.Controls.Add(this.btnManageUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 559);
            this.panel2.TabIndex = 3;
            // 
            // btnCompany
            // 
            this.btnCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompany.BackgroundImage")));
            this.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Location = new System.Drawing.Point(18, 436);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(75, 69);
            this.btnCompany.TabIndex = 5;
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            this.btnCompany.MouseHover += new System.EventHandler(this.btnCompany_MouseHover);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnBooks.BackgroundImage")));
            this.btnReturnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Location = new System.Drawing.Point(18, 352);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(75, 69);
            this.btnReturnBooks.TabIndex = 4;
            this.btnReturnBooks.UseVisualStyleBackColor = true;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            this.btnReturnBooks.MouseHover += new System.EventHandler(this.btnReturnBooks_MouseHover);
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssueBooks.BackgroundImage")));
            this.btnIssueBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Location = new System.Drawing.Point(18, 268);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(75, 69);
            this.btnIssueBooks.TabIndex = 3;
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            this.btnIssueBooks.MouseHover += new System.EventHandler(this.btnIssueBooks_MouseHover);
            // 
            // btnBooks
            // 
            this.btnBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooks.BackgroundImage")));
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Location = new System.Drawing.Point(18, 184);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(75, 69);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            this.btnBooks.MouseHover += new System.EventHandler(this.btnBooks_MouseHover);
            // 
            // btnMembers
            // 
            this.btnMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMembers.BackgroundImage")));
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Location = new System.Drawing.Point(19, 99);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(75, 69);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            this.btnMembers.MouseHover += new System.EventHandler(this.btnMembers_MouseHover);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.BackgroundImage")));
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(19, 17);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(75, 69);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            this.btnManageUsers.MouseHover += new System.EventHandler(this.btnManageUsers_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbReturnList
            // 
            this.gbReturnList.BackColor = System.Drawing.Color.Goldenrod;
            this.gbReturnList.Controls.Add(this.dgvTodaysReturnList);
            this.gbReturnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReturnList.Location = new System.Drawing.Point(114, 59);
            this.gbReturnList.Name = "gbReturnList";
            this.gbReturnList.Size = new System.Drawing.Size(861, 559);
            this.gbReturnList.TabIndex = 4;
            this.gbReturnList.TabStop = false;
            this.gbReturnList.Text = "Today\'s Return List";
            // 
            // dgvTodaysReturnList
            // 
            this.dgvTodaysReturnList.AllowUserToAddRows = false;
            this.dgvTodaysReturnList.AllowUserToDeleteRows = false;
            this.dgvTodaysReturnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodaysReturnList.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvTodaysReturnList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTodaysReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodaysReturnList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodaysReturnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodaysReturnList.Location = new System.Drawing.Point(3, 22);
            this.dgvTodaysReturnList.MultiSelect = false;
            this.dgvTodaysReturnList.Name = "dgvTodaysReturnList";
            this.dgvTodaysReturnList.ReadOnly = true;
            this.dgvTodaysReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodaysReturnList.Size = new System.Drawing.Size(855, 534);
            this.dgvTodaysReturnList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 691);
            this.Controls.Add(this.gbReturnList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbReturnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysReturnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem mANAGECOMPANYINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEUSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORROWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mEMBERSToolStripMenuItem1;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mANAGEBOOKSCATEGORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEBOOKSToolStripMenuItem;
        public System.Windows.Forms.Label lblLoggedUser;
        public System.Windows.Forms.ToolStripMenuItem sETTINGToolStripMenuItem;
        public System.Windows.Forms.GroupBox gbReturnList;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        public System.Windows.Forms.DataGridView dgvTodaysReturnList;
        public System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
    }
}

