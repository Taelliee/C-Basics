using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numdog = double.Parse(Console.ReadLine());
            int numcat = int.Parse(Console.ReadLine());
            numdog *= 2.5;
            numcat *= 4;
            double price = numdog + numcat;
            Console.WriteLine($"{ price} lv.");
        }
    }
}
