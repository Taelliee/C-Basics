using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
        //Баскетболни кецове – 40% по-малка от таксата за една годинa
        //Баскетболен екип – 20 % по - евтина от тази на кецовете
        //Баскетболна топка –  1 / 4 от цената на баскетболния екип
        //Баскетболни аксесоари –  1 / 5 от цената на баскетболната топка

            double taxPerYear = double.Parse(Console.ReadLine());
            double sneakers = taxPerYear - (0.4 * taxPerYear);
            double kit = sneakers - (0.2 * sneakers);
            double ball = 0.25 * kit;
            double accessories = 0.2 * ball;
            double taxEquipment = sneakers + kit + ball + accessories;
            Console.WriteLine(taxPerYear+taxEquipment);
        }
    }
}
