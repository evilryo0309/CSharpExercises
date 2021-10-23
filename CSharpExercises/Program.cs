using System;
using System.Diagnostics;
using System.Linq;

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/divisible-by-2-or-3
/// 兩個可以被2和3整除的整數,可整除的兩數相乘,不行就相加
/// </summary>
static int DivisibleBy2Or3(int a, int b)
{
    return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
}
Debug.Assert(DivisibleBy2Or3(1, 1) == 2);
Debug.Assert(DivisibleBy2Or3(15, 20) == 35);

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-consists-of-uppercase-letters
/// 判斷三個字中是不是都大寫
/// 沒有更快的方法嗎？
/// </summary>
static bool IfConsistsOfUppercaseLetters(string str)
{
    return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
}
Debug.Assert(IfConsistsOfUppercaseLetters("drY") == false); // False 
Debug.Assert(IfConsistsOfUppercaseLetters("LOL") == true); // True
Debug.Assert(IfConsistsOfUppercaseLetters("N0t") == false); // False
Debug.Assert(IfConsistsOfUppercaseLetters("$1r") == false); // False

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-greater-than-third-one
/// 設三個整數,前面兩個相加要大於第三個且前面兩個相乘也要大於第三個
/// </summary>
static bool IfGreaterThanThirdOne(int[] arr)
{
    return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
}
Debug.Assert(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }) == false);
Debug.Assert(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-has-neighbour
/// 判斷三個字中是不是有鄰居
/// </summary>
static bool IfHasNeighbour(string word)
{
    return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
}
Debug.Assert(IfHasNeighbour("DCA"));
Debug.Assert(IfHasNeighbour("PRT") == false);

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-number-contains-3
/// </summary>
static bool IfNumberContains3(int number)
{
    if (number > 0)
    {
        if (number % 10 == 3)
        {
            if (number % 10 == 3)
            {
                return true;
            }

            number /= 10;
        }
    }

    return false;
}
Debug.Assert(IfNumberContains3(333));

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-number-is-even
/// 判斷是不是偶數
/// </summary>
static bool IfNumberIsEven(int num)
{
    return num % 2 == 0;
}
Debug.Assert(IfNumberIsEven(8));
Debug.Assert(IfNumberIsEven(54749) == false);
Debug.Assert(IfNumberIsEven(0));

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-sorted-ascending
/// 判斷三個數字是不是由小到大
/// </summary>
static bool IfSortedAscending(int[] arr)
{
    return arr[0] <= arr[1] && arr[1] <= arr[2];
}
Debug.Assert(IfSortedAscending(new int[] { 3, 6, 9 }));
Debug.Assert(IfSortedAscending(new int[] { 34, 17, 90 }) == false);
Debug.Assert(IfSortedAscending(new int[] { -50, -24, -1 }));

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-year-is-leap
/// 規年是啥＾＾ => 同學，是閏(ㄋㄨㄣˋ)年，每四年會有一次 2/29。
/// </summary>
static bool IfYearIsLeap(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}
Debug.Assert(IfYearIsLeap(2020));
Debug.Assert(IfYearIsLeap(1719) == false);

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/positive,-negative-or-zero
/// 檢查是正數還是負數還是零
/// </summary>
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
Debug.Assert(PositiveNegativeOrZero(3.14) == "正數"); // Positive
Debug.Assert(PositiveNegativeOrZero(0.0) == "零"); // Zero
Debug.Assert(PositiveNegativeOrZero(-200.003) == "負數"); // Negative

/// <summary>
/// https://csharpexercises.com/loops/exercise/multiplication-table
/// 10 x 10 乘法表
/// </summary>
static void MultiplicationTable()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            if (i == 1)
            {
                if (i * j < 10)
                {
                    Console.Write($" {i * j} ");
                }
                else
                {
                    Console.Write($"{i * j} ");
                }
            }
            else if (i > 1 && i < 10)
            {
                if (i * j < 10)
                {
                    Console.Write($" {i * j} ");
                }
                else
                {
                    Console.Write($"{i * j} ");
                }
            }
            else
            {
                Console.Write($"{i * j} ");
            }
        }
        Console.WriteLine();
    }
}
MultiplicationTable();

