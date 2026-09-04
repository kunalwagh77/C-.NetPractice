
using System;

class Program
{
    public static void Main(string[] args)
    {
        // Original String
        string text = "  Hello Kunal Wagh  ";

        Console.WriteLine("Original String: " + text);

        // --------------------------------------------------
        // 1. Length
        // String me total characters count karta hai
        // --------------------------------------------------
        Console.WriteLine("\n1. Length:");
        Console.WriteLine(text.Length);


        // --------------------------------------------------
        // 2. ToUpper()
        // String ko UPPERCASE me convert karta hai
        // --------------------------------------------------
        Console.WriteLine("\n2. ToUpper:");
        Console.WriteLine(text.ToUpper());


        // --------------------------------------------------
        // 3. ToLower()
        // String ko lowercase me convert karta hai
        // --------------------------------------------------
        Console.WriteLine("\n3. ToLower:");
        Console.WriteLine(text.ToLower());


        // --------------------------------------------------
        // 4. Trim()
        // Starting aur ending ke extra spaces remove karta hai
        // --------------------------------------------------
        string trimmedText = text.Trim();

        Console.WriteLine("\n4. Trim:");
        Console.WriteLine(trimmedText);


        // --------------------------------------------------
        // 5. TrimStart()
        // Sirf starting spaces remove karta hai
        // --------------------------------------------------
        Console.WriteLine("\n5. TrimStart:");
        Console.WriteLine(text.TrimStart());


        // --------------------------------------------------
        // 6. TrimEnd()
        // Sirf ending spaces remove karta hai
        // --------------------------------------------------
        Console.WriteLine("\n6. TrimEnd:");
        Console.WriteLine(text.TrimEnd());


        // --------------------------------------------------
        // 7. Contains()
        // Check karta hai particular word string me present hai ya nahi
        // Result True ya False deta hai
        // --------------------------------------------------
        Console.WriteLine("\n7. Contains:");
        Console.WriteLine(trimmedText.Contains("Kunal"));


        // --------------------------------------------------
        // 8. StartsWith()
        // Check karta hai string kis word se start hoti hai
        // --------------------------------------------------
        Console.WriteLine("\n8. StartsWith:");
        Console.WriteLine(trimmedText.StartsWith("Hello"));


        // --------------------------------------------------
        // 9. EndsWith()
        // Check karta hai string kis word se end hoti hai
        // --------------------------------------------------
        Console.WriteLine("\n9. EndsWith:");
        Console.WriteLine(trimmedText.EndsWith("Wagh"));


        // --------------------------------------------------
        // 10. Replace()
        // Ek word ya character ko dusre word se replace karta hai
        // --------------------------------------------------
        Console.WriteLine("\n10. Replace:");
        Console.WriteLine(trimmedText.Replace("Kunal", "Developer"));


        // --------------------------------------------------
        // 11. IndexOf()
        // Word ya character ka first index find karta hai
        // --------------------------------------------------
        Console.WriteLine("\n11. IndexOf:");
        Console.WriteLine(trimmedText.IndexOf("Kunal"));


        // --------------------------------------------------
        // 12. LastIndexOf()
        // Last occurrence ka index find karta hai
        // --------------------------------------------------
        string repeatText = "Hello Hello Kunal";

        Console.WriteLine("\n12. LastIndexOf:");
        Console.WriteLine(repeatText.LastIndexOf("Hello"));


        // --------------------------------------------------
        // 13. Substring()
        // String ka particular part extract karta hai
        // --------------------------------------------------
        Console.WriteLine("\n13. Substring:");

        // Index 6 se last tak print karega
        Console.WriteLine(trimmedText.Substring(6));

        // Index 0 se 5 characters print karega
        Console.WriteLine(trimmedText.Substring(0, 5));


        // --------------------------------------------------
        // 14. Insert()
        // Particular index par new text insert karta hai
        // --------------------------------------------------
        Console.WriteLine("\n14. Insert:");
        Console.WriteLine(trimmedText.Insert(6, "Mr. "));


        // --------------------------------------------------
        // 15. Remove()
        // String ka particular part remove karta hai
        // --------------------------------------------------
        Console.WriteLine("\n15. Remove:");
        Console.WriteLine(trimmedText.Remove(5));


        // --------------------------------------------------
        // 16. Equals()
        // Do strings equal hain ya nahi check karta hai
        // --------------------------------------------------
        string name1 = "Kunal";
        string name2 = "Kunal";

        Console.WriteLine("\n16. Equals:");
        Console.WriteLine(name1.Equals(name2));


        // --------------------------------------------------
        // 17. Compare()
        // Do strings ko compare karta hai
        // 0 = Equal
        // Negative = First string smaller
        // Positive = First string greater
        // --------------------------------------------------
        Console.WriteLine("\n17. Compare:");
        Console.WriteLine(string.Compare("Apple", "Banana"));


        // --------------------------------------------------
        // 18. Concat()
        // Do ya multiple strings ko join karta hai
        // --------------------------------------------------
        Console.WriteLine("\n18. Concat:");

        string firstName = "Kunal";
        string lastName = "Wagh";

        Console.WriteLine(string.Concat(firstName, " ", lastName));


        // --------------------------------------------------
        // 19. String Concatenation (+)
        // + operator se strings join kar sakte hain
        // --------------------------------------------------
        Console.WriteLine("\n19. Concatenation:");

        Console.WriteLine(firstName + " " + lastName);


        // --------------------------------------------------
        // 20. String Interpolation ($)
        // Variables ko directly string ke andar use kar sakte hain
        // --------------------------------------------------
        Console.WriteLine("\n20. String Interpolation:");

        int age = 22;

        Console.WriteLine($"My name is {firstName} and my age is {age}");


        // --------------------------------------------------
        // 21. Split()
        // String ko multiple parts/array me divide karta hai
        // --------------------------------------------------
        Console.WriteLine("\n21. Split:");

        string data = "Kunal,Rahul,Amit";

        string[] names = data.Split(',');

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        // --------------------------------------------------
        // 22. Join()
        // Array ke elements ko ek single string me join karta hai
        // --------------------------------------------------
        Console.WriteLine("\n22. Join:");

        string[] cities = { "Akola", "Pune", "Mumbai" };

        Console.WriteLine(string.Join(" - ", cities));


        // --------------------------------------------------
        // 23. Character Access using Index
        // String ke particular character ko access karte hain
        // --------------------------------------------------
        Console.WriteLine("\n23. Character Access:");

        Console.WriteLine("First Character: " + trimmedText[0]);

        Console.WriteLine("Last Character: " +
            trimmedText[trimmedText.Length - 1]);


        // --------------------------------------------------
        // 24. String Reverse
        // Last character se first character tak loop chalayenge
        // --------------------------------------------------
        Console.WriteLine("\n24. String Reverse:");

        string word = "Kunal";
        string reverse = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reverse = reverse + word[i];
        }

