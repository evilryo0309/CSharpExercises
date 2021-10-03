using System;

namespace CSharpExercises
{
    class IfNumberContains3task
    {
        public static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }


        public static void Main()
        {
            Console.WriteLine(IfNumberContains3(5384562)); // true
            
        }
    }
}