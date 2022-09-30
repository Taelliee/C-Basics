using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int count = 0;
            bool i = false;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    count++;
                    if (a + b == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({a} + {b} = {magic})");
                        i = true;
                        break;
                    }
                }
                if (i)
                {
                    break;
                }
            }
            if (i == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
