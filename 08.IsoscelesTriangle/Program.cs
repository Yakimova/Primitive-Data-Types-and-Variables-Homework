using System;
using System.Text;
/*
    Problem 8. Isosceles Triangle
    Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 */
class IsoscelesTriangle
{
    static void Main()
    {
        char copyright = '©';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(@"     {0}

    {0} {0}

   {0}   {0}

  {0} {0} {0} {0}", copyright);
    }
}
