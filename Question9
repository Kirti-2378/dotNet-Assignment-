using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number;
            int reverse = 0;

            while(number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;

            }
            if(temp == reverse)
            {
                Console.WriteLine("Palindrome");
            } else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
