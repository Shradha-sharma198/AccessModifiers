using System;
using StudentLibrary;

class ResearchStudent : Student
{
    public void ShowData()
    {
        Console.WriteLine("Access Through Inheritance");
        Console.WriteLine("--------------------------");
        // public
        Console.WriteLine("Name       : " + Name);
        // protected
        Console.WriteLine("Department : " + Department);
        // protected internal
        Console.WriteLine("College    : " + College);
    }

    static void Main()
    {
        ResearchStudent r = new ResearchStudent();

        r.ShowData();
        Console.WriteLine();
        Console.WriteLine("Access Through Student Object");
        Console.WriteLine("-----------------------------");

        Student s = new Student();
        Console.WriteLine("Name : " + s.Name);
        Console.ReadLine();
    }
}