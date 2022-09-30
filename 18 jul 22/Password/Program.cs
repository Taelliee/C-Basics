using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password1 = Console.ReadLine();
            string password2 = Console.ReadLine();
            while (password1 != password2)
            {
                password2 = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
