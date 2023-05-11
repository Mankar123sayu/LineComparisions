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
    }
}
