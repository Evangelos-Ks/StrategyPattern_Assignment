using System.Collections.Generic;

namespace Assignment3.Entities.Enums
{
    class Size
    {
        public static Dictionary<Sizes, decimal> Cost = new Dictionary<Sizes, decimal>()
        {
                { Sizes.XS, 7m },
                { Sizes.S, 7.5m },
                { Sizes.M, 8m },
                { Sizes.L, 8.5m },
                { Sizes.XL, 9m },
                { Sizes.XXL, 10m },
                { Sizes.XXXL, 11m }
        };
    }

    public enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }
}
