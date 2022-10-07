using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Methods_Assignment
{
    internal class FactorialUsingRecursion
    {
        public int Factorial(int fact)
        {
            if (fact == 1)
            {
                return 1;
            }

            else
            {
                return fact * Factorial(fact - 1);
            }

        }
        public static void Main()
        {           
            Console.WriteLine("Enter The Number To Find Factorial..");
            int num = Convert.ToInt32(Console.ReadLine());

            FactorialUsingRecursion fact = new FactorialUsingRecursion();
            int result = fact.Factorial(num);
            Console.WriteLine("The Factorial Value is : {0}", result);

            Console.ReadLine();
        }
    }
}
