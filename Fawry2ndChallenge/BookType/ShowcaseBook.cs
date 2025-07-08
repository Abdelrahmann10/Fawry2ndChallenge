using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge.BookType
{
    internal class ShowcaseBook : Book
    {
        public ShowcaseBook(string _iSBN, string _title, int _yearPublished, string _auther) : base(_iSBN, _title, _yearPublished, _auther)
        {
        }
        public override bool IsAvailable(int quantity)
        {
            return false;
        }
        public override decimal Buy(int quantity, string email, string address)
        {
            throw new InvalidOperationException("Showcase books are not for sale");
        }
    }
}
