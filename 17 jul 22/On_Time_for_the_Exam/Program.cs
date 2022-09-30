using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hArrival = int.Parse(Console.ReadLine());
            int mArrival = int.Parse(Console.ReadLine());
            int allExam = mExam + hExam * 60;
            int allArrival = mArrival + hArrival * 60;
            int minutes = 0;
            int hours = 0;

            if (allExam == allArrival || allArrival < allExam && allExam - allArrival <= 30)
            {
                int temp = allExam - allArrival;
                minutes = temp % 60;
                Console.WriteLine($"On time {minutes} minutes before the start");
                
            }
            else if (allArrival < allExam && allExam-allArrival > 30)
            {
                Console.WriteLine("Early");
                int temp = allExam - allArrival;
                hours = temp / 60 ;
                minutes = temp % 60;
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");

                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");

                    }
                }

            }
            else if (allArrival > allExam)
            {
                Console.WriteLine("Late");
                int temp = allArrival - allExam;
                hours = temp / 60;
                minutes = temp % 60;
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");

                    }
                }
            }
            
        }
    }
}
