namespace FormatExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter an integer(0 : Quit)");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"You entered the integer: {num}");
                    if (num == 0) break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }



        }
    }
}
