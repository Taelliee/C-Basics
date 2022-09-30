using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //градус = радиан * 180 / π.
            //Math.PI
            double rad = double.Parse(Console.ReadLine());
            double degrees = (rad * 180) / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
