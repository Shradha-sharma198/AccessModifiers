using System;

class GraduateStudent : Student
{
    public void ShowData()
    {
        Console.WriteLine("Access through inheritance:");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("CGPA       : " + CGPA);
        Console.WriteLine("College    : " + College);
        Console.WriteLine("Address    : " + Address);
    }

    static void Main()
    {
        GraduateStudent gs = new GraduateStudent();

        gs.ShowData();

        Console.WriteLine();
        Console.WriteLine("Access through Student object:");
        Console.WriteLine("--------------------------------");

        Student s = new Student();

        Console.WriteLine("Name       : " + s.Name);
        Console.WriteLine("CGPA       : " + s.CGPA);
        Console.WriteLine("College    : " + s.College);

        Console.ReadLine();
    }
}