using System.Collections.Generic;

namespace Assignment3.Entities.Enums
{
    class Color
    {
        public static Dictionary<Colors, decimal> Cost = new Dictionary<Colors, decimal>()
        {
                { Colors.Blue, 1m },
                { Colors.Green, 1.6m },
                { Colors.Indigo, 1.5m },
                { Colors.Orange, 0.5m },
                { Colors.Red, 1.7m },
                { Colors.Violet, 2.1m },
                { Colors.Yellow, 2m }
        };
    }
    
    public enum Colors
    {
        Blue = 1,
        Green,
        Indigo,
        Orange,
        Red,
        Violet,
        Yellow
    }
}
