
using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //"room for one person" – 18.00 лв за нощувка
            //"apartment" – 25.00 лв за нощувка
            //"president apartment" – 35.00 лв за нощувка
            //11 дни = 10 нощувки

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();
            int pricePerRoom = 0;
            double price = 0;
            double discountPrice;
            double finalPrice = 0;
            int nights = days - 1;
            double discount = 0;


            if (room == "room for one person")
            {
                pricePerRoom = 18;
                price = pricePerRoom * nights;
                if (review == "positive")
                {
                    finalPrice = price + price * 0.25;
                }
                else if (review == "negative")
                {
                    finalPrice = price - price * 0.1;
                }
            }
            else if (room == "apartment")
            {
                pricePerRoom = 25;
                if (days < 10)
                {
                    price = nights * pricePerRoom;
                    discount = 0.3 * price;
                    discountPrice = price - discount;
                }
                else if (days > 15)
                {
                    price = nights * pricePerRoom;
                    discount = 0.5 * price;
                    discountPrice = price - discount;
                }
                else
                {
                    price = nights * pricePerRoom;
                    discount = 0.35 * price;
                    discountPrice = price - discount;
                }
                if (review == "positive")
                {
                    finalPrice = discountPrice + 0.25 * discountPrice;
                }
                else if (review == "negative")
                {
                    finalPrice = discountPrice - 0.1 * discountPrice;
                }
            }
            else if (room == "president apartment")
            {
                pricePerRoom = 35;
                if (days < 10)
                {
                    price = nights * pricePerRoom;
                    discount = 0.1 * price;
                    discountPrice = price - discount;
                }
                else if (days > 15)
                {
                    price = nights * pricePerRoom;
                    discount = 0.2 * price;
                    discountPrice = price - discount;
                }
                else
                {
                    price = nights * pricePerRoom;
                    discount = 0.15 * price;
                    discountPrice = price - discount;
                }
                if (review == "positive")
                {
                    finalPrice = discountPrice + 0.25 * discountPrice;
                }
                else if (review == "negative")
                {
                    finalPrice = discountPrice - 0.1 * discountPrice;
                }
            }
            Console.WriteLine("{0:F2}", finalPrice);
        }   
    }
}
