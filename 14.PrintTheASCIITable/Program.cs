using System;
using System.Text;
/*
    Problem 14.* Print the ASCII Table
    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 */
class PrintTheASCIITable
{
    static void Main()
    {
        for (int i=0; i<256; i++)
        {
            char symbol = (char)i;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(symbol + " ");
        }
        Console.WriteLine();
    }
}
