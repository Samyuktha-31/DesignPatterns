using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum ScreenType
    {
        Touch,
        NonTouch
    }

    public enum OperatingSystem
    {
        Android,
        Windows,
        Apple
    }

    public enum Stylus
    {
        Yes,
        No
    }

    class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildOperatingSystem();
            phoneBuilder.BuildStylus();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manufacturer manufacturer = new Manufacturer();
            IPhoneBuilder phone = null;

            phone = new AndroidPhoneBuilder();
            manufacturer.Construct(phone);

            Console.WriteLine("Phone Built with specifications - " + phone.Phone.ToString());

            phone = new WindowsPhoneBuilder();
            manufacturer.Construct(phone);

            Console.WriteLine("Phone built with specifications - " + phone.Phone.ToString());
            Console.ReadLine();
        }
    }
}
