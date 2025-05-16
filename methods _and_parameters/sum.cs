using System;

class SumMethod
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int result = Add(10, 20);
        Console.WriteLine("Sum = " + result);
    }
}
