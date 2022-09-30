using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //до 10 (включително) отпечатайте "slow"
            //над 10 и до 50(включително) отпечатайте "average"
            //над 50 и до 150(включително) отпечатайте "fast"
            //над 150 и до 1000(включително) отпечатайте "ultra fast"
            //по-висока скорост отпечатайте "extremely fast"

            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (10 < speed && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (50 < speed && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (150 < speed && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
