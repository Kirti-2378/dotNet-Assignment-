using System;

namespace Question8
{
    internal class Question8
    {
        static void Main2(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Non Prime Number");
        }
    }
}