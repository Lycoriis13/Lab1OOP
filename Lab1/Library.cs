using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void LoadBooksFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length == 4)
                {
                    var title = parts[0];
                    var author = parts[1];
                    var year = int.TryParse(parts[2], out int y) ? y : 0;
                    var isbn = parts[3];

                    var book = new Book(title, author, year, isbn);
                    AddBook(book);
                }
            }
        }
    }
}
