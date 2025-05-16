using System;

class LargestIn2DArray
{
    static void Main()
    {
        int[,] arr = {
            { 5, 7, 3 },
            { 9, 2, 8 },
            { 6, 1, 4 }
        };

        int max = arr[0, 0];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }

        Console.WriteLine("Largest element in 2D array: " + max);
    }
}
