namespace LibraryManagementSystem
{
    partial class ReturnBooksFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooksFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBookDetails = new System.Windows.Forms.Panel();
            this.dgvDetailsOfBooks = new System.Windows.Forms.DataGridView();
            this.pnlBookToBeReturn = new System.Windows.Forms.Panel();
            this.lblActualReturnDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblISB = new System.Windows.Forms.Label();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReturedBookDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsOfBooks)).BeginInit();
            this.pnlBookToBeReturn.SuspendLayout();
            this.pnlMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturedBookDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturnBook);
            this.groupBox1.Controls.Add(this.txtMemberId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pnlBookDetails);
            this.groupBox1.Controls.Add(this.pnlBookToBeReturn);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RETURN BOOKS";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Enabled = false;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(388, 21);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(159, 32);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            this.btnReturnBook.MouseHover += new System.EventHandler(this.btnReturnBook_MouseHover);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(120, 21);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(250, 31);
            this.txtMemberId.TabIndex = 1;
            this.txtMemberId.TextChanged += new System.EventHandler(this.txtMemberId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Id:";
            // 
            // pnlBookDetails
            // 
            this.pnlBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBookDetails.Controls.Add(this.dgvDetailsOfBooks);
            this.pnlBookDetails.Location = new System.Drawing.Point(11, 57);
            this.pnlBookDetails.Name = "pnlBookDetails";
            this.pnlBookDetails.Size = new System.Drawing.Size(538, 188);
            this.pnlBookDetails.TabIndex = 2;
            // 
            // dgvDetailsOfBooks
            // 
            this.dgvDetailsOfBooks.AllowUserToAddRows = false;
            this.dgvDetailsOfBooks.AllowUserToDeleteRows = false;
            this.dgvDetailsOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsOfBooks.BackgroundColor = System.Drawing.Color.Olive;
            this.dgvDetailsOfBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvDetailsOfBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailsOfBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvDetailsOfBooks.MultiSelect = false;
            this.dgvDetailsOfBooks.Name = "dgvDetailsOfBooks";
            this.dgvDetailsOfBooks.ReadOnly = true;
            this.dgvDetailsOfBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDetailsOfBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDetailsOfBooks.RowHeadersVisible = false;
            this.dgvDetailsOfBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDetailsOfBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsOfBooks.Size = new System.Drawing.Size(534, 184);
            this.dgvDetailsOfBooks.TabIndex = 0;
            this.dgvDetailsOfBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailsOfBooks_CellContentClick);
            this.dgvDetailsOfBooks.SelectionChanged += new System.EventHandler(this.dgvDetailsOfBooks_SelectionChanged);
            // 
            // pnlBookToBeReturn
            // 
            this.pnlBookToBeReturn.Controls.Add(this.lblActualReturnDate);
            this.pnlBookToBeReturn.Controls.Add(this.lblReturnDate);
            this.pnlBookToBeReturn.Controls.Add(this.lblIssuedDate);
            this.pnlBookToBeReturn.Controls.Add(this.lblISBN);
            this.pnlBookToBeReturn.Controls.Add(this.lblBookName);
            this.pnlBookToBeReturn.Controls.Add(this.label6);
            this.pnlBookToBeReturn.Controls.Add(this.label3);
            this.pnlBookToBeReturn.Controls.Add(this.label4);
            this.pnlBookToBeReturn.Controls.Add(this.label2);
            this.pnlBookToBeReturn.Controls.Add(this.lblISB);
            this.pnlBookToBeReturn.Location = new System.Drawing.Point(11, 173);
            this.pnlBookToBeReturn.Name = "pnlBookToBeReturn";
            this.pnlBookToBeReturn.Size = new System.Drawing.Size(536, 72);
            this.pnlBookToBeReturn.TabIndex = 13;
            // 
            // lblActualReturnDate
            // 
            this.lblActualReturnDate.Location = new System.Drawing.Point(393, 35);
            this.lblActualReturnDate.Name = "lblActualReturnDate";
            this.lblActualReturnDate.Size = new System.Drawing.Size(144, 19);
            this.lblActualReturnDate.TabIndex = 12;
            this.lblActualReturnDate.Text = "Actual Return Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Location = new System.Drawing.Point(296, 35);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(97, 19);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.Location = new System.Drawing.Point(193, 35);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(94, 19);
            this.lblIssuedDate.TabIndex = 10;
            this.lblIssuedDate.Text = "Issued Date:";
            // 
            // lblISBN
            // 
            this.lblISBN.Location = new System.Drawing.Point(129, 35);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(46, 19);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "lSBN:";
            // 
            // lblBookName
            // 
            this.lblBookName.Location = new System.Drawing.Point(4, 35);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(93, 19);
            this.lblBookName.TabIndex = 8;
            this.lblBookName.Text = "Book Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Actual Return Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Issued Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "lSBN:";
            // 
            // lblISB
            // 
            this.lblISB.AutoSize = true;
            this.lblISB.Location = new System.Drawing.Point(4, 8);
            this.lblISB.Name = "lblISB";
            this.lblISB.Size = new System.Drawing.Size(114, 23);
            this.lblISB.TabIndex = 3;
            this.lblISB.Text = "Book Name:";
            // 
            // pnlMember
            // 
            this.pnlMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMember.Controls.Add(this.pbImage);
            this.pnlMember.Controls.Add(this.lblMemberName);
            this.pnlMember.Controls.Add(this.label5);
            this.pnlMember.Location = new System.Drawing.Point(562, 15);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(270, 239);
            this.pnlMember.TabIndex = 2;
            this.pnlMember.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(3, 43);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(255, 186);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(109, 12);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(61, 23);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(662, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Detail Information of Returned Book by Different Members";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReturedBookDetails);
            this.panel2.Location = new System.Drawing.Point(15, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 178);
            this.panel2.TabIndex = 5;
            // 
            // dgvReturedBookDetails
            // 
            this.dgvReturedBookDetails.AllowUserToAddRows = false;
            this.dgvReturedBookDetails.AllowUserToDeleteRows = false;
            this.dgvReturedBookDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturedBookDetails.BackgroundColor = System.Drawing.Color.Olive;
            this.dgvReturedBookDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturedBookDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturedBookDetails.GridColor = System.Drawing.Color.BurlyWood;
            this.dgvReturedBookDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvReturedBookDetails.MultiSelect = false;
            this.dgvReturedBookDetails.Name = "dgvReturedBookDetails";
            this.dgvReturedBookDetails.ReadOnly = true;
            this.dgvReturedBookDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReturedBookDetails.RowHeadersVisible = false;
            this.dgvReturedBookDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturedBookDetails.Size = new System.Drawing.Size(805, 178);
            this.dgvReturedBookDetails.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(2, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 224);
            this.panel3.TabIndex = 6;
            // 
            // ReturnBooksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(836, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMember);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBooksFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnBooksFrm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnBooksFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBookDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsOfBooks)).EndInit();
            this.pnlBookToBeReturn.ResumeLayout(false);
            this.pnlBookToBeReturn.PerformLayout();
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturedBookDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBookDetails;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetailsOfBooks;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblISB;
        private System.Windows.Forms.Label lblActualReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlBookToBeReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReturedBookDetails;
        private System.Windows.Forms.Panel panel3;
    }
}