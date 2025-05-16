using System;

class OverloadExample
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    static void Main()
    {
        OverloadExample obj = new OverloadExample();

        Console.WriteLine("Sum (int): " + obj.Add(5, 10));
        Console.WriteLine("Sum (float): " + obj.Add(2.5f, 3.5f));
    }
}
