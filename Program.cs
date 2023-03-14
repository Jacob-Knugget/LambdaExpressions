using System;
using System.Runtime.ExceptionServices;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = (double x, double y) => x + y;
            var product = (double x, double y) => x * y;
            var smallerValue = (double x, double y) => { if (x < y) { return x; } else { return y; } };
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your first number:");
                    double first = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    double second = double.Parse(Console.ReadLine());

                    Console.WriteLine($"The sum is: {sum(first, second)}");
                    Console.WriteLine($"The product is: {product(first, second)}");
                    Console.WriteLine($"The smaller value is: {smallerValue(first, second)}");
                }
                catch
                {
                    Console.WriteLine("Please enter a valid response.");
                }
            }
        }
    }
}