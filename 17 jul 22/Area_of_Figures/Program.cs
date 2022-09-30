using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //square, rectangle, circle или triangle
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (a * a));
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (a * b));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (r * r * Math.PI));
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", ((a * b)/2));
            }
        }
    }
}
