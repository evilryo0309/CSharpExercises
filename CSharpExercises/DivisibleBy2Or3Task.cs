using System;

namespace CSharpExercises.Exercises.Conditional_statements
{
    class DivisibleBy2Or3Task
    {
        static int DivisibleBy2Or3(int a, int b)
        {
            return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(10, 20));
             Console.WriteLine(DivisibleBy2Or3(15, 20));
           
        }
    }
}