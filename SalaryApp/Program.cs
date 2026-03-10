namespace SalaryApp
{
    /// <summary>
    /// Reads a monthly salary from the user, calculates the daily wage, hourly wage, and wage per minute based on the assumptions of 22 working days per month, 8 working hours per day, and 60 minutes per hour,
    /// and prints the results formatted to 2 decimal places.
    /// The program also includes input validation to ensure that the salary entered is a valid non-negative number.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double DAYS_PER_MONTH = 22D;
            const double HOURS_PER_DAY = 8D;
            const double MINUTES_PER_HOUR = 60D;

            double monthlySalary = 0D;
            double hourlyWage = 0D;
            double dailyWage = 0D;
            double wagePerMinute = 0D;

            Console.WriteLine("Παρακαλώ εισάγετε μηνιαίο μισθό:");

            if (!double.TryParse(Console.ReadLine(), out monthlySalary) || monthlySalary < 0)
            {
                Console.WriteLine("Η τιμή που εισάγετε δεν είναι αποδεκτή.");
                return;
            }

            dailyWage = Math.Round(monthlySalary / DAYS_PER_MONTH, 2);
            hourlyWage = Math.Round(dailyWage / HOURS_PER_DAY, 2);
            wagePerMinute = Math.Round(hourlyWage / MINUTES_PER_HOUR, 2);

            Console.WriteLine($"{"Μηνιαίος μισθός:",-20}{monthlySalary:N2}");
            Console.WriteLine($"{"Ημερομίσθιο:", -20}{dailyWage:N2}");
            Console.WriteLine($"{"Ωρομίσθιo:", -20}{hourlyWage:N2}");
            Console.WriteLine($"{"Μισθός ανά λεπτό:", -20}{wagePerMinute:N2}");

        }
    }
}
