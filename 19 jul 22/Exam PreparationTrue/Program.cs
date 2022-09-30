using System;

namespace Exam_PreparationTrue
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
            string lastExercise = "";

            while (badGrades > countBadgrades)
            {
                nameExercise = Console.ReadLine();
                if (nameExercise == "Enough")
                {
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                countGrades++;
                if (grade <= 4)
                {
                    countBadgrades++;
                }
                lastExercise = nameExercise;
            }
            double average = gradeSum / countGrades;
            if (nameExercise == "Enough")
            {
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {countGrades}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
        }
    }
}
