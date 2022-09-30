using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string pieces = Console.ReadLine();
            int size = width * length;
            int numPieces = 0;

            while (size > 0)
            {
                if (pieces == "STOP")
                {
                    break;
                }
                else
                {
                    size -= int.Parse(pieces);
                    numPieces++;
                    pieces = Console.ReadLine();
                }
            }
            if (size > 0)
            {
                Console.WriteLine($"{numPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {size} pieces more.");
            }
        }
    }
}
