using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //сума = депозирана сума + срок на депозита *
            //((депозирана сума * годишен лихвен процент ) / 12)
            double depsum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double sum = depsum + months * ((depsum * interest / 100) / 12);
            Console.WriteLine(sum);
        }
    }
}
