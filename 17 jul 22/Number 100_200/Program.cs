using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Less than 100"
            //"Between 100 and 200"
            //"Greater than 200"
            int a = int.Parse(Console.ReadLine());
            if (a < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (a > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
