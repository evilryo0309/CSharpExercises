using System;

namespace CSharpExercises
{
    class IfGreaterThanThirdOneTask
    {
        static bool IfGreaterThanThirdOne(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));
        //    Console.WriteLine(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));
        //    //設三個整數,前面兩個相加要大於第三個且前面兩個相乘也要大於第三個
             
        // }
    }
}