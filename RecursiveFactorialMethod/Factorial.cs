using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorialMethod
{
    public class Factorial
    {

        public int Calculate(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Calculate(number - 1);

        }
    }
}
