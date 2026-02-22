using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace patternprinting1
{
    public class rhombpatt
    {

        public static void revrhombpatt()
        {
            int rows = 10;

            for (int i = rows; i >= 1; i--)
            {
                for (int k = 1; k <= rows - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
