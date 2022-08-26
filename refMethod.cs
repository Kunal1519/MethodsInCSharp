using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class refMethod
    {
        void Method(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }

        public void refmain()
        {
            int number = 1;
            Method(ref number);
            Console.WriteLine(number);
        }
    }
}
