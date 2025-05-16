using System;

class SwapWithoutThirdVariable
{
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine("Before swap: a = " + a + ", b = " + b);

        a = a + b;  // a = 15
        b = a - b;  // b = 5
        a = a - b;  // a = 10

        Console.WriteLine("After swap: a = " + a + ", b = " + b);
    }
}
