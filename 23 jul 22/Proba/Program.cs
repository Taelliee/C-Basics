using System;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double litersPer100 = double.Parse(Console.ReadLine());

            double timeToAndBack = (2 * 384400) / averageSpeed;
            Console.WriteLine(Math.Ceiling(timeToAndBack) + 3);
            Console.WriteLine(litersPer100 * 2 * 384400 / 100);
        }
    }
}
