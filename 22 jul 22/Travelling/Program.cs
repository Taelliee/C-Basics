using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool i = false;

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    string price = Console.ReadLine();
                    if (price == "End")
                    {
                        i = true;
                        break;
                    }
                    budget -= double.Parse(price);
                }
                if (i)
                {
                    break;
                }
                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
            }
        }
    }
}
