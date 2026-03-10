namespace IfCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string name = "John";
            string nickname = "Johnny";

            if (age > 18)
            {
                Console.WriteLine("Adult");
            } 
            else
            {
                Console.WriteLine("No adult");
            }

            var status = age > 18 ? "Adult" : "No adult";
            Console.WriteLine(status);

            var displayName = name?? "No name";

            var length = name?.Length ?? 0;
            Console.WriteLine(length);
        }
}
