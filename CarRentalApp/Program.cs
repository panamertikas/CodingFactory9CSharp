namespace CarRentalApp
{
    /// <summary>
    /// Reads the number of rental days and kilometers driven from the user,
    /// calculates the total cost before VAT, the VAT amount, and the total cost after applying a 24% VAT rate,
    /// and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_PER_DAY = 25D;
            const double PRICE_PER_KM = 0.15D;
            const double VAT_RATE = 0.24D;
            double rentalDays = 0D;
            double kilometersDriven = 0D;
            double totalCostBeforeVat = 0D;

            double vat = 0D;
            double finalCost = 0D;



            Console.WriteLine("Παρακαλώ εισάγετε ημέρες ενοικίασης:");
            
            if (!double.TryParse(Console.ReadLine(), out rentalDays) || rentalDays <= 0) {

                Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                return;
            }

            Console.WriteLine("Παρακαλώ εισάγετε τα χιλιόμετρα που έγιναν:");

            if (!double.TryParse(Console.ReadLine(), out kilometersDriven) || kilometersDriven < 0)
            {
                Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                return;
            }

            totalCostBeforeVat = Math.Round(rentalDays * PRICE_PER_DAY + kilometersDriven * PRICE_PER_KM, 2);

            vat = Math.Round(totalCostBeforeVat * VAT_RATE, 2);

            finalCost = Math.Round(totalCostBeforeVat + vat, 2);

            Console.WriteLine($"{"Κόστος προ ΦΠΑ :",-20}{totalCostBeforeVat:N2}");
            Console.WriteLine($"{"ΦΠΑ :",-20}{vat:N2}");
            Console.WriteLine($"{"Συνολικό κόστος:",-20}{finalCost:N2}");

        }
    }
}
