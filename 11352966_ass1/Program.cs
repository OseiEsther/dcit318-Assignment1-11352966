using System;

class Program
{


    static void GradeCalculator()
    {
        Console.Write("Enter your numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            string letterGrade = grade >= 90 ? "A" :
                                 grade >= 80 ? "B" :
                                 grade >= 70 ? "C" :
                                 grade >= 60 ? "D" : "F";

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

}
