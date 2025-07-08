using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry2ndChallenge.Services
{
    internal class ShippingService
    {
        public void ship(string address)
        {
            Console.WriteLine($"Shipping to {address}");
        }
    }
}
