namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int END = 10;
            int sum = 0;
            int i = 1;

            while (i <= END)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Sum from 1 to {END} is: {sum}");
        }
    }
}
