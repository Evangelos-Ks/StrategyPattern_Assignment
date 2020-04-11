using Assignment3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    class TShirt
    {
        //============================= Properties =====================================
        protected Fabrics TShirtFabric { get; }
        protected Colors TShirtColor { get; }
        protected Sizes TShirtSize { get; }
        protected decimal TShirtPrice { get; }

        public TShirt(Fabrics fabric, Colors color, Sizes size)
        {
            TShirtFabric = fabric;
            TShirtColor = color;
            TShirtSize = size;
            TShirtPrice = (Color.Cost[color] + Fabric.Cost[fabric] + Size.Cost[size]);
        }

        public void DisplayTShirt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\tThe T-shirt that you have selected has :");
            Console.WriteLine( );
            Console.WriteLine($"\tColor : {TShirtColor.ToString()}");
            Console.WriteLine($"\tSize : {TShirtSize.ToString()}");
            Console.WriteLine($"\tFabric : {TShirtFabric.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"\tPrice : {TShirtPrice}");
            Console.ForegroundColor = ConsoleColor.White;

        }




    }
}