        Console.WriteLine("Original: " + word);
        Console.WriteLine("Reverse: " + reverse);


        // --------------------------------------------------
        // 25. Palindrome Check
        // Original aur reverse string same hai ya nahi check karte hain
        // --------------------------------------------------
        Console.WriteLine("\n25. Palindrome Check:");

        string palindrome = "madam";
        string reversedPalindrome = "";

        for (int i = palindrome.Length - 1; i >= 0; i--)
        {
            reversedPalindrome += palindrome[i];
        }

        if (palindrome == reversedPalindrome)
        {
            Console.WriteLine("Palindrome String");
        }
        else
        {
            Console.WriteLine("Not Palindrome String");
        }


        // --------------------------------------------------
        // 26. Count Vowels
        // a, e, i, o, u kitne hain count karte hain
        // --------------------------------------------------
        Console.WriteLine("\n26. Count Vowels:");

        string vowelText = "Hello Kunal";
        int vowelCount = 0;

        for (int i = 0; i < vowelText.Length; i++)
        {
            char ch = char.ToLower(vowelText[i]);

            if (ch == 'a' || ch == 'e' ||
                ch == 'i' || ch == 'o' ||
                ch == 'u')
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Total Vowels: " + vowelCount);


        // --------------------------------------------------
        // 27. Count Words
        // Space ke basis par string ko split karke words count karte hain
        // --------------------------------------------------
        Console.WriteLine("\n27. Count Words:");

        string sentence = "I am learning C Sharp";

        string[] words = sentence.Split(' ');

        Console.WriteLine("Total Words: " + words.Length);


        Console.WriteLine("\n----- String Methods Completed -----");
    }
}

