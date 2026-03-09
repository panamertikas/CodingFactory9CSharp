namespace NumberRead
{
    /// <summary>
    /// Safe reading of float and double numbers from the console using TryParse method.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatNum = 0F;
            double doubleNum = 0D;

            Console.WriteLine("Εισάγετε δύο δεκαδικούς : ");

            if (!float.TryParse(Console.ReadLine(), out floatNum))
            {
                Console.WriteLine("Δεν είναι έγκυρος αριθμός τύπου float.");
                return;
            }
          

            if (!double.TryParse(Console.ReadLine(), out doubleNum))
            {
                Console.WriteLine("Δεν είναι έγκυρος αριθμός τύπου double.");
                return;
            }

            //Console.WriteLine($"float = {floatNum, -6:N2}");
            //Console.WriteLine($"double = {doubleNum, -10:N3}");

            Console.WriteLine($"float = {floatNum,-10:N2}\t double = {doubleNum,-10:N2}");
        }
    }
}
