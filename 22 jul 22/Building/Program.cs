using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string apOrOf;

            for (int a = floors; a > 0; a--)
            {
                if (a == floors)
                {
                    apOrOf = "L";
                }
                else if (a % 2 == 1)
                {
                    apOrOf = "A";
                }
                else
                {
                    apOrOf = "O";
                }

                for (int b = 0; b < rooms; b++)
                {
                    Console.Write($"{apOrOf}{a}{b} ");
                }
                Console.Write("\n");
            }
        }
    }
}
