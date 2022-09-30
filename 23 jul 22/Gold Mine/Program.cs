using System;

namespace Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLocations = int.Parse(Console.ReadLine());
            double expectedAvgGoldPerDay;
            double goldPerDay;
            int numDays;
            double sum = 0;

            while (numLocations > 0)
            {
                expectedAvgGoldPerDay = double.Parse(Console.ReadLine());
                numDays = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numDays; i++)
                {
                    goldPerDay = double.Parse(Console.ReadLine());
                    sum += goldPerDay;
                }
                if (expectedAvgGoldPerDay <= sum / numDays)

                {
                    Console.WriteLine($"Good job! Average gold per day: {(sum / numDays):F2}.");
                    sum = 0;
                }
                else
                {
                    Console.WriteLine($"You need {(expectedAvgGoldPerDay - sum / numDays):F2} gold.");
                    sum = 0;
                }
                numLocations--;
            }
        }
    }
}
