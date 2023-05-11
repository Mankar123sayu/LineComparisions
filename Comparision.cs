using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisions
{
    public class Comparision
    {
        public void EqualityCheck(double line1, double line2)
        {
            if (line1.Equals(line2))
            {
                Console.WriteLine("Both line1 and line2 are equal.");
            }
            else
            {
                Console.WriteLine("Line1 and line2 are not equal.");
            }
        }
    }
}
