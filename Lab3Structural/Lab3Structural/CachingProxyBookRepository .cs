using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class CachingProxyBookRepository : IBookRepository
    {
        private readonly IBookRepository _bookRepository;
        private readonly Dictionary<string, Book> _cache;

        public CachingProxyBookRepository(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _cache = new Dictionary<string, Book>();
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
            _cache[book.Title] = book;
        }

        public void RemoveBook(Book book)
        {
            _bookRepository.RemoveBook(book);
            _cache.Remove(book.Title);
        }

        public Book GetBookByTitle(string title)
        {
            if (_cache.ContainsKey(title))
            {
                return _cache[title];
            }

            var book = _bookRepository.GetBookByTitle(title);
            if (book != null)
            {
                _cache[title] = book;
            }

            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            // Notă: Caching proxy nu stochează întreaga colecție de cărți,
            // ci extrage cărțile din depozitul de bază de fiecare dată.
            return _bookRepository.GetAllBooks();
        }
    }

}
