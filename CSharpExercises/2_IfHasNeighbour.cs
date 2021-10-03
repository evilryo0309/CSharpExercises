using System;

namespace CSharpExercises
{
    class IfHasNeighbourTask
    {
        public static bool IfHasNeighbour(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
        }

        // public static void Main()
        // {
        //     Console.WriteLine(IfHasNeighbour("DCA"));
        //     Console.WriteLine(IfHasNeighbour("PRT")); 
        //     判斷三個字中是不是有鄰居
        // }
    }
}