using System;

namespace CSharpExercises
{
    class FractionsSumTask
    {
        // 這題我不懂
        static double FractionsSum(int num)
        {
            double sum = 0.0;
            for (int i = 1; i <= num; i++)
            {
                sum += (1 / (double)(i * i));
            }

            return sum;
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine(FractionsSum(2));  // 1.25
        //     Console.WriteLine(FractionsSum(7));  // 1.5117970521542
        //     Console.WriteLine(FractionsSum(10)); // 1.54976773116654
        // }
    }
}