using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemProject
{
    public partial class ReturnBook : Form
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("librarydatabase");
        public static IMongoCollection<Book> collectionBook = db.GetCollection<Book>("book");
        public static IMongoCollection<Borrow> collectionBorrow = db.GetCollection<Borrow>("borrow");
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.Show();
            this.Close();
        }

        private void btn_borrow_report_Click(object sender, EventArgs e)
        {
            BorrowedReport borrowedReport = new BorrowedReport();
            borrowedReport.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void btn_searchbook_Click(object sender, EventArgs e)
        {
            searchBorrowRecords();
        }
        public void searchBorrowRecords()
        {
            if (txt_borrowername.Text != "")
            {
                List<Borrow> list = collectionBorrow.Find(x => x.BorrowerName == txt_borrowername.Text).ToList();
                grid_borrowed.DataSource = list;
            }
            else
            {
                List<Borrow> list2 = collectionBorrow.AsQueryable().ToList();
                grid_borrowed.DataSource = list2;
            }
        }

        private void grid_borrowed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = grid_borrowed.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbl_title .Text = grid_borrowed.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_borrowername.Text = grid_borrowed.Rows[e.RowIndex].Cells[3].Value.ToString();
            lbl_borrowdate.Text = grid_borrowed.Rows[e.RowIndex].Cells[5].Value.ToString();

            lbl_borrowid.Text = grid_borrowed.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            collectionBorrow.DeleteOne(x => x.Id == ObjectId.Parse(lbl_borrowid.Text));
            searchBorrowRecords();

            var update = Builders<Book>.Update.Inc("NumberOfBook", 1);
            collectionBook.UpdateOne(x => x.Id == ObjectId.Parse(lbl_id.Text), update);
            searchBorrowRecords();

            MessageBox.Show(lbl_title.Text+" is returned succesfully!", "Thank You");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
            this.Close();
        }
    }
}
