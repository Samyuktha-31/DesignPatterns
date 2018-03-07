using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class WindowsPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone phone;

        public WindowsPhoneBuilder()
        {
            phone = new MobilePhone("Windows Phone");
        }

        public void BuildOperatingSystem()
        {
            phone.OperatingSystem = OperatingSystem.Windows;
        }

        public void BuildScreen()
        {
            phone.ScreenType = ScreenType.NonTouch;
        }

        public void BuildStylus()
        {
            phone.Stylus = Stylus.No;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }
}
