using System;
/*
    Problem 13.* Comparing Floats
    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
 */
class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        // cheking which number is bigger, so there are no mistakes
        if (a <= b)
        {
            Console.WriteLine("The numbers {0} and {1} are equal with precision 0.000001 --> {2} ", a, b, (eps > (b - a)));
        }
        else 
        {
            Console.WriteLine("The numbers {0} and {1} are equal with precision 0.000001 --> {2} ", a, b, (eps > (a - b)));
        }
    }
}