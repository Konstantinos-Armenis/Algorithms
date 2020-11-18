using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.Store
{
    class CashPaymentStrategy : IpaymentStrategy
    {

        public string Name => nameof(CashPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your cash payment is successfull";
        }
    }
}
