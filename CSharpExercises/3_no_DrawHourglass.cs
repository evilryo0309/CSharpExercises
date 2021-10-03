using System;

namespace CSharpExercises
{
    class DrawHourglassTask
    {

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

        //static void Main(string[] args)
        //{
        //    DrawHourglass();
        //}
    }
}