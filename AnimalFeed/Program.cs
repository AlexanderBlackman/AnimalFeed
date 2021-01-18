using System;

namespace AnimalFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vend = new AnimalFeedVendingMachine();

            Console.WriteLine(vend.Dispense(2.00M));




        }
    }
}
