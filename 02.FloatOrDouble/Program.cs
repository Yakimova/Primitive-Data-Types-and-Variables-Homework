using System;
/*
    Problem 2. Float or Double? 
    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */
class FloatOrDouble
{
    static void Main()
    {
        double bigNumber = 34.567839023;
        float smallNumber = 12.345F;
        double biggerNumber = 8923.1234857;
        float notSoSmallNumber = 3456.091F;
        Console.WriteLine("{0} and {1} can be asigned to float. {2} and {3} cannot.", smallNumber, notSoSmallNumber, biggerNumber, bigNumber);
    }
}
