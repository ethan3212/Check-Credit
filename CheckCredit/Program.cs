using System;
using System.Reflection.Metadata;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            const double LIMIT = 8000;
            Console.Write("Please enter the price: ");
            price = Convert.ToDouble(Console.ReadLine());

            if (price > LIMIT)
                Console.WriteLine("You have exceed the credit limit of ${0}", LIMIT);
            else
                Console.WriteLine("Approved ");
        }
    }
}
