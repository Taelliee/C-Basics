using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string input = Console.ReadLine();
            int count = 0;

            while (favouriteBook != input && input != "No More Books")
            {
                input = Console.ReadLine();
                count++;
            }

            if (favouriteBook == input)
                Console.WriteLine($"You checked {count} books and found it.");
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
