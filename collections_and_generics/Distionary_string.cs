using System;
using System.Collections.Generic;

class DictionaryExample
{
    static void Main()
    {
        Dictionary<string, string> students = new Dictionary<string, string>();

        // Adding key-value pairs
        students.Add("Sandesh", "sandesh@gmail.com");
        students.Add("Amrit", "amrit@gmail.com");
        students.Add("Shiva", "Shiva@gmail.com");

        Console.WriteLine("Student Names and Emails:");
        foreach (var pair in students)
        {
            Console.WriteLine("Name: " + pair.Key + ", Email: " + pair.Value);
        }
    }
}
