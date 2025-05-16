using System;
using System.Collections.Generic;

class ListExample
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine("Numbers in the List:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
