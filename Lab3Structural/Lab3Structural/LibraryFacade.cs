using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class LibraryFacade
    {
        private readonly Library _library;
        private readonly ILibraryAdapter _adapter;

        public LibraryFacade()
        {
            _library = new Library();
            _adapter = new LibraryAdapter(_library);
        }

        public void AddBook(string title, int numberOfCopies)
        {
            var book = new Book(title, numberOfCopies);
            _adapter.Add(book);
        }

        public void RemoveBook(string title)
        {
            var book = _library.GetItem(title);
            _adapter.Remove(book);
        }

        public void BorrowBook(string title, string borrower)
        {
            var book = _library.GetItem(title);
            var borrowableBook = new BorrowableDecorator(book);
            borrowableBook.BorrowItem(borrower);
            _adapter.Remove(book);
            _adapter.Add(borrowableBook);
        }

        public void ReturnBook(string title)
        {
            var book = _library.GetItem(title);
            var borrowableBook = book as BorrowableDecorator;
            borrowableBook.ReturnItem();
            _adapter.Remove(book);
            _adapter.Add(borrowableBook.Item);
        }

        
        public Library GetLibrary()
        {
            return _library;
        }

        public void DisplayItems()
        {
            Console.WriteLine("Library Items:");
        }

    }
}
