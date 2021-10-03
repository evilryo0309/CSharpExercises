using System;

namespace CSharpExercises
{
    class TheBiggestNumberTask
    {
        static int TheBiggestNumber(int[] oldArr)
        {
            int max = oldArr[0];

            for (int i = 1; i < oldArr.Length; i++)
            {
                 if (max < oldArr[i])
                    {
                    max = oldArr[i];
                    }
            }

            return max;
        }

        // static void Main(string[] args)
        // {      
        //     Console.WriteLine(TheBiggestNumber(new int[] { 3,33,333,33333333 }));                   // 9
         
        // }
    }
}