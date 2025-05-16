using System;

class SearchArray
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.Write("Enter element to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == search)
            {
                Console.WriteLine(search + " found at index " + i);
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine(search + " not found in the array.");
    }
}
