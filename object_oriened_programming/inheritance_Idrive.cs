using System;

interface IDrive
{
    void Start();
}

class Car : IDrive
{
    public void Start()
    {
        Console.WriteLine("Car started and ready to drive.");
    }

    static void Main()
    {
        Car myCar = new Car();
        myCar.Start();
    }
}
