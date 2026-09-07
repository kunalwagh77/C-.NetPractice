using System;

class Student
{
    string name;
    int age;

    // Constructor
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        // Constructor call with user input
        Student s1 = new Student(name, age);

        s1.Display();
    }
}