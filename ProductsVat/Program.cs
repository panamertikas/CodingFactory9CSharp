namespace ProductsVat
{
    /// <summary>
    /// Reads a price without VAT from the console/user, calculates the price with VAT using a constant VAT rate of 24%,
    /// and prints the result, formatted to 2 decimal places. The program also includes input validation to ensure that the price entered is a valid non-negative number.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double VAT_RATE = 0.24D;

            double priceWithoutVat = 0D;
            double priceWithVat = 0D;
            double finalPrice = 0D;
            double productsVat = 0D;

            Console.WriteLine("Παρακαλώ εισάγετε τιμή:");
            
            if (!double.TryParse(Console.ReadLine(), out priceWithoutVat) || priceWithoutVat < 0)
            {
                Console.WriteLine("Μη αποδεκτή τιμή.");
                return;
            }

            priceWithVat = priceWithoutVat * VAT_RATE;
            finalPrice = priceWithoutVat + priceWithVat;
            productsVat = priceWithoutVat * VAT_RATE;

            Console.WriteLine($"{"Τιμή χωρίς ΦΠΑ:"} {priceWithoutVat,-15:N2}");
            Console.WriteLine($"{"ΦΠΑ:"} {productsVat,-15:N2}");
            Console.WriteLine($"{"Τιμή με ΦΠΑ:"} {finalPrice,-15:N2}");

        }
    }
}
