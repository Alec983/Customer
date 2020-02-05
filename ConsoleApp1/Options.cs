using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Options
    {
        BronzeCustomer = 1,
        SilverCustomer,
        GoldCustomer,
        PlatinumCustomer
    }

    class Menu
    {
        public void Print()
        {
            string[] names = Enum.GetNames(typeof(Options));
            int[] values = (int[])Enum.GetValues(typeof(Options));
            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Press {0} for {1}", values[i], names[i]);
            }
            Console.Write("Enter your option -> ");
        }
    }
}
