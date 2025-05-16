using System;

abstract class Shape
{
    public abstract void Area();
}

class Circle : Shape
{
    public double Radius;

    public Circle(double r)
    {
        Radius = r;
    }

    public override void Area()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}

class Rectangle : Shape
{
    public double Length, Breadth;

    public Rectangle(double l, double b)
    {
        Length = l;
        Breadth = b;
    }

    public override void Area()
    {
        double area = Length * Breadth;
        Console.WriteLine("Area of Rectangle: " + area);
    }

    static void Main()
    {
        Shape s1 = new Circle(5);
        s1.Area();

        Shape s2 = new Rectangle(4, 6);
        s2.Area();
    }
}
