using Fawry2ndChallenge.BookType;

namespace Fawry2ndChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Book B01 = new PaperBook("11P", "FawryPaperBook", 2015, 100, "Abdelrahman Sorour", 4);
            Book B02 = new EBook("22E", "FawryEBook", 2018, 100, "Abdelrahman Sorour", "PDF");
            Book B03 = new ShowcaseBook("11D", "FawryDemoBook", 2025, "Abdelrahman Sorour");

            inventory.AddBook(B01);
            inventory.AddBook(B02);
            inventory.AddBook(B03);

            Console.WriteLine("--------------------");
            inventory.RemoveOutDatedBooks(10);

            inventory.BuyBook("11P", 1, "abdosorour10@gmail.com", "Cairo - 123 Main St");
            Console.WriteLine("--------------------");
            inventory.BuyBook("22E", 1, "abdosorour10@gmail.com", "Cairo - 123 Main St");
            Console.WriteLine("--------------------");
            try
            {
                inventory.BuyBook("11D", 1, "abdosorour10@gmail.com", "Cairo - 123 Main St");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }



        }
    }
}
