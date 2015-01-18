using System;
/*
    Problem 4. Unicode Character
    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
 */
class UnicodeCharacter
{
    static void Main()
    {
        // the hexadecimal representation of 42 is 2A
        char symbol = '\u002A';
        Console.WriteLine("The symbol with Unicode code 42 is " + symbol);
    }
}
