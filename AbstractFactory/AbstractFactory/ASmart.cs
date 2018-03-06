using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ASmart : ISmart
    {
        public string Name()
        {
            return "A type Smart Phone";
        }
    }

    class BSmart : ISmart
    {
        public string Name()
        {
            return "B type Smart Phone";
        }
    }

    class CSmart : ISmart
    {
        public string Name()
        {
            return "C type Smart Phone";
        }
    }
}
