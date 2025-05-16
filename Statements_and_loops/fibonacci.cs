using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        Console.Write("Fibonacci Series: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
