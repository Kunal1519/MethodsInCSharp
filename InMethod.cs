using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class InMethod
    {

        public void main()
        {
            int readonlyArgument = 44;

            InArgExample(readonlyArgument);
            Console.WriteLine(readonlyArgument);     // value is still 44

        }
        void InArgExample(in int number)
        {
            int a;
            a = number + 10;
            Console.WriteLine(a);
        }

    }
}
