using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double quadmeters = double.Parse(Console.ReadLine());
            double price = 7.61 * quadmeters;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
