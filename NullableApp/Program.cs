namespace NullableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine(); // possible null value

            if ( s != null) Console.WriteLine(s.Length);

            Console.WriteLine(s?.Length);       // null-conditional operator
            Console.WriteLine(s!.Length);       // null-forgiving operator (unsafe, use with caution)
            Console.WriteLine(s ?? "default");  // null-coalescing operator



        }
    }
}
