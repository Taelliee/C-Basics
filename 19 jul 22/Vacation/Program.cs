using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int countSpend = 0;

            while (availableMoney < holidayMoney)
            {
                string spendOrSave = Console.ReadLine();
                double sumSpendOrSave = double.Parse(Console.ReadLine());
                countDays++;
                if (spendOrSave == "spend")
                { 
                    countSpend++;
                    availableMoney -= sumSpendOrSave;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else
                {
                    availableMoney += sumSpendOrSave;
                    countSpend = 0;
                } 
                if (countSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countDays);
                    break;
                }
            }
            if (availableMoney >= holidayMoney)
            Console.WriteLine($"You saved the money for {countDays} days.");
        }
    }
}
