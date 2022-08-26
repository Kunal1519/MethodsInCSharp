using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class OutMethod
    {
        public void OutMethods()
        {
            int initializeInMethod;
            OutArgExample(out initializeInMethod);
            Console.WriteLine(initializeInMethod);
        }

        void OutArgExample(out int number)
        {
            number = 44 +1;
            
        }
    }
}
