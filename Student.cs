using System;

class Student
{
    public string Name = "Shradha";

    private int Age = 22;

    protected string Department = "MCA";

    internal double CGPA = 8.5;

    protected internal string College = "GLA University";

    private protected string Address = "Mathura";

    public void Display()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("CGPA       : " + CGPA);
        Console.WriteLine("College    : " + College);
        Console.WriteLine("Address    : " + Address);
    }

    static void Main()
    {
        Student s = new Student();

        s.Display();

        Console.ReadLine();
    }
}