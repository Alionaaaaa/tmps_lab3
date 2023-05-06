using Lab3Structural;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new LibraryFacade instance
        var libraryFacade = new LibraryFacade();

        // Add some books to the library
        libraryFacade.AddBook("The Great Gatsby", 5);
        libraryFacade.AddBook("To Kill a Mockingbird", 3);
        libraryFacade.AddBook("1984", 2);

        // Display all library items (using the Facade pattern)
        Console.WriteLine("All Library Items:");
        libraryFacade.DisplayItems();

        // Borrow a book (using the Decorator pattern)
        libraryFacade.BorrowBook("The Great Gatsby", "John Doe");

        // Display all library items (using the Facade pattern)
        Console.WriteLine("All Library Items:");
        libraryFacade.DisplayItems();

        // Remove a book (using the Adapter pattern)
        var adapter = new LibraryAdapter(libraryFacade.GetLibrary());
        var bookToRemove = adapter.GetItem("To Kill a Mockingbird");
        adapter.Remove(bookToRemove);

        // Display all library items (using the Facade pattern)
        Console.WriteLine("All Library Items:");
        libraryFacade.DisplayItems();
    }
}
