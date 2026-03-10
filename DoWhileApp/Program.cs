namespace DoWhileApp
{
/// <summary>
/// Counts the number of digits of an integer
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numberOfDigits = 0;
            int tmp = 0;

            Console.WriteLine("Please insert an integer");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            tmp = num;
            
            do
            {
               tmp /= 10;
                numberOfDigits++;
            } while (tmp != 0);

            Console.WriteLine($"Digits count: {numberOfDigits}");
        }
    }
}
