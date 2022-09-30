using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пакет химикали - 5.80 лв.
            //Пакет маркери -7.20 лв.
            //Препарат - 1.20 лв(за литър)

            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double detergent = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());
            pens *= 5.80;
            markers *= 7.20;
            detergent *= 1.20;
            discountPercent *= 0.01;
            double price = pens + markers + detergent;
            Console.WriteLine(price - (price * discountPercent));
        }
    }
}
