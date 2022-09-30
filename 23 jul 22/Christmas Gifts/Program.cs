using System;

namespace Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int countKids = 0;
            int countAdults = 0;

            while (input != "Christmas")
            {
                if (int.Parse(input) <= 16)
                {
                    if (int.Parse(input) != 0)
                    {
                        countKids++;
                    }
                }
                else
                {
                    countAdults++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {countAdults}");
            Console.WriteLine($"Number of kids: {countKids}");
            Console.WriteLine($"Money for toys: {countKids*5}");
            Console.WriteLine($"Money for sweaters: {countAdults*15}");
        }
    }
}
