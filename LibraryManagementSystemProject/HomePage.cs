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
    public partial class HomePage : Form
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("librarydatabase");
        public static IMongoCollection<Book> collectionBook = db.GetCollection<Book>("book");
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Book newbook = new Book(txt_title.Text, 
                                    txt_author.Text, 
                                    txt_editor.Text, 
                                    txt_isbn.Text, 
                                    txt_publishyear.Text,
                                    txt_edition.Text, 
                                    txt_publisher.Text, 
                                    txt_pagecount.Text, 
                                    txt_language.Text, 
                                    Int32.Parse(txt_numberofbook.Text));

            collectionBook.InsertOne(newbook);
            showData();
        
        }

        public void showData()
        {
            List<Book> list = collectionBook.AsQueryable().ToList();
            grid_books.DataSource = list;
        }
        
        public void clearData()
        {
            txt_title.Text = "";
            txt_author.Text = "";
            txt_editor.Text = "";
            txt_isbn.Text = "";
            txt_publishyear.Text = "";
            txt_edition.Text = "";
            txt_publisher.Text = "";
            txt_pagecount.Text = "";
            txt_language.Text = "";
            txt_numberofbook.Text = "";
            lbl_id.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var update = Builders<Book>.Update.Set("Title", txt_title.Text).Set("Author", txt_author.Text)
                                                .Set("Editor", txt_editor.Text).Set("ISBN", txt_isbn.Text)
                                                .Set("PublishYear", txt_publishyear.Text).Set("Edition", txt_edition.Text)
                                                .Set("Publisher", txt_publisher.Text).Set("PageCount", txt_pagecount.Text)
                                                .Set("Language", txt_language.Text).Set("NumberOfBook",Int32.Parse(txt_numberofbook.Text));
            collectionBook.UpdateOne(x => x.Id == ObjectId.Parse(lbl_id.Text), update);
            showData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void grid_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = grid_books.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_title.Text = grid_books.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_author.Text = grid_books.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_editor.Text = grid_books.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_isbn.Text = grid_books.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_publishyear.Text = grid_books.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_edition.Text = grid_books.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_publisher.Text = grid_books.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_pagecount.Text = grid_books.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_language.Text = grid_books.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_numberofbook.Text = grid_books.Rows[e.RowIndex].Cells[10].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            collectionBook.DeleteOne(x => x.Id == ObjectId.Parse(lbl_id.Text));
            showData();
            clearData();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.Show();
            this.Hide();
        }

        private void btn_borrow_report_Click(object sender, EventArgs e)
        {
            BorrowedReport borrowedReport = new BorrowedReport();
            borrowedReport.Show();
            this.Hide();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Hide();
        }

        private void btn_searchbook_Click(object sender, EventArgs e)
        {
            if (txt_booktitle.Text != "")
            {
                List<Book> list = collectionBook.Find(x => x.Title == txt_booktitle.Text).ToList();
                grid_books.DataSource = list;
            }
            else
            {
                List<Book> list2 = collectionBook.AsQueryable().ToList();
                grid_books.DataSource = list2;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
            this.Hide();
        }
    }

    public class Book
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("Author")]
        public string Author { get; set; }
        [BsonElement("Editor")]
        public string Editor { get; set; }
        [BsonElement("ISBN")]
        public string ISBN { get; set; }
        [BsonElement("PublishYear")]
        public string PublishYear { get; set; }
        [BsonElement("Edition")]
        public string Edition { get; set; }
        [BsonElement("Publisher")]
        public string Publisher { get; set; }
        [BsonElement("PageCount")]
        public string PageCount { get; set; }
        [BsonElement("Language")]
        public string Language { get; set; }
        [BsonElement("NumberOfBook")]
        public int NumberOfBook { get; set; }

        public Book(string title, string author, string editor, string ıSBN, string publishYear, string edition, string publisher, string pageCount, string language, int numberOfBook)
        {
            Title = title;
            Author = author;
            Editor = editor;
            ISBN = ıSBN;
            PublishYear = publishYear;
            Edition = edition;
            Publisher = publisher;
            PageCount = pageCount;
            Language = language;
            NumberOfBook = numberOfBook;
        }

    }
}
