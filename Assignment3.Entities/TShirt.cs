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
        protected Fabric Fabric { get; }
        protected Color Color { get; }
        protected Size Size { get; }
        public decimal Price { get; }

        public TShirt(Fabric fabric, Color color, Size size)
        {
            Fabric = fabric;
            Color = color;
            Size = size;
        }

        public void DisplayTShirt(TShirt tshirt)
        {
            Console.WriteLine( );
            Console.Write($"\tColor : {tshirt.Color.ToString()}");
            Console.Write($"\tSize : {tshirt.Size.ToString()}");
            Console.Write($"\tFabric : {tshirt.Fabric.ToString()}");
            Console.WriteLine();
            //COST
        }


    }
}
