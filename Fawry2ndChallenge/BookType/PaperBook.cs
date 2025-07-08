using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge.BookType
{
    internal class PaperBook : Book
    {
        public int Stock { get; private set; }
         
        public PaperBook(string _iSBN, string _title, int _yearPublished, decimal _price, string _auther, int _Stock) : base(_iSBN, _title, _yearPublished, _price, _auther)
        {
            Stock = _Stock;
        }

        public override bool IsAvailable(int quantity)
        {
            return Stock >= quantity;
        }

        public override decimal Buy(int quantity, string email, string address)
        {
            if(!IsAvailable(quantity))
                Console.WriteLine("Not enough stock");
            Stock -= quantity;
            decimal Total = quantity * Price;
            Console.WriteLine($"The PaperBook '{Title}' bought for {Total}$ ");
            Console.WriteLine($"Sending to Address : {address}");
            return Total;
        }
    }
}
