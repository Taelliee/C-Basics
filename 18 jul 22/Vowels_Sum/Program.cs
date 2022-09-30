using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //a e i o u
            //1 2 3 4 5

            string word = Console.ReadLine();
            int n = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        n += 1;
                        break;
                    case 'e':
                        n += 2;
                        break;
                    case 'i':
                        n += 3;
                        break;
                    case 'o':
                        n += 4;
                        break;
                    case 'u':
                        n += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(n);
        }
    }
}
