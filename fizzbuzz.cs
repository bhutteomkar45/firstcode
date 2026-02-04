using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class fizzbuzz
    {
        public static void fizzprog()
        {
            int i = 1;

            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
           