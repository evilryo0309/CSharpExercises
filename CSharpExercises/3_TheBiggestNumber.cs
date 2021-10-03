using System;

namespace CSharpExercises.Exercises.Loops
{
    class TheBiggestNumberTask
    {
        static int TheBiggestNumber(int[] numArr)
        {
            
int[] intArray = { 10, 99, 15, 2, 58, 28, 94 };
           int intMax = intArray[0];
        int intMin = intArray[0];

        for (int ii = 0; ii < intArray.Length; ii++)
        {
            if (intMax < intArray[ii])
            {
                intMax = intArray[ii];
            }

            if (intMin > intArray[ii])
            {
                intMin = intArray[ii];
            }
        }        static void Main(string[] args)
        {      
            Console.WriteLine(TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));                   // 9
            Console.WriteLine(TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));       // -7
            Console.WriteLine(TheBiggestNumber(new int[] { 1009, 998, 1090, 3000, 2934, 4888 }));  // 4888
        }
    }
}