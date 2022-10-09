using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1_
{
    class program
    {
        static void Main(string[] args)
        {
            program program = new program();
            program.palindrome();
            program.length();
            program.reverse();
            program.compare();
            Console.ReadLine();

        }

        public void palindrome()
        {
            string input, r;
            input = "Madam";
            char[] letter = input.ToCharArray();
            Array.Reverse(letter);
            r = new string(letter);
            bool bool1 = input.Equals(r, StringComparison.OrdinalIgnoreCase);
            if (bool1 == true)
            {
                Console.WriteLine("This string " + input + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine("This string " + input + " is not a Palindrome!");
            }
            Console.WriteLine("press Enter to continue ");
            Console.ReadLine();
        }
        public void length()
        {
            string s1 = "man";
            Console.WriteLine(" length of the word:" + s1.Length);
        }
        public void reverse()
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
        public void compare()
        {
            string s1 = "man";
            string s2 = "man";
            bool result = string.Equals(s1, s2);
            Console.WriteLine(result);
        }
    }
}
