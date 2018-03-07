using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MobilePhone
    {
        string name;
        ScreenType screenType;
        OperatingSystem operatingSystem;
        Stylus stylus;

        public MobilePhone(string n)
        {
            name = n;
        }

        public string PhoneName
        {
            get { return name; }
        }

        public ScreenType ScreenType
        {
            get { return screenType; }
            set { screenType = value; }
        }

        public OperatingSystem OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }

        public Stylus Stylus
        {
            get { return stylus; }
            set { stylus = value; }
        }

        public override string ToString()
        {
            return string.Format("Name : {0}, Screen Type : {1}, Operating System : {2}, Stylus : {3}", name, screenType, operatingSystem, stylus);
        }
    }
}
