using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public Book GetBookByTitle(string title)
        {
            return _books.FirstOrDefault(book => book.Title == title);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
    }

}
