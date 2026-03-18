namespace MoreMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            result = Add(1, 2, 3);
            DateTime dateTime = GetDateTime(2024, 6, 1); // June 1, 2024
        }

        public static int Add(params int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static DateTime GetDateTime(int year = 1970, int month = 1, int day = 1 , int min = 0, int sec = 0, int ms = 0)
            {
                return new DateTime(year, month, day, min, sec, ms, DateTimeKind.Utc);
            }



        //Overloading methods : same method name but different parameters
        public static void SayHello(string message)
        {
            Console.WriteLine(message);
        
        }

        public static void SayHello()
        {
            Console.WriteLine("Coding");
        }

    }
}
