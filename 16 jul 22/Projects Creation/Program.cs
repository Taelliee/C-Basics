using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int hours = 3 * num;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {num} project/s.");
        }
    }
}