/// <summary>
/// https://csharpexercises.com/loops/exercise/draw-christmas-tree
/// </summary>
static void DrawChristmasTree()
{
    for (var i = 0; i < 3; i++)
    {
        for (var j = 0; j < 7; j += 2)
        {
            for (var k = 0; k < (7 - j) / 2; k++)
            {
                Console.Write(" ");
            }
            for (var m = 0; m <= j; m++)
            {
                Console.Write("*");
            }
            for (var n = (7 - j) / 2; n < 7; n++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
DrawChristmasTree();

/// <summary>
/// https://csharpexercises.com/loops/exercise/draw-hourglass
/// </summary>
static void DrawHourglass()
{
    for (var i = 0; i <= 10; i++)
    {
        for (var j = 0; j < (i <= 5 ? i : 10 - i); j++)
        {
            Console.Write(" ");
        }
        for (var k = i <= 5 ? i : 10 - i; k <= (i <= 5 ? 10 - i : i); k++)
        {
            Console.Write("*");
        }
        for (var m = 10 - i; m < 10; m++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
DrawHourglass();

/// <summary>
/// https://csharpexercises.com/loops/exercise/draw-parallelogram
/// </summary>
static void DrawParallelogram()
{
    for (var j = 0; j < 5; j++)
    {
        for (var k = 0; k < 5 - j; k++)
        {
            Console.Write(" ");
        }
        for (var m = 0; m < 15; m++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
DrawParallelogram();

/// <summary>
/// https://csharpexercises.com/loops/exercise/fractions-sum
/// 這題我不懂 => 要問啊!!
/// </summary>
static double FractionsSum(int num)
{
    double sum = 0.0;
    for (int i = 1; i <= num; i++)
    {
        sum += (1 / (double)(i * i));
    }

    return sum;
}
Debug.Assert(FractionsSum(2) == 1.25f);
Debug.Assert(FractionsSum(7) == 1.511797052154195d);
Debug.Assert(FractionsSum(10) == 1.5497677311665408d);

/// <summary>
/// https://csharpexercises.com/loops/exercise/return-even-numbers
/// </summary>
static string ReturnEvenNumbers()
{
    string str = string.Empty;
    for (int i = 1; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            str += i + ",";
        }
    }

    return str;
}
Debug.Assert(ReturnEvenNumbers() == "2,4,6,8,10,");

/// <summary>
/// https://csharpexercises.com/loops/exercise/sort-array-ascending
/// </summary>
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
//int[] sortedArr = SortArrayAscending(new int[] { 2, 1, 9, 4, 6 });
//foreach (var s in sortedArr)
//{
//    Console.Write($"{s} ");
//    // 小到大
//    // foreach 陳述式提供了一個簡單且清楚的方法來逐一查看陣列中的元素。
//}
Debug.Assert(SortArrayAscending(new int[] { 2, 1, 9, 4, 6 }).SequenceEqual(new int[] { 1, 2, 4, 6, 9 }));

/// <summary>
/// https://csharpexercises.com/loops/exercise/the-biggest-number
/// </summary>
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
Debug.Assert(TheBiggestNumber(new int[] { 3, 33, 333, 33333333 }) == 33333333);

/// <summary>
/// https://csharpexercises.com/loops/exercise/three-increasing-adjacent
/// 給定一個數字數組，編寫一個方法來檢查是否有三個相鄰的數字，其中第二個比第一個大 1，第三個比第二個大 1。
/// </summary>
static bool ThreeIncreasingAdjacent(int[] arr)
{
    bool diff1 = false;
    for (int i = 1; i <= arr.Length - 2; i++)
    {
        if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
        {
            diff1 = true;
        }
    }

    return diff1;
}
Debug.Assert(ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));
Debug.Assert(ThreeIncreasingAdjacent(new int[] { 3, 9, 7, 3 }) == false);

/// <summary>
/// https://csharpexercises.com/loops/exercise/two-7s-next-to-each-other
/// 兩個 7 彼此相鄰的次數
/// </summary>
static int Two7sNextToEachOther(int[] arr)
{
    int frequency7 = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == 7 && arr[i + 1] == 7)
        {
            frequency7++;
        }
    }

    return frequency7;
}
Debug.Assert(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }) == 1);
Debug.Assert(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }) == 0);
Debug.Assert(Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }) == 3);
