using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.Print();
            int choice = Convert.ToInt32(Console.ReadLine());
            Customer customer = new CustomerFactory().GetObject(choice);
            if (customer != null)
            {
                customer.AddCustomer();
                customer.PrintCustomer();
            }
            Console.Read();
        }
    }
}
