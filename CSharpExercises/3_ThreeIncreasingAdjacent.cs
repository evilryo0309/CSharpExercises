using System;

namespace CSharpExercises
{
    class ThreeIncreasingAdjacentTask
    {
        static bool ThreeIncreasingAdjacent(int[] arr)
        {
            bool diff1 = false;
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
                {
                    fdiff1 = true;
                }
            }

            return diff1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));                
          Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 3,9,7,3}));    

            // 給定一個數字數組，編寫一個方法來檢查是否有三個相鄰的數字，其中第二個比第一個大 1，第三個比第二個大 1。
        }
    }
}