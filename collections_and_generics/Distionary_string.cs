using System;
using System.Collections.Generic;

class DictionaryExample
{
    static void Main()
    {
        Dictionary<string, string> students = new Dictionary<string, string>();

        // Adding key-value pairs
        students.Add("Aayush", "aayush@example.com");
        students.Add("Sita", "sita@example.com");
        students.Add("Ram", "ram@example.com");

        Console.WriteLine("Student Names and Emails:");
        foreach (var pair in students)
        {
            Console.WriteLine("Name: " + pair.Key + ", Email: " + pair.Value);
        }
    }
}
