using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    class Fabric
    {
        public static Dictionary<Fabrics, decimal> Cost = new Dictionary<Fabrics, decimal>()
        {
                { Fabrics.Cashmere, 15m },
                { Fabrics.Cotton, 12m },
                { Fabrics.Linel, 10m },
                { Fabrics.Polyester, 10m },
                { Fabrics.Rayon, 11m },
                { Fabrics.Silk, 22m },
                { Fabrics.Wool, 16m }
        };              
    }

    enum Fabrics
    {
        Cashmere,
        Cotton,
        Linel,
        Polyester,
        Rayon,
        Silk,
        Wool
    }

}
