using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "AERISIREA";
            string reversed = Reverse(original);
            bool isPalindrome = IsPalindrom(original);

            Console.WriteLine("Original=" + original);
            Console.WriteLine("Reversed=" + reversed);
            Console.WriteLine("IsPalindrome=" + isPalindrome);
        }
        private static bool IsPalindrom(string text)
        {
            string reversed = Reverse(text);
            bool isPalyndrome = string.Equals(text, reversed, StringComparison.OrdinalIgnoreCase);
            return isPalyndrome;
        }
    }
}
