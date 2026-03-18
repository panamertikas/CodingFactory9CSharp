namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool IsPalindrome(string? input)
        {


            if (input == null) return false;
            
            for ( int i = 0, j = input.Length -1; i< j; i++ , j-- ) 
            {
                if (input[i] != input[j]) return false;
                

            }
            return true;
        }
    }
}
