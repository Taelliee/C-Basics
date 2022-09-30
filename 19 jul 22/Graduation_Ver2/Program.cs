using System;

namespace Graduation_Ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 0;
            int countBad = 0;
            double gradeSum = 0;
            double average = 0;

            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    countBad += 1;
                    if (countBad > 1) break;
                }
                count += 1;
                gradeSum += grade;
                average = gradeSum / count;
            }
            if (average < 4 || countBad > 1)
                Console.WriteLine($"{name} has been excluded at {count} grade");
            else
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");

        }
    }
}
