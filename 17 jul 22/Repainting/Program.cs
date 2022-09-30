using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предпазен найлон - 1.50 лв.за кв. метър
            //Боя - 14.50 лв.за литър
            //Разредител за боя - 5.00 лв.за литър

            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            nylon *= 1.50;
            nylon += 3.40;
            paint *= 14.50;
            paint += 0.1 * paint;
            thinner *= 5;
            double materials = (nylon + paint + thinner);
            double payment = (0.3 * materials) * hours;
            Console.WriteLine(payment + materials);
        }
    }
}
