using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1л=1дм на 3та
            double lengthCM = double.Parse(Console.ReadLine());
            double widthCM = double.Parse(Console.ReadLine());
            double heightCM = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = lengthCM * widthCM * heightCM; //cm3
            volume *= 0.001; //dm3
            volume -= volume * percent*0.01;
            Console.WriteLine(volume);
        }
    }
}
