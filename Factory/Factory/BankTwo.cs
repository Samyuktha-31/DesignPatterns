using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BankTwo : IBank
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Choosed BankTwo for payment for the product - " + product.Name + " which costs - " + product.Price);
        }
    }
}
