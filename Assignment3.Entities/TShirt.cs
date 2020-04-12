using Assignment3.Entities.Enums;
using System;

namespace Assignment3.Entities
{
    class TShirt
    {
        //============================= Properties =====================================
        protected Fabrics TShirtFabric { get; }
        protected Colors TShirtColor { get; }
        protected Sizes TShirtSize { get; }
        public decimal TShirtPrice { get; }

        //============================= Constructor =====================================
        public TShirt(Fabrics fabric, Colors color, Sizes size)
        {
            TShirtFabric = fabric;
            TShirtColor = color;
            TShirtSize = size;
            TShirtPrice = (Color.Cost[color] + Fabric.Cost[fabric] + Size.Cost[size]);
        }

        //============================= Methods =====================================
        public void DisplayTShirt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\tThe T-shirt that you have selected has :");
            Console.WriteLine();
            Console.WriteLine($"\tColor : {TShirtColor.ToString()}");
            Console.WriteLine($"\tSize : {TShirtSize.ToString()}");
            Console.WriteLine($"\tFabric : {TShirtFabric.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"\tPrice : {TShirtPrice}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
