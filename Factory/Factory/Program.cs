using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum PaymentType
    {
        Bank_One,
        Bank_Two,
        Best_One,

        New_Bank
    }
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            Product product = new Product();
            product.Name = "Soft Toy";
            product.Description = "Play Stuff";
            product.Price = 49;

            processor.MakePayment(product, PaymentType.Bank_One);

            product.Price = 79;

            processor.MakePayment(product, PaymentType.Best_One);

            processor.MakePayment(product, PaymentType.New_Bank);
        }
    }

    public class PaymentProcessor
    {
        public void MakePayment(Product product, PaymentType type)
        {
            ConcretePaymentFactory factory = new ConcretePaymentFactory();
            IBank bank = factory.PaymentBank(type, product);

            bank.MakePayment(product);
        }
    }
}
