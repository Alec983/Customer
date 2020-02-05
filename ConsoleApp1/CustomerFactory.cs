using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomerFactory
    {
        public Customer GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.BronzeCustomer:
                    return new BronzeCustomer();
                case (int)Options.SilverCustomer:
                    return new SilverCustomer();
                case (int)Options.GoldCustomer:
                    return new GoldCustomer();
                case (int)Options.PlatinumCustomer:
                    return new PlatinumCustomer();
                default:
                    Console.WriteLine("Invalid Option");
                    return null;
            }
        }
    }
}
