namespace LibraryManagementSystem
{
    partial class BookIssueFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookIssueFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBooks = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAvailableDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlIssuedBookDetails = new System.Windows.Forms.Panel();
            this.dgvIssueDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUndoIssue = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.pnlBooks.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlIssuedBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBookDetails);
            this.groupBox1.Controls.Add(this.dtpReturnDate);
            this.groupBox1.Controls.Add(this.dtpIssuedDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pnlBooks);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.pnlMember);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ISSUE BOOKS";
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AllowUserToAddRows = false;
            this.dgvBookDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvBookDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookDetails.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBookDetails.Location = new System.Drawing.Point(11, 98);
            this.dgvBookDetails.MultiSelect = false;
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.ReadOnly = true;
            this.dgvBookDetails.RowHeadersVisible = false;
            this.dgvBookDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookDetails.Size = new System.Drawing.Size(493, 91);
            this.dgvBookDetails.TabIndex = 3;
            this.dgvBookDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellClick);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(521, 295);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(265, 26);
            this.dtpReturnDate.TabIndex = 5;
            // 
            // dtpIssuedDate
            // 
            this.dtpIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssuedDate.Location = new System.Drawing.Point(112, 295);
            this.dtpIssuedDate.Name = "dtpIssuedDate";
            this.dtpIssuedDate.Size = new System.Drawing.Size(250, 26);
            this.dtpIssuedDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Return Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issued Date:";
            // 
            // pnlBooks
            // 
            this.pnlBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBooks.Controls.Add(this.label9);
            this.pnlBooks.Controls.Add(this.label7);
            this.pnlBooks.Controls.Add(this.lblStatus);
            this.pnlBooks.Controls.Add(this.lblBookName);
            this.pnlBooks.Controls.Add(this.lblAvailableDate);
            this.pnlBooks.Controls.Add(this.label6);
            this.pnlBooks.Location = new System.Drawing.Point(11, 195);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(493, 87);
            this.pnlBooks.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Available Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(201, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 0;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(8, 51);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(0, 19);
            this.lblBookName.TabIndex = 0;
            // 
            // lblAvailableDate
            // 
            this.lblAvailableDate.AutoSize = true;
            this.lblAvailableDate.Location = new System.Drawing.Point(339, 51);
            this.lblAvailableDate.Name = "lblAvailableDate";
            this.lblAvailableDate.Size = new System.Drawing.Size(0, 19);
            this.lblAvailableDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Name:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtISBN);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 34);
            this.panel3.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(127, -1);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(359, 26);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtMemberId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 38);
            this.panel2.TabIndex = 1;
            // 
            // txtMemberId
            // 
            this.txtMemberId.BackColor = System.Drawing.Color.White;
            this.txtMemberId.Location = new System.Drawing.Point(127, 0);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(359, 26);
            this.txtMemberId.TabIndex = 1;
            this.txtMemberId.TextChanged += new System.EventHandler(this.txtMemberId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Id:";
            // 
            // pnlMember
            // 
            this.pnlMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMember.Controls.Add(this.pbImage);
            this.pnlMember.Controls.Add(this.lblMemberName);
            this.pnlMember.Controls.Add(this.label5);
            this.pnlMember.Location = new System.Drawing.Point(510, 10);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(270, 272);
            this.pnlMember.TabIndex = 0;
            this.pnlMember.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Peru;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(9, 61);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(250, 193);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(109, 27);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(49, 19);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // pnlIssuedBookDetails
            // 
            this.pnlIssuedBookDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlIssuedBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIssuedBookDetails.Controls.Add(this.dgvIssueDetails);
            this.pnlIssuedBookDetails.Location = new System.Drawing.Point(2, 334);
            this.pnlIssuedBookDetails.Name = "pnlIssuedBookDetails";
            this.pnlIssuedBookDetails.Size = new System.Drawing.Size(602, 122);
            this.pnlIssuedBookDetails.TabIndex = 2;
            // 
            // dgvIssueDetails
            // 
            this.dgvIssueDetails.AllowUserToAddRows = false;
            this.dgvIssueDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvIssueDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssueDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssueDetails.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvIssueDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIssueDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvIssueDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssueDetails.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvIssueDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvIssueDetails.MultiSelect = false;
            this.dgvIssueDetails.Name = "dgvIssueDetails";
            this.dgvIssueDetails.ReadOnly = true;
            this.dgvIssueDetails.RowHeadersVisible = false;
            this.dgvIssueDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueDetails.Size = new System.Drawing.Size(598, 118);
            this.dgvIssueDetails.TabIndex = 0;
            this.dgvIssueDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueDetails_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(19, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnUndoIssue
            // 
            this.btnUndoIssue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUndoIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndoIssue.Location = new System.Drawing.Point(19, 47);
            this.btnUndoIssue.Name = "btnUndoIssue";
            this.btnUndoIssue.Size = new System.Drawing.Size(162, 28);
            this.btnUndoIssue.TabIndex = 7;
            this.btnUndoIssue.Text = "UNDO ISSUE";
            this.btnUndoIssue.UseVisualStyleBackColor = true;
            this.btnUndoIssue.Click += new System.EventHandler(this.btnUndoIssue_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Location = new System.Drawing.Point(19, 10);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(162, 28);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "ISSUE BOOKS";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIssue);
            this.panel1.Controls.Add(this.btnUndoIssue);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(607, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 120);
            this.panel1.TabIndex = 5;
            // 
            // BookIssueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(808, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIssuedBookDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookIssueFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                            LIBRARY MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.BookIssueFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.pnlBooks.ResumeLayout(false);
            this.pnlBooks.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlIssuedBookDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpIssuedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBooks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Panel pnlIssuedBookDetails;
        private System.Windows.Forms.DataGridView dgvIssueDetails;
        private System.Windows.Forms.Label lblAvailableDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUndoIssue;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panel1;
    }
}