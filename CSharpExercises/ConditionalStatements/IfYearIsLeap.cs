using System;

namespace CSharpExercises
{
    class IfYearIsLeapTask
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine(IfYearIsLeap(2020)); 
        //     Console.WriteLine(IfYearIsLeap(1719)); 
        //      規年是啥＾＾
        // }
    }
}