using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input 1st number: ");
            n = Convert.ToInt32(Console.ReadLine());

            // checking for odd/ even
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // checking for positive, negative or 0
            if (n < 0)
            {
                Console.WriteLine("Negative Number!");
            }
            else if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive Number!");
            }
        }
    }
}
