using System;

namespace CSharpExercises
{
    class Divisible
    {
        static int DivisibleBy2Or3(int a, int b)
        {
            return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(DivisibleBy2Or3(1, 1));
        //    Console.WriteLine(DivisibleBy2Or3(15, 20));
        //    //兩個可以被2和3整除的整數,可整除的兩數相乘,不行就相加

        //}
    }
}