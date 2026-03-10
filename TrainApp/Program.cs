namespace TrainApp
{
    /// <summary>
    /// Reads distance (km) and average speed (km/h) from the user, calculates the travel time in hours and minutes,
    /// and the cost of the ticket before and after applying a 20% discount, and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double COST_PER_KM = 0.12D;
            const double DISCOUNT = 0.20D;
            const double MINUTES_PER_HOUR = 60D;


            double averageSpeed = 0D;
            double distance = 0D;
            double travelTimeInHours = 0D;
            double travelTimeInMinutes = 0D;
            double costBeforeDiscount = 0D;
            double discountAmount = 0D;
            double finalCost = 0D;

            Console.WriteLine("Παρακαλώ εισάγετε απόσταση σε χλμ.");
            if(!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
                {
                    Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                    return;
            }
            Console.WriteLine("Παρακαλώ εισάγετε μέση ταχύτητα σε χλμ/ώρα.");
            if(!double.TryParse(Console.ReadLine(), out averageSpeed) || averageSpeed <= 0)
            {
                Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                return;
            }

            travelTimeInHours = distance / averageSpeed;
            travelTimeInMinutes = travelTimeInHours * MINUTES_PER_HOUR;
            costBeforeDiscount = Math.Round(distance * COST_PER_KM, 2);
            discountAmount = Math.Round(costBeforeDiscount * DISCOUNT, 2);
            finalCost = Math.Round(costBeforeDiscount - discountAmount, 2);

            Console.WriteLine($"{"Χρόνος ταξιδίου σε ώρες:", -40}{travelTimeInHours:N2}");
            Console.WriteLine($"{"Χρόνος ταξιδίου σε λεπτά:", -40}{travelTimeInMinutes:N2}");
            Console.WriteLine($"{"Κόστος εισιτηρίου πρό έκπτωσης:", -40}{costBeforeDiscount:N2}");
            Console.WriteLine($"{"Ποσό έκπτωσης:", -40}{discountAmount:N2}");
            Console.WriteLine($"{"Τελική τιμή εισιτηρίου:", -40}{finalCost:N2}");

        }
    }
}
