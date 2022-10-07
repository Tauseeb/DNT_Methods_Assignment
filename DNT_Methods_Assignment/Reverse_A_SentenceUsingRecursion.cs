using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Methods_Assignment
{
    internal class Reverse_A_SentenceUsingRecursion
    {
        public void ReverseSentence(string str)
        {
            if (str.Length > 0)
                ReverseSentence(str.Substring(1, str.Length - 1));
            else
                return;
            Console.Write(str[0]);
        }

        public static void Main()
        {           
            Console.WriteLine("Please Enter A Sentence..");
            string str=Console.ReadLine();

            Reverse_A_SentenceUsingRecursion rvsObj = new Reverse_A_SentenceUsingRecursion();
            Console.WriteLine("Your Sentence: " + str);
            Console.WriteLine();
            Console.Write("Reversed Sentence: ");
            rvsObj.ReverseSentence(str);

            Console.ReadLine();
        }
    }
}
