using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class AndroidPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone phone;

        public AndroidPhoneBuilder()
        {
            phone = new MobilePhone("Android Phone");
        }

        public void BuildOperatingSystem()
        {
            phone.OperatingSystem = OperatingSystem.Android;
        }

        public void BuildScreen()
        {
            phone.ScreenType = ScreenType.Touch;
        }

        public void BuildStylus()
        {
            phone.Stylus = Stylus.Yes;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }
}
