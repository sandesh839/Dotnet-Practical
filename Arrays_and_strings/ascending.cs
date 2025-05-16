using System;

class SortArray
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };

        // Sorting using bubble sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array in ascending order:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
