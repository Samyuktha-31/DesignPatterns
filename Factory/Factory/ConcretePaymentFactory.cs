using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConcretePaymentFactory : PaymentFactory
    {
        public override IBank PaymentBank(PaymentType type, Product product)
        {
            IBank bank = null;

            switch (type)
            {
                case PaymentType.New_Bank:
                    bank = new NewBank();
                    break;
                default:
                    bank = base.PaymentBank(type, product);
                    break;
            }

            return bank;
        }
    }
}
