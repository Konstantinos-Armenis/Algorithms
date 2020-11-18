using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.Store
{
    class BankPaymentStrategy : IpaymentStrategy
    {
        public string Name => nameof(BankPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your payment via Bank is successfull";
        }
    }
}
