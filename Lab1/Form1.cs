using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private Library library = new Library();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            var book = new Book(txtTitle.Text, txtAuthor.Text, year, txtISBN.Text);
            library.AddBook(book);
            UpdateBookList();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Please enter the ISBN of the book to remove.");
                return;
            }

            library.RemoveBook(txtISBN.Text);
            UpdateBookList();
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            var books = library.SearchByTitle(txtTitle.Text);
            lstBooks.DataSource = books;
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            var books = library.SearchByAuthor(txtAuthor.Text);
            lstBooks.DataSource = books;
        }

        private void UpdateBookList()
        {
            lstBooks.DataSource = null; // Очищення даних
            lstBooks.DataSource = library.GetAllBooks();
            lstBooks.DisplayMember = "Title"; // Налаштуйте властивість для відображення
        }
    }
}
