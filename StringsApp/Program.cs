namespace StringsApp
{

    /// <summary>
    /// Strings are immutable and are interned by the .NET runtime,
    /// meaning identical string literals are stored only once in memory. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = "hello";
            string? str2 = "hello";
            string? str3 = new string("hello");

            Console.WriteLine(str1[0]); // 'h' - indexing

            // String equality

            Console.WriteLine(str1 == str2);        // True
            Console.WriteLine(str1.Equals(str2));   // True

            //Reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2)); // true (string interning)
            Console.WriteLine(object.ReferenceEquals(str1, str3)); // false (str3 is a new object)

            // Compare Strings

            Console.WriteLine(string.Compare(str1, str3)); // 0 (equal)
            Console.WriteLine(str1.CompareTo(str2));       // 0 (equal)
            int resultEqualsIgnoreCase = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase); // 0 (equal, ignoring case)

            // Concat

            string? result = str1 + " " + str2;                      // Concatenation using + operator
            string? result2 = string.Concat(str1, " ", str2);          // Concatenation using string.Concat method

            //to upper/lower
            
            string? upper = str1.ToUpper(); // "HELLO"
            string? lower = str2.ToUpper(); // "hello"

            Console.WriteLine(str1.ToUpper() == str2.ToUpper() ); // Normalized comparison ignoring case, returns true

            //Substring

            string? sub = str1.Substring(0, 2); // "he" starts at index 0 and has length 2
            string part = str2.Substring(2); // "llo" starts at index 2 and goes to the end of the string

            // indexOf , lastIndexOf

            int index = str1.IndexOf('l'); // 2 (first occurrence of 'l')
            int lastIndex = str1.LastIndexOf('he'); // 0 

            // Trim
            
            string? padded = "  hello  ";
            string? trimmed = padded.Trim(); // "hello" removes leading and trailing whitespace

        }
    }
}
