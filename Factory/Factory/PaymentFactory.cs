using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PaymentFactory
    {
        public virtual IBank PaymentBank(PaymentType type, Product product)
        {
            IBank bank = null;

            switch(type)
            {
                case PaymentType.Bank_One:
                    bank = new BankOne();
                    break;
                case PaymentType.Bank_Two:
                    bank = new BankTwo();
                    break;
                case PaymentType.Best_One:
                    if (product.Price < 50)
                    {
                        bank = new BankOne();
                    }
                    else
                    {
                        bank = new BankTwo();
                    }
                    break;
            }

            return bank;
        }
    }
}
