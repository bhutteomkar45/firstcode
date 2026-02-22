using System;
using System.Collections.Generic;
using System.Text;

namespace patternprinting1
{
    public class revhfpyrmd
    {
        public static void rgthfpyrmd()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 10 - i; k > 0; k--)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
