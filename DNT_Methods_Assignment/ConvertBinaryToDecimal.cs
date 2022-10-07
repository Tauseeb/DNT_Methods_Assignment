using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Methods_Assignment
{
    internal class ConvertBinaryToDecimal
    {
     
        public static void Main()
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;          
            Console.WriteLine("Enter the number to convert binary number to decimal..");
            num = Convert.ToInt32(Console.ReadLine());
          
            binVal = num;

            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal);
            Console.Write("\nDecimal Values is: " + decVal);

            Console.ReadLine();
        }
    }
}
