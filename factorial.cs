using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class factorial
    {
        public static void factprod()
        {
            Console.WriteLine("Enter any number for factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact=1;
            while(n>1)
            {
                fact = n * fact;
                n = n - 1;
            }
         Console.WriteLine(fact);

        }
    }
}
