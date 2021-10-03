using System;

namespace CSharpExercises
{
    class DrawParallelogramTask
    {
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

        // static void Main(string[] args)
        // {
        //     DrawParallelogram();
        // }
    }
}