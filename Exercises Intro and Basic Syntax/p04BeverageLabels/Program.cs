

namespace p04BeverageLabels
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double totalEnergy = volume * energyContent / 100.0;
            double totalSugar = volume * sugarContent / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
