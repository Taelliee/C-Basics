using System;

namespace Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int peoplePerGroup = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            //    Март - Май/Юни - Август
            //Ден 10.50 лв/ч 12.60 лв/ч
            //Нощ 8.40 лв/ч  10.20 лв/ч
            double pricePerDay = 0;
            double pricePerNight = 0;
            double pricePerPerson;
            double pricePerHour;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    pricePerDay = 10.50;
                    pricePerNight = 8.40;
                    break;
                case "june":
                case "july":
                case "august":
                    pricePerDay = 12.60;
                    pricePerNight = 10.20;
                    break;
                default:
                    break;
            }
            if (timeOfDay == "day")
            {
                pricePerHour = pricePerDay;
            }
            else
            {
                pricePerHour = pricePerNight;
            }
            if (peoplePerGroup >= 4)
            {
                pricePerHour -= 0.1 * pricePerHour;
            }
            if (hoursSpent >= 5)
            {
                pricePerHour -= 0.5 * pricePerHour;
            }
            pricePerPerson = pricePerHour * hoursSpent;
            
            Console.WriteLine($"Price per person for one hour: {pricePerHour:F2}");
            Console.WriteLine($"Total cost of the visit: {(pricePerPerson*peoplePerGroup):F2}");
        }
    }
}
