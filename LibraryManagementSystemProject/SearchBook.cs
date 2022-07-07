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
    public partial class SearchBook : Form
    {
        public static IMongoClient client = new MongoClient();

        public static IMongoDatabase db = client.GetDatabase("librarydatabase");

        public static IMongoCollection<Book> collectionBook = db.GetCollection<Book>("book");
        public SearchBook()
        {
            InitializeComponent();
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

        private void btn_return_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
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
            if(txt_title.Text == "" && txt_author.Text == "" && txt_editor.Text == "" && txt_isbn.Text == "" && txt_publishyear.Text== "" &&
               txt_edition.Text == "" && txt_publisher.Text == "" && txt_pagecount.Text== "" && txt_language.Text=="" && txt_numberofbook.Text =="")
            {
                List<Book> list3 = collectionBook.AsQueryable().ToList();
                grid_searchresult.DataSource = list3;
            }
            else if (txt_numberofbook.Text == "")
            { 
                List<Book> list = collectionBook.Find(x => x.Title == txt_title.Text || x.Author == txt_author.Text ||
                                                        x.Editor == txt_editor.Text ||
                                                        x.ISBN == txt_isbn.Text ||
                                                        x.PublishYear == txt_publishyear.Text ||
                                                        x.Edition == txt_edition.Text ||
                                                        x.Publisher == txt_publisher.Text ||
                                                        x.PageCount == txt_pagecount.Text ||
                                                        x.Language == txt_language.Text ).ToList();
                grid_searchresult.DataSource = list;
            }
            else if (txt_numberofbook.Text != "")
            {
                List<Book> list = collectionBook.Find(x => x.Title == txt_title.Text ||
                                                    x.Author == txt_author.Text ||
                                                    x.Editor == txt_editor.Text ||
                                                    x.ISBN == txt_isbn.Text ||
                                                    x.PublishYear == txt_publishyear.Text ||
                                                    x.Edition == txt_edition.Text ||
                                                    x.Publisher == txt_publisher.Text ||
                                                    x.PageCount == txt_pagecount.Text ||
                                                    x.Language == txt_language.Text ||
                                                    x.NumberOfBook == Int32.Parse(txt_numberofbook.Text)).ToList();
                grid_searchresult.DataSource = list;
            }
        }
    }
}
