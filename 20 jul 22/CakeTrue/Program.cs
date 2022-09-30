using System;

namespace CakeTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string pieces;
            int size = width * length;

            while (size > 0)
            {
                pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    break;
                }
                else
                {
                    size -= int.Parse(pieces);

                }
            }
            if (size > 0)
            {
                Console.WriteLine($"{size} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
            }
        }
    }
}
