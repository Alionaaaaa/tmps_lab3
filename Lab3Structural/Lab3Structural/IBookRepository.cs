using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
        Book GetBookByTitle(string title);
        IEnumerable<Book> GetAllBooks();
    }
}
