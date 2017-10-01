

namespace p03MilesToKilometers
{
    using System;

   public class Program
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = 1.60934 * miles;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
