using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildOperatingSystem();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
