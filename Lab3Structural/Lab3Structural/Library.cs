using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class Library
    {
        private readonly List<ILibraryItem> _items;

        public IEnumerable<object> Items { get; internal set; }

        public Library()
        {
            _items = new List<ILibraryItem>();
        }

        public void AddItem(ILibraryItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(ILibraryItem item)
        {
            _items.Remove(item);
        }

        public ILibraryItem GetItem(string title)
        {
            return _items.Find(item => item.Title == title);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Library Items:");
            foreach (var item in _items)
            {
                item.Display();
            }
        }
    }

}
