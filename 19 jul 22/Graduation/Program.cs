using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double average = 0;
            double gradeSum = 0;
            int count = 0;

            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                count += 1;
                gradeSum += grade;
                average = gradeSum / count;
                
                if (average < 4.00)
                {
                    break;
                }
            }
            if (average < 4.00)
                Console.WriteLine($"{name} has been excluded at {count} grade");
            else
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
