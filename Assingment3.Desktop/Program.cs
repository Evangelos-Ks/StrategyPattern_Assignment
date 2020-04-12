using Assignment3.Entities;
using System;

namespace Assingment3.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Eshop eshop = new Eshop();
            eshop.MakeAndDisplayTShirt();
            eshop.ChooseAndDispayPaymentMethod();
            eshop.TryToPayAndDisplayTheResult();

            Console.ReadKey();
        }
    }
}
