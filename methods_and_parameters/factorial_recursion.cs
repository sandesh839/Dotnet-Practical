using System;

class RecursiveFactorial
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);  // Recursive call
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long result = Factorial(num);
        Console.WriteLine("Factorial of " + num + " = " + result);
    }
}
