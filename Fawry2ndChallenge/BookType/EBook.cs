using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge.BookType
{
    internal class EBook : Book
    {
        string FileType;

        public EBook(string _iSBN, string _title, int _yearPublished, decimal _price, string _auther, string _fileType) : base(_iSBN, _title, _yearPublished, _price, _auther)
        {
            FileType = _fileType;
        }

        public override bool IsAvailable(int quantity)
        {
            return quantity == 1;
        }
        public override decimal Buy(int quantity, string email, string address)
        {
            if (quantity != 1)
                Console.WriteLine("You can buy only 1 EBook ");
            decimal Total = Price;
            Console.WriteLine($"The EBook '{Title}' bought for {Total}$ ");
            Console.WriteLine($"Sending to Email : {email}");
            return Total;
        }
    }
}
