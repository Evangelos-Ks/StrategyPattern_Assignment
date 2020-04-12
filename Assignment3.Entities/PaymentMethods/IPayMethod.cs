using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities.PaymentMethods
{
    interface IPayMethod
    {
        bool Pay(decimal amount);
    }
}
