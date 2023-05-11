using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisions
{
          public  void Compair(double line1, double line2)
            {
                if (line1.CompareTo(line2) == 0)
                {
                    Console.WriteLine("Both line1 and line2 are equal.");
                }
                else if (line1.CompareTo(line2) > 0)
                {
                    Console.WriteLine("Line1 is greater than line2.");
                }
                else
                {
                    Console.WriteLine("Line1 is smaller than line2.");
                }
            }
       }
    

