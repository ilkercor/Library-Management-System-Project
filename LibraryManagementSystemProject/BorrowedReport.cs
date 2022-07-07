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
    public partial class BorrowedReport : Form
    {
        public static IMongoClient client = new MongoClient();

        public static IMongoDatabase db = client.GetDatabase("librarydatabase");

        public static IMongoCollection<Borrow> collectionBorrow = db.GetCollection<Borrow>("borrow");
        public BorrowedReport()
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
        private void btn_return_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Close();
        }
        private void BorrowedReport_Load(object sender, EventArgs e)
        {
            List<Borrow> list = collectionBorrow.Find(x => x.ReturnDate > DateTime.Now.AddDays(+7)).ToList();
            grid_borrowed.DataSource = list;
            List<Borrow> list2 = collectionBorrow.Find(x => x.ReturnDate <= DateTime.Now.AddDays(+7)).ToList();
            grid_upcomingreturn.DataSource = list2;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
            this.Close();
        }
    }
}
