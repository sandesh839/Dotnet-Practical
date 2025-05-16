using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }

        if (str == reversed)
            Console.WriteLine(str + " is a palindrome.");
        else
            Console.WriteLine(str + " is not a palindrome.");
    }
}
