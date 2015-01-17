using System;
/*
    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */
class DeclareVariables
{
    static void Main()
    {
        uint ui = 52130;
        short s = -115;
        long l = 4825932;
        byte b = 97;
        int i = -10000;
        Console.WriteLine("The numbers are {0}, {1}, {2}, {3} and {4}.", ui, s, l, b, i);
    }
}
