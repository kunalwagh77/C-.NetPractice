using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // StringBuilder object create
        StringBuilder studentInfo = new StringBuilder();

        // Student information add kar rahe hain
        studentInfo.AppendLine("----- STUDENT INFORMATION -----");

        studentInfo.AppendLine("Name: Kunal Wagh");
        studentInfo.AppendLine("Course: MCA");
        studentInfo.AppendLine("Technology: .NET");

        studentInfo.AppendLine("-------------------------------");

        // Complete information print
        Console.WriteLine(studentInfo);
    }
}