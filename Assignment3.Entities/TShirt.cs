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
        public Fabric Fabric { get; }
        public Color Color { get; }
        public Size Size { get; }
        public decimal Price { get; set; }
    }
}
