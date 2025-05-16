using System;

class CircleArea
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
