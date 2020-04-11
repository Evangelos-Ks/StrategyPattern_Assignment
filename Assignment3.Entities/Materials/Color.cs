using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities.Enums
{
    class Color
    {
        public static Dictionary<Colors, decimal> Cost = new Dictionary<Colors, decimal>()
        {
                { Colors.Blue, 1m },
                { Colors.Green, 1m },
                { Colors.Indigo, 1.5m },
                { Colors.Orange, 0.5m },
                { Colors.Red, 1.7m },
                { Colors.Violet, 2.1m },
                { Colors.Yellow, 2m }
        };
    }

    enum Colors
    {
        Blue,
        Green,
        Indigo,
        Orange,
        Red,
        Violet,
        Yellow
    }
}
