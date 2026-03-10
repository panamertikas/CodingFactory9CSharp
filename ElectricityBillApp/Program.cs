namespace ElectricityBillApp
{
    /// <summary>
    /// Reads the electricity consumption in kWh from the user,
    /// calculates the total cost before VAT, the VAT amount,
    /// and the total cost after applying a 24% VAT rate, and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_PER_KWH = 0.18D;
            const double FIXED_CHARGE = 5D;
            const double APE_PER_KWH = 0.02D;
            const double VAT_RATE = 0.24D;

            double kWhConsumed =0D;
           
            double totalCostBeforeVat = 0D;
            double totalCostAfterVat = 0D;
            double vatValue = 0D;   

            Console.WriteLine("Παρακαλώ εισάγετε κατανάλωση σε kWh :");

            if(!double.TryParse(Console.ReadLine(), out kWhConsumed) || kWhConsumed < 0)
            {
                Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                return;
            }


            totalCostBeforeVat = Math.Round(FIXED_CHARGE + (kWhConsumed * PRICE_PER_KWH) + (kWhConsumed * APE_PER_KWH), 2);
            vatValue = Math.Round(totalCostBeforeVat * VAT_RATE, 2);
            totalCostAfterVat =Math.Round(totalCostBeforeVat + vatValue,2);


            Console.WriteLine($"{"Κόστος πρό ΦΠΑ:",-20}{totalCostBeforeVat:N2}");
            Console.WriteLine($"{"ΦΠΑ 24%:",-20}{vatValue:N2}");
            Console.WriteLine($"{"Συνολικό κόστος:",-20}{totalCostAfterVat:N2}");

        }
    }
}
