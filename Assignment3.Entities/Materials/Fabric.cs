using System.Collections.Generic;

namespace Assignment3.Entities
{
    class Fabric
    {
        public static Dictionary<Fabrics, decimal> Cost = new Dictionary<Fabrics, decimal>()
        {
                { Fabrics.Cashmere, 15m },
                { Fabrics.Cotton, 12m },
                { Fabrics.Linel, 10m },
                { Fabrics.Polyester, 10.5m },
                { Fabrics.Rayon, 11m },
                { Fabrics.Silk, 22m },
                { Fabrics.Wool, 16m }
        };              
    }

    public enum Fabrics
    {
        Cashmere = 1,
        Cotton,
        Linel,
        Polyester,
        Rayon,
        Silk,
        Wool
    }

}
