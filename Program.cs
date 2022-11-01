using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("indulagörögaludni");
            Console.WriteLine();
            IsPalindrome("koromfekete");
            Console.ReadLine();
        }

        private static void IsPalindrome(string str) 
        { 
            Console.WriteLine("The word is: " +str);

            Console.WriteLine();

            char[] chars = str.ToCharArray();

            Array.Reverse(chars);

            string reversedString = new string(chars);

            if (str.Equals(reversedString))
            {
                Console.WriteLine(str + " is palindrome.");
            }
            else 
            {
                Console.WriteLine(str + " is not palindrome.");
            }

        }
    }
}
