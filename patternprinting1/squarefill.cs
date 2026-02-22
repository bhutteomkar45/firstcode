using System;
using System.Collections.Generic;
using System.Text;

namespace patternprinting1
{
    public class squarefill
    {
        public static void squarepattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }

    }
}
