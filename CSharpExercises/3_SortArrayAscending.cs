using System;

namespace CSharpExercises
{
    class SortArrayAscendingTask
    {      
        static int[] SortArrayAscending(int[] arr)
        {
            int sortarray;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        sortarray = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = sortarray;
                    }
                }
            }

            return arr;
        }

        // static void Main(string[] args)
        // {
        //     int[] sortedArr = SortArrayAscending(new int[] { 2,1,9,4,6});

        //     foreach (var s in sortedArr)
        //     {
        //         Console.Write($"{s} "); 
        //         // 小到大
        //         // foreach 陳述式提供了一個簡單且清楚的方法來逐一查看陣列中的元素。
        //     }
        // }
    }
}