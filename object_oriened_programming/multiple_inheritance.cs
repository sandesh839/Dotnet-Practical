using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy weeps");
    }

    static void Main()
    {
        Puppy p = new Puppy();
        p.Eat();
        p.Bark();
        p.Weep();
    }
}
