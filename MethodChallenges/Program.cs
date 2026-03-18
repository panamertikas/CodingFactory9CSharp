using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        //checks if the number is even or odd

        public static string CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        // calculates the max between two numbers

        public static int Max(int a, int b)

        {
           // return a > b ? a : b;
           return Math.Max(a, b);
            
        }

        // Calculates the area of a circle
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Calculates Celsius to Fahrenheit

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Returns repeated string n times

        public static string RepeatString(string str, int n)
        {
            StringBuilder sb = new();

            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            


            return sb.ToString();
        


        }

        // Creates a random pin of 4 digits     

        public static string GeneratePin()
        {
            Random random = new();
            //int pin = random.Next(1000, 10000); // Generates a number between 1000 and 9999
            //return pin.ToString();

            return random.Next(1000, 10000).ToString(); // Generates a number between 1000 and 9999
        }

        // Filtering even numbers from an array

        public static int[] FilterEvenNumbers(int[] numbers)
        {
            // return numbers.Where(n => n % 2 == 0).ToArray();

            return [.. numbers.Where(n => n % 2 == 0)]; // spread operator in C# 12


        }

        // Bubble sort algorithm to sort an array of integers


        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]); // tuple swap 
                    }
                }
            }
        }

        // Binary search for an int in a sorted array

        public static int BinarySearch(int[] arr, int val)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int med = (left + right) / 2;
            }



    }
}
