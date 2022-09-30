using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //banana / apple / orange / grapefruit / kiwi / pineapple / grapes
            //Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        //2.50	1.20	0.85	1.45	2.70	5.50	3.85
                        case "banana":
                            Console.WriteLine("{0:F2}", quantity * 2.50);
                            break;
                        case "apple":
                            Console.WriteLine("{0:F2}", quantity * 1.20);
                            break;
                        case "orange":
                            Console.WriteLine("{0:F2}", quantity * 0.85);
                            break;
                        case "grapefruit":
                            Console.WriteLine("{0:F2}", quantity * 1.45);
                            break;
                        case "kiwi":
                            Console.WriteLine("{0:F2}", quantity * 2.70);
                            break;
                        case "pineapple":
                            Console.WriteLine("{0:F2}", quantity * 5.50);
                            break;
                        case "grapes":
                            Console.WriteLine("{0:F2}", quantity * 3.85);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        //2.70	1.25	0.90	1.60	3.00	5.60	4.20
                        case "banana":
                            Console.WriteLine("{0:F2}", quantity * 2.70);
                            break;
                        case "apple":
                            Console.WriteLine("{0:F2}", quantity * 1.25);
                            break;
                        case "orange":
                            Console.WriteLine("{0:F2}", quantity * 0.90);
                            break;
                        case "grapefruit":
                            Console.WriteLine("{0:F2}", quantity * 1.60);
                            break;
                        case "kiwi":
                            Console.WriteLine("{0:F2}", quantity * 3.00);
                            break;
                        case "pineapple":
                            Console.WriteLine("{0:F2}", quantity * 5.60);
                            break;
                        case "grapes":
                            Console.WriteLine("{0:F2}", quantity * 4.20);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
