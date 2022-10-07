using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Methods_Assignment
{
    internal class ArmstrongNumbersBetweenIntervals
    {
        public static void Main()
        {
            int num1, num2, n, sum, r;
            Console.Write("Please Enter First number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Second number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Armstrong Number from {0} to {1}", num1, num2);
            for (int i = num1; i <= num2; i++)
            {
                sum = 0;
                n = i;
                while (n != 0)
                {
                    r = n % 10;
                    sum = sum + (r * r * r);
                    n = n / 10;
                }
                if (i == sum)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
