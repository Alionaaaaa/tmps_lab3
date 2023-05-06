using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public class BorrowableDecorator : ILibraryItemDecorator
    {
        public ILibraryItem Item { get; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public int NumberOfCopies { get => Item.NumberOfCopies; set => Item.NumberOfCopies = value; }
        public string Title => Item.Title;

        public BorrowableDecorator(ILibraryItem item)
        {
            Item = item;
        }

        public void BorrowItem(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
            NumberOfCopies--;
        }

        public void ReturnItem()
        {
            Borrower = null;
            BorrowDate = default;
            NumberOfCopies++;
        }

        public void Display()
        {
            Item.Display();
            if (!string.IsNullOrEmpty(Borrower))
            {
                Console.WriteLine($"Borrower: {Borrower}, Borrow Date: {BorrowDate.ToShortDateString()}");
            }
        }
    }
}
