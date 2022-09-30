using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 24; a++)
            {
                for (int b = 0; b < 60; b++)
                {
                    Console.WriteLine($"{a}:{b}");
                }
            }
        }
    }
}
