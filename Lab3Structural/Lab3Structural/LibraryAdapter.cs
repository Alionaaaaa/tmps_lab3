using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class LibraryAdapter : ILibraryAdapter
    {
        private readonly Library _library;

        public LibraryAdapter(Library library)
        {
            _library = library;
        }

        public void Add(ILibraryItem item)
        {
            _library.AddItem(item);
        }

        public void Remove(ILibraryItem item)
        {
            _library.RemoveItem(item);
        }

        public ILibraryItem GetItem(string title)
        {
            return _library.GetItem(title);
        }

        public void Remove(string title)
        {
            var item = _library.GetItem(title);
            if (item != null)
            {
                _library.RemoveItem(item);
            }
        }
    } 
}
