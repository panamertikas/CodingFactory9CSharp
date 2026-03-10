namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}");
            SwapRef
        }

        /// <summary>
        /// Pass by value - does not swap the values of a and b in the caller method
        /// </summary>
        /// <param name="a">the first input</param>
        /// <param name="b">the second input</param>
        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        /// <summary>
        /// The original values of a and b are modified
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapRef(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static (int, int) SwapWithTuple(int a,  int b)
        {
            return (b, a);
        }
    }
}
