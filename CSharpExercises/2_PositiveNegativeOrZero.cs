using System;

namespace CSharpExercises
{
    class PositiveNegativeOrZeroTask
    {
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "正數";
            }
            else if (num < 0.0)
            {
                return "負數";
            }

            return "零";
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
        //     Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
        //     Console.WriteLine(PositiveNegativeOrZero(-200.003)); // Negative
        // 檢查是正數還是負數還是零
        
        // }
    }
}