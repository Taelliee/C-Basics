using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            //384 400 км
            //3 часа на Луната

            double averageSpeed = double.Parse(Console.ReadLine());
            double litersPer100 = double.Parse(Console.ReadLine());

            double timeToAndBack = (2 * 384400) / averageSpeed;
            Console.WriteLine(Math.Ceiling(timeToAndBack) + 3);
            Console.WriteLine(litersPer100 * 2 * 384400 / 100);
        }
    }
}
