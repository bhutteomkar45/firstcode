using System;
using System.Collections.Generic;
using System.Text;

namespace patternprinting1
{
    public class hollowsqr
    {
        public static void hollosqrpy()
        {

            int rows = 10;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || j ==rows|| j==1 || i == rows)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
              
            