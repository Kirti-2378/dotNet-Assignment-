using System;

class Question4
{
    static void Main()
    {
        Console.Write("Enter Student Marks (0-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 91 && marks <= 100)
        {
            Console.WriteLine("Grade: O");
        }
        else if (marks >= 81 && marks <= 90)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 71 && marks <= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 61 && marks <= 70)
        {
            Console.WriteLine("Grade: B+");
        }
        else if (marks >= 51 && marks <= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 0 && marks < 50)
        {
            Console.WriteLine("Grade: Fail");
        }
        else
        {
            Console.WriteLine("Invalid Marks! Please enter marks between 0 and 100.");
        }
    }
}