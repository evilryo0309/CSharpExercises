using System;

namespace CSharpExercises
{
    class Program
    {
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine(IfConsistsOfUppercaseLetters("drY")); // False 
        //     Console.WriteLine(IfConsistsOfUppercaseLetters("LOL")); // True
        //     Console.WriteLine(IfConsistsOfUppercaseLetters("N0t")); // False
        //     Console.WriteLine(IfConsistsOfUppercaseLetters("$1r")); // False
        //      判斷三個字中是不是都大寫
        //     //沒有更快的方法嗎？
        // }
    }
}