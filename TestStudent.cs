
using System;

class TestStudent
{
    static void Main()
    {
        Student s = new Student();

        Console.WriteLine("Student Details");
  
        Console.WriteLine("Name    : " + s.Name);
        Console.WriteLine("CGPA    : " + s.CGPA);
        Console.WriteLine("College : " + s.College);

        Console.ReadLine();
    }
}