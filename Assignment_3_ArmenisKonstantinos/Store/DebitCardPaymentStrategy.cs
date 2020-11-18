using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.Store
{
    class DebitCardPaymentStrategy : IpaymentStrategy
    {

        public string Name => nameof(DebitCardPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your payment with the debit card is succeed";
        }
    }
}
