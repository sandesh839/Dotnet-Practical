using System;

class RefOutExample
{
    static void UpdateValues(ref int a, out int b)
    {
        a = a + 5;    // `ref` requires initialization before passing
        b = 100;      // `out` must be assigned in the method
    }

    static void Main()
    {
        int x = 10;
        int y;

        UpdateValues(ref x, out y);

        Console.WriteLine("x after ref = " + x); // x becomes 15
        Console.WriteLine("y after out = " + y); // y becomes 100
    }
}
