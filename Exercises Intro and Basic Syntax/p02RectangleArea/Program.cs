

namespace p02RectangleArea
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = height * width;

            Console.WriteLine($"{area:F2}");
        }
    }
}
