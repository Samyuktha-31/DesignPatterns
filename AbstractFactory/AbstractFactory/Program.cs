using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    enum Manufacturers
    {
        a,
        b,
        c
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhoneChecker phone1 = new PhoneChecker(Manufacturers.a);

            phone1.CheckType();

            PhoneChecker phone2 = new PhoneChecker(Manufacturers.b);

            phone2.CheckType();

            PhoneChecker phone3 = new PhoneChecker(Manufacturers.c);

            phone3.CheckType();

            Console.ReadLine();
        }
    }

    class PhoneChecker
    {
        Manufacturers manuf;
        IPhoneFactory factory;

        public PhoneChecker(Manufacturers m)
        {
            manuf = m;
        }

        public void CheckType()
        {
            switch(manuf)
            {
                case Manufacturers.a:
                    factory = new A();
                    break;
                case Manufacturers.b:
                    factory = new B();
                    break;
                case Manufacturers.c:
                    factory = new C();
                    break;
            }

            Console.WriteLine(manuf + ": Smart phone - " + factory.GetSmart().Name() + " and Dumb phone - " + factory.GetDumb().Name());
        }
    }
}
