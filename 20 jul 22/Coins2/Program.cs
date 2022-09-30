using System;

namespace Coins2
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int count = 0;
            while (change > 0)
            {
                if (change % 2 == change - 2)
                {
                    count++;
                    change -= 2;
                }
                else if (change % 1 == change - 1)
                {
                    change -= 1;
                    count++;
                }
                else if (change % 0.5 == change - 0.5)
                {
                    change -= 0.5;
                    change = Math.Round(change, 2);
                    count++;
                }
                else if (change % 0.2 == change - 0.2)
                {
                    change -= 0.2;
                    change = Math.Round(change, 2);
                    count++;
                }
                else if (change % 0.1 == change - 0.1)
                {
                    change -= 0.1;
                    change = Math.Round(change, 2);
                    count++;
                }
                else if (change % 0.05 == change - 0.05)
                {
                    change -= 0.05;
                    change = Math.Round(change, 2);
                    count++;
                }
                else if (change % 0.02 == change - 0.02)
                {
                    change -= 0.02;
                    change = Math.Round(change, 2);
                    count++;
                }
                else if (change % 0.01 == change - 0.01)
                {
                    change -= 0.01;
                    change = Math.Round(change, 2);
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}

