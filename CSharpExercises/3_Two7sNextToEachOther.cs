using System;

namespace CSharpExercises.Exercises.Loops
{
    class Two7sNextToEachOtherTask
    {
        static int Two7sNextToEachOther(int[] arr)
        {
            int frequency7 = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    frequency7++;
                }
            }

            return frequency7;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));           // 1
            Console.WriteLine(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));           // 0      
            Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));  // 3
            //兩個 7 彼此相鄰的次數
        }
    }
}