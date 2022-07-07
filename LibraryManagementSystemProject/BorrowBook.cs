using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
    public partial class BorrowBook : Form
    {
        public static IMongoClient client = new MongoClient();

        public static IMongoDatabase db = client.GetDatabase("librarydatabase");

        public static IMongoCollection<Book> collectionBook = db.GetCollection<Book>("book");
        public static IMongoCollection<Borrow> collectionBorrow = db.GetCollection<Borrow>("borrow");
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void btn_borrow_report_Click(object sender, EventArgs e)
        {
            BorrowedReport borrowedReport = new BorrowedReport();
            borrowedReport.Show();
            this.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Close();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
            this.Close();
        }

        public void searchAvailableBooks()
        {
            if (txt_booktitle.Text != "")
            {
                List<Book> list = collectionBook.Find(x => x.Title == txt_booktitle.Text && x.NumberOfBook > 0).ToList();
                grid_books.DataSource = list;
            }
            else
            {
                List<Book> list2 = collectionBook.Find(x => x.NumberOfBook > 0).ToList();
                grid_books.DataSource = list2;
            }
        }

        private void btn_searchbook_Click(object sender, EventArgs e)
        {
            searchAvailableBooks();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_title.Text = grid_books.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_id.Text = grid_books.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_count.Text = grid_books.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "")
            {
                Borrow newrecord = new Borrow(txt_title.Text,
                                    lbl_id.Text,
                                    txt_borrowername.Text,
                                    txt_borrowerphone.Text,
                                    date_borrow.Value,
                                    date_return.Value);

                collectionBorrow.InsertOne(newrecord);
                MessageBox.Show(txt_borrowername.Text + " borrowed the book that " + txt_title.Text, "Succesfull");

                var update = Builders<Book>.Update.Inc("NumberOfBook",- 1);
                collectionBook.UpdateOne(x => x.Id == ObjectId.Parse(lbl_id.Text), update);
                lbl_count.Text = (Int32.Parse(lbl_count.Text) - 1).ToString();
                searchAvailableBooks();
            }
            else
            {
                MessageBox.Show("Select a book from Available Books List!", "Error");
            }
            
        }


    }

    public class Borrow
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("BookId")]
        public string BookId { get; set; }
        [BsonElement("BorrowerName")]
        public string BorrowerName { get; set; }
        [BsonElement("BorrowerPhone")]
        public string BorrowerPhone { get; set; }
        [BsonElement("BorrowDate")]
        public DateTime BorrowDate { get; set; }
        [BsonElement("ReturnDate")]
        public DateTime ReturnDate { get; set; }

        public Borrow(string title, string bookid, string borrowerName, string borrowerPhone, DateTime borrowDate, DateTime returnDate)
        {
            Title = title;
            BookId = bookid;
            BorrowerName = borrowerName;
            BorrowerPhone = borrowerPhone;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }
    }


}
