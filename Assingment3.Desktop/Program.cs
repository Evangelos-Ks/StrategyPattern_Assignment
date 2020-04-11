using Assignment3.Entities;
using Assignment3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Eshop eshop = new Eshop();
            eshop.MakeAndDisplayTShirt();

            Console.ReadKey();
        }
    }
}
