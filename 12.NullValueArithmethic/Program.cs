using System;
/*
    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
 */
class NullValueArithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine(i);
        Console.WriteLine(d);

        i = i + 15;
        Console.WriteLine(i);

        d = d + 123.543;
        Console.WriteLine(d);

        i = i + null;
        Console.WriteLine(i);
    }
}
