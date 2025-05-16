using System;

class VowelCounter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();  // Convert to lowercase

        int count = 0;

        foreach (char c in input)
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}
