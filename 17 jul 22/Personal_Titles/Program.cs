using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Mr." – мъж (пол 'm') на 16 или повече години
            //"Master" – момче(пол 'm') под 16 години
            //"Ms." – жена(пол 'f') на 16 или повече години
            //"Miss" – момиче(пол 'f') под 16 години

            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (sex ==  "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (sex == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
