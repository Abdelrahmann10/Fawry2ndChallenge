using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge
{
    abstract class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public decimal Price { get; set; }
        public string Auther { get; set; }

        protected Book(string _iSBN, string _title, int _yearPublished, decimal _price, string _auther)
        {
            ISBN = _iSBN;
            Title = _title;
            YearPublished = _yearPublished;
            Price = _price;
            Auther = _auther;
        }
        protected Book(string _iSBN, string _title, int _yearPublished, string _auther)
        {
            ISBN = _iSBN;
            Title = _title;
            YearPublished = _yearPublished;
            Auther = _auther;
        }

        abstract public bool IsAvailable(int quantity);
        abstract public decimal Buy(int quantity, string email, string address);
        virtual public void PrintDetails(){}

    }
}
