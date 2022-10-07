using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Methods_Assignment
{
    internal class PrimeNumbersBetweenIntervals
    {
        public int checkPrimeNumber(int n)
        {
            int j, check = 1;

            for (j = 2; j <= n / 2; ++j)
            {

                if (n % j == 0)
                {
                    check = 0;
                    break;
                }
            }

            return check;

        }
        public static void Main()
        {
            int num1, num2, i, check;

            Console.WriteLine("Enter first positive integers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Engter second positive integer: ");
            num2=Convert.ToInt32(Console.ReadLine());

            // swap num1 and num2 if num1 > num2
            if (num1 > num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
            }

            Console.WriteLine("Prime numbers are: ");
            for (i = num1 + 1; i < num2; ++i)
            {

                // check will be equal to 1 if i is prime

                PrimeNumbersBetweenIntervals obj = new PrimeNumbersBetweenIntervals();

                check = obj.checkPrimeNumber(i);

                if (check == 1)
                {
                    Console.WriteLine(i);
                }
            }

            
        }
    }
}
