
namespace LibraryManagementSystemProject
{
    partial class BorrowBook
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
            this.btn_borrow_report = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_booktitle = new System.Windows.Forms.TextBox();
            this.btn_searchbook = new System.Windows.Forms.Button();
            this.grid_books = new System.Windows.Forms.DataGridView();
            this.txt_borrowername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_borrowerphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_borrow = new System.Windows.Forms.DateTimePicker();
            this.date_return = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_borrow_report
            // 
            this.btn_borrow_report.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borrow_report.Location = new System.Drawing.Point(300, 15);
            this.btn_borrow_report.Name = "btn_borrow_report";
            this.btn_borrow_report.Size = new System.Drawing.Size(111, 49);
            this.btn_borrow_report.TabIndex = 7;
            this.btn_borrow_report.Text = "Borrowed Books Repor&t";
            this.btn_borrow_report.UseVisualStyleBackColor = true;
            this.btn_borrow_report.Click += new System.EventHandler(this.btn_borrow_report_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_return.Location = new System.Drawing.Point(500, 15);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(111, 49);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "&Return Borrowed Book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search.Location = new System.Drawing.Point(700, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(111, 49);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "&Search Book";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_mainmenu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainmenu.Location = new System.Drawing.Point(100, 15);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(111, 49);
            this.btn_mainmenu.TabIndex = 6;
            this.btn_mainmenu.Text = "&Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 80);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(1111, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 49);
            this.btn_exit.TabIndex = 101;
            this.btn_exit.Text = "E&XIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "Search with Title:";
            // 
            // txt_booktitle
            // 
            this.txt_booktitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_booktitle.Location = new System.Drawing.Point(171, 108);
            this.txt_booktitle.Name = "txt_booktitle";
            this.txt_booktitle.Size = new System.Drawing.Size(146, 27);
            this.txt_booktitle.TabIndex = 103;
            // 
            // btn_searchbook
            // 
            this.btn_searchbook.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_searchbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchbook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchbook.ForeColor = System.Drawing.Color.White;
            this.btn_searchbook.Location = new System.Drawing.Point(362, 108);
            this.btn_searchbook.Name = "btn_searchbook";
            this.btn_searchbook.Size = new System.Drawing.Size(88, 29);
            this.btn_searchbook.TabIndex = 104;
            this.btn_searchbook.Text = "Search";
            this.btn_searchbook.UseVisualStyleBackColor = false;
            this.btn_searchbook.Click += new System.EventHandler(this.btn_searchbook_Click);
            // 
            // grid_books
            // 
            this.grid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_books.Location = new System.Drawing.Point(500, 108);
            this.grid_books.Name = "grid_books";
            this.grid_books.Size = new System.Drawing.Size(752, 164);
            this.grid_books.TabIndex = 105;
            this.grid_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_books_CellClick);
            // 
            // txt_borrowername
            // 
            this.txt_borrowername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_borrowername.Location = new System.Drawing.Point(171, 300);
            this.txt_borrowername.Name = "txt_borrowername";
            this.txt_borrowername.Size = new System.Drawing.Size(159, 27);
            this.txt_borrowername.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Borrower Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(796, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Available Books to Borrow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 110;
            this.label4.Text = "Borrower Phone:";
            // 
            // txt_borrowerphone
            // 
            this.txt_borrowerphone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_borrowerphone.Location = new System.Drawing.Point(171, 340);
            this.txt_borrowerphone.Name = "txt_borrowerphone";
            this.txt_borrowerphone.Size = new System.Drawing.Size(159, 27);
            this.txt_borrowerphone.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 112;
            this.label5.Text = "Book Title:";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(171, 260);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(159, 27);
            this.txt_title.TabIndex = 111;
            this.txt_title.Text = "Select from list!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 114;
            this.label6.Text = "Borrow Date:";
            // 
            // date_borrow
            // 
            this.date_borrow.Enabled = false;
            this.date_borrow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_borrow.Location = new System.Drawing.Point(171, 380);
            this.date_borrow.Name = "date_borrow";
            this.date_borrow.Size = new System.Drawing.Size(159, 27);
            this.date_borrow.TabIndex = 115;
            // 
            // date_return
            // 
            this.date_return.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_return.Location = new System.Drawing.Point(171, 420);
            this.date_return.Name = "date_return";
            this.date_return.Size = new System.Drawing.Size(159, 27);
            this.date_return.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 116;
            this.label7.Text = "Return Date:";
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borrow.ForeColor = System.Drawing.Color.White;
            this.btn_borrow.Location = new System.Drawing.Point(100, 498);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(111, 46);
            this.btn_borrow.TabIndex = 118;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = false;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(168, 224);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 13);
            this.lbl_id.TabIndex = 119;
            this.lbl_id.Text = "---------";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(168, 465);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(34, 13);
            this.lbl_count.TabIndex = 120;
            this.lbl_count.Text = "---------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 122;
            this.label8.Text = "Book ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 18);
            this.label9.TabIndex = 123;
            this.label9.Text = "Number of Books:";
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.date_return);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_borrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_borrowerphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_borrowername);
            this.Controls.Add(this.grid_books);
            this.Controls.Add(this.btn_searchbook);
            this.Controls.Add(this.txt_booktitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_borrow_report);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrow_report;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_booktitle;
        private System.Windows.Forms.Button btn_searchbook;
        private System.Windows.Forms.DataGridView grid_books;
        private System.Windows.Forms.TextBox txt_borrowername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_borrowerphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_borrow;
        private System.Windows.Forms.DateTimePicker date_return;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}