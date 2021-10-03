using System;

namespace CSharpExercises
{
    class ReturnEvenNumbersTask
    {
        static string ReturnEvenNumbers()
        {
            string str = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    str += i + ",";
                }
            }

            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumbers()); 
            
        }
    }
}