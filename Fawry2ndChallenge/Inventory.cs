using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge
{
    internal class Inventory
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"The book '{book.Title}' has been added successfully");
        }
        public List<Book> RemoveOutDatedBooks(int MaxYears)
        {
            List<Book> removedBooks = new List<Book>();
            int currentYear = DateTime.Now.Year;
            for (int i = books.Count - 1; i >= 0; i--)
            {
                Book book = books[i];
                int age = currentYear - book.YearPublished;
                if(age > MaxYears)
                {
                    removedBooks.Add(book);
                    books.RemoveAt(i);
                    Console.WriteLine($"The book '{book.Title}' has been removed");
                }
            }
            return removedBooks;
        }

        public decimal BuyBook(string isbn, int quantity, string email, string address)
        {
            foreach(Book b in books)
            {
               if(b.ISBN == isbn)
               {
                    if(!b.IsAvailable(quantity))
                        Console.WriteLine("Book not available for purchase");
                    return b.Buy(quantity, email, address);
               }
            }
            throw new ArgumentException($"Book with ISBN {isbn} not found");
        }
    }
}
