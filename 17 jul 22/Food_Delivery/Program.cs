using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пилешко меню – 10.35 лв.
            //Меню с риба – 12.40 лв.
            //Вегетарианско меню – 8.15 лв.

            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double veggie = double.Parse(Console.ReadLine());
            chicken *= 10.35;
            fish *= 12.40;
            veggie *= 8.15;

            double food = chicken + fish + veggie;
            double dessert = 0.2 * food;
            Console.WriteLine(food + dessert + 2.50);
        }
    }
}
