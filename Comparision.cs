using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisions
{
    public class Comparision
    {
        public void LengthOfLine()
        {
            Console.Write("Enter the value of x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //Length of Line = sqrt[(x2-x1)^2 + (y2-y1)^2]
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(result);
        }
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
        public void Compair(double line1, double line2)
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
        public static int line1;
        public static int line2;
        public int LengthOne()
        {
            Console.WriteLine("Enter a number: ");
            line1 = Convert.ToInt32(Console.ReadLine());
            return line1;
        }
        public int LengthTwo()
        {
            Console.WriteLine("Enter a number: ");
            line2 = Convert.ToInt32(Console.ReadLine());
            return line2;
        }
         public void Check()
        {
            line1 = LengthOne();
            line2 = LengthTwo();

            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both line are equal");
            }
            else
            {
                Console.WriteLine("Both line are not equal");
            }

        }
    }
}
    

