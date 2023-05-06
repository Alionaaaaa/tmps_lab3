using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class Book : ILibraryItem
    {
        public string Title { get; }
        public int NumberOfCopies { get; set; }

        public Book(string title, int numberOfCopies)
        {
            Title = title;
            NumberOfCopies = numberOfCopies;
        }

        public void Display()
        {
            Console.WriteLine($"Book: '{Title}', Copies: {NumberOfCopies}");
        }
    }
}
