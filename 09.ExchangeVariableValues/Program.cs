using System;
/*
    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.
 */
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The values of \"a\" and \"b\" are {0} and {1}.", a, b);

        int c = a;
        a = b;
        b = c;
        Console.WriteLine("The values of \"a\" and \"b\" now are {0} and {1}.", a, b);
    }
}
