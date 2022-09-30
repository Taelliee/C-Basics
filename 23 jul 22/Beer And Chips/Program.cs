using System;

namespace Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beer = int.Parse(Console.ReadLine());
            int crisps = int.Parse(Console.ReadLine());

            double priceBeers = beer * 1.20;
            double priceCrisps = priceBeers * 0.45 * crisps;
            budget -= priceBeers + Math.Ceiling(priceCrisps);
            
            if (budget >= 0)
            {
                Console.WriteLine($"{name} bought a snack and has {budget:F2} leva left.");
            }
            else
            {
                budget = Math.Abs(budget);
                Console.WriteLine($"{name} needs {budget:F2} more leva!");
            }
        }
    }
}
