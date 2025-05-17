using System;

public class VowelCounter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        
        int vowelCount = 0;
        
        foreach (char c in input)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++;
            }
        }

        // Use string interpolation
        // Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        
        // OR use string concatenation
        Console.WriteLine("The number of vowels in the string is: " + vowelCount);
    }
}
