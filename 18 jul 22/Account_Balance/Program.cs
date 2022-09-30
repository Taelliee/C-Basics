using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double total = 0;
            double num;

            while (n != "NoMoreMoney")
            {
                num = double.Parse(n);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else if (num >= 0)
                {

                    Console.WriteLine($"Increase: {num:F2}"); //not "0:F2", num
                }
                total += num;
                n = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
