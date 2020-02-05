using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public virtual void AddCustomer()
        {
            Console.Write("Enter Id -> ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name -> ");
            Name = Console.ReadLine();
            Console.Write("Enter Mobile -> ");
            Mobile = Console.ReadLine();
        }

        public virtual void PrintCustomer()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Mobile = " + Mobile);
        }
    }
    class BronzeCustomer : Customer
    {
        public string Discount { get; set; }
        public override void AddCustomer()
        {

            base.AddCustomer();
            Console.Write("Enter Your Discount -> ");
            Discount = Console.ReadLine();
        }

        public override void PrintCustomer()
        {

            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
        }
    }
    class SilverCustomer : Customer
    {
        public string Discount { get; set; }
        public override void AddCustomer()
        {

            base.AddCustomer();
            Console.Write("Enter Your Discount -> ");
            Discount = Console.ReadLine();
        }

        public override void PrintCustomer()
        {

            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("I have free two-day shipping.");
        }

    }

    class GoldCustomer : Customer
    {
        public string Discount { get; set; }
        public override void AddCustomer()
        {

            base.AddCustomer();
            Console.Write("Enter Your Discount -> ");
            Discount = Console.ReadLine();
        }

        public override void PrintCustomer()
        {

            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("I have free two-day shipping.");
            Console.WriteLine("I also have free returns.");
        }
    }

    class PlatinumCustomer : Customer
    {
        public string Discount { get; set; }
        public string CashBack { get; set; }
        public override void AddCustomer()
        {

            base.AddCustomer();
            Console.Write("Enter Your Discount -> ");
            Discount = Console.ReadLine();
            Console.Write("Enter Your CashBack -> ");
            CashBack = Console.ReadLine();
        }

        public override void PrintCustomer()
        {

            base.PrintCustomer();
            Console.WriteLine("Discount = " + Discount);
            Console.WriteLine("I have free two-day shipping.");
            Console.WriteLine("I also have free returns.");
            Console.WriteLine("CashBack = " + CashBack);
        }
    }
}
