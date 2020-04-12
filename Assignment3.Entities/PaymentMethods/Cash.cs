using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities.PaymentMethods
{
    class Cash : IPayMethod
    {
        public bool Pay(decimal amount)
        {
            if (amount <= 0) return false;
            else return true;
        }
    }
}
