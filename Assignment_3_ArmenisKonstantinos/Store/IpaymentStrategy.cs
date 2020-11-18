using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.Store
{
     interface IpaymentStrategy
    {
        string Name { get; }

        string ChoosePaymentMethod();
    }
}
