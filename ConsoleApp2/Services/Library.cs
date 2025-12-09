using ConsoleApp2.Models;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    public class Library
    {
        private List<Book> books = new List<Book>(); // Encapsulation

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBooks()
        {
            Console.WriteLine("\n📚 Kütüphane Kitap Listesi:\n");

            foreach (var book in books)
                Console.WriteLine(book.GetInfo());
        }
    }
}
