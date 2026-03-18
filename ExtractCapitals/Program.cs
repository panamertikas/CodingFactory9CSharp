using System.Text;

namespace ExtractCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World! This is a Test String with CAPITAL letters.";

            Console.WriteLine(ExtractCapitalsWithStringBuilder(str1));
        }

        // Extracts capital letters from the input string and returns them as a new string

        public static string ExtractCapitalsWithStringBuilder(string input)
        {
            StringBuilder capitals = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    capitals.Append(c);
                }
            }
            return capitals.ToString();
        }
    }
}
