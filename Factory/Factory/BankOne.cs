using System;

namespace Factory
{
    class BankOne : IBank
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Choosed BankOne for payment for the product - " + product.Name + " which costs - " + product.Price);
        }
    }
}
