using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ADumb : IDumb
    {
        public string Name()
        {
            return "A type Dumb Phone";
        }
    }

    class BDumb : IDumb
    {
        public string Name()
        {
            return "B type Dumb Phone";
        }
    }

    class CDumb : IDumb
    {
        public string Name()
        {
            return "C type Dumb Phone";
        }
    }
}
