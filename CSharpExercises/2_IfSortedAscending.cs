using System;

namespace CSharpExercises
{
    class IfSortedAscendingTask
    {
        static bool IfSortedAscending(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 })); 
        //     Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 })); 
        //     Console.WriteLine(IfSortedAscending(new int[] { -50, -24, -1 })); 
        //      判斷三個數字是不是由小到大
        // }
    }
}