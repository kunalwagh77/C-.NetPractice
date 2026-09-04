using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // Create StringBuilder object
        StringBuilder sb = new StringBuilder("Hello");

        Console.WriteLine("Original: " + sb);


        // 1. Append()
        // String ke end me text add karta hai
        sb.Append(" Kunal");

        Console.WriteLine("Append: " + sb);


        // 2. AppendLine()
        // Text add karta hai with new line
        sb.AppendLine(" Welcome");

        Console.WriteLine("AppendLine:");
        Console.WriteLine(sb);


        // 3. Insert()
        // Particular index par text insert karta hai
        sb.Insert(6, "Mr. ");

        Console.WriteLine("Insert: " + sb);


        // 4. Remove()
        // Particular position se characters remove karta hai
        sb.Remove(0, 6);

        Console.WriteLine("Remove: " + sb);


        // 5. Replace()
        // Ek text ko dusre text se replace karta hai
        sb.Replace("Kunal", "Developer");

        Console.WriteLine("Replace: " + sb);


        // 6. Length
        // Total characters count karta hai
        Console.WriteLine("Length: " + sb.Length);


        // 7. Clear()
        // Complete StringBuilder empty karta hai
        sb.Clear();

        Console.WriteLine("After Clear: " + sb);
    }
}