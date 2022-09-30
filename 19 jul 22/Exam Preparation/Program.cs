using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int countBadgrades = 0;
            string nameExercise = "";
            double gradeSum = 0;
            int countGrades = 0;
            while (nameExercise != "Enough")
            {
                nameExercise = Console.ReadLine();
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                countGrades++;
                if (grade <= 4)
                {
                    countBadgrades++;
                }
                if (countBadgrades == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }
            }
            double average = gradeSum / countGrades;
            Console.WriteLine($"Average score: {average}");
            Console.WriteLine($"Number of problems: {countGrades}");
            Console.WriteLine($"Last problem: {nameExercise}");
        }
    }
}
