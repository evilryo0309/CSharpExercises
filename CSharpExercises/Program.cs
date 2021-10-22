using System;

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/divisible-by-2-or-3
/// 兩個可以被2和3整除的整數,可整除的兩數相乘,不行就相加
/// </summary>
static int DivisibleBy2Or3(int a, int b)
{
    return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
}

Console.WriteLine(DivisibleBy2Or3(1, 1));
Console.WriteLine(DivisibleBy2Or3(15, 20));
Console.WriteLine("");

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-consists-of-uppercase-letters
/// 判斷三個字中是不是都大寫
/// 沒有更快的方法嗎？
/// </summary>
static bool IfConsistsOfUppercaseLetters(string str)
{
    return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
}

Console.WriteLine(IfConsistsOfUppercaseLetters("drY")); // False 
Console.WriteLine(IfConsistsOfUppercaseLetters("LOL")); // True
Console.WriteLine(IfConsistsOfUppercaseLetters("N0t")); // False
Console.WriteLine(IfConsistsOfUppercaseLetters("$1r")); // False

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-greater-than-third-one
/// 設三個整數,前面兩個相加要大於第三個且前面兩個相乘也要大於第三個
/// </summary>
static bool IfGreaterThanThirdOne(int[] arr)
{
    return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
}

Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));
Console.WriteLine(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-has-neighbour
/// 判斷三個字中是不是有鄰居
/// </summary>
static bool IfHasNeighbour(string word)
{
    return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
}

Console.WriteLine(IfHasNeighbour("DCA"));
Console.WriteLine(IfHasNeighbour("PRT"));

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine(IfNumberContains3(333));

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-number-is-even
/// 判斷是不是偶數
/// </summary>
static bool IfNumberIsEven(int num)
{
    return num % 2 == 0;
}

Console.WriteLine(IfNumberIsEven(8));
Console.WriteLine(IfNumberIsEven(54749));
Console.WriteLine(IfNumberIsEven(0));

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-sorted-ascending
/// 判斷三個數字是不是由小到大
/// </summary>
static bool IfSortedAscending(int[] arr)
{
    return arr[0] <= arr[1] && arr[1] <= arr[2];
}

Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 }));
Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 }));
Console.WriteLine(IfSortedAscending(new int[] { -50, -24, -1 }));

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/conditional-statements/exercise/if-year-is-leap
/// 規年是啥＾＾ => 同學，是閏(ㄋㄨㄣˋ)年，每四年會有一次 2/29。
/// </summary>
static bool IfYearIsLeap(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}

Console.WriteLine(IfYearIsLeap(2020));
Console.WriteLine(IfYearIsLeap(1719));

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
Console.WriteLine(PositiveNegativeOrZero(-200.003)); // Negative

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/loops/exercise/fractions-sum
/// 這題我不懂 
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

Console.WriteLine(FractionsSum(2));  // 1.25
Console.WriteLine(FractionsSum(7));  // 1.5117970521542
Console.WriteLine(FractionsSum(10)); // 1.54976773116654

Console.WriteLine("*******************************************************************************");

/// <summary>
/// https://csharpexercises.com/loops/exercise/return-even-numbers
/// </summary>
static string ReturnEvenNumbers()
{
    string str = string.Empty;
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            str += i + ",";
        }
    }

    return str;
}

Console.WriteLine(ReturnEvenNumbers());

Console.WriteLine("*******************************************************************************");

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

int[] sortedArr = SortArrayAscending(new int[] { 2, 1, 9, 4, 6 });

foreach (var s in sortedArr)
{
    Console.Write($"{s} ");
    // 小到大
    // foreach 陳述式提供了一個簡單且清楚的方法來逐一查看陣列中的元素。
}

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine(TheBiggestNumber(new int[] { 3, 33, 333, 33333333 }));                   // 9

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));
Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 3, 9, 7, 3 }));

Console.WriteLine("*******************************************************************************");

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

Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));
Console.WriteLine(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));
Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));

Console.WriteLine("*******************************************************************************");