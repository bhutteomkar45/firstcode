using System;
using System.Collections.Generic;
using System.Text;

namespace patternprinting1
{
    public class numbpyrmd
    {
        public static void pattpyrmd()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);    
                }
                Console.WriteLine();
            }
        }
    }

}
