using System;

class Student
{
    public string Name;
    public int RollNo;
    public float Marks;

    public void AcceptData()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        RollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        Marks = float.Parse(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Marks: " + Marks);
    }

    static void Main()
    {
        Student s = new Student();
        s.AcceptData();
        s.DisplayData();
    }
}
