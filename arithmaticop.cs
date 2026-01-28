using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class arithmaticop
    {
        public static void Mathprob()
        {
            int a;
            int b;

            Console.WriteLine("Write a number for Arithmatic operation");
            Console.WriteLine("Write no.for a:");
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write no.for b:");
            b = Convert.ToInt32(Console.ReadLine());
          
            int c = a + b;
            Console.WriteLine("Addition is: "+c);

            int d = a - b;
            Console.WriteLine("Substraction is: "+d);

            int e = a * b;
            Console.WriteLine("Multiplication is: "+e);

            int f = a / b;
            Console.WriteLine("Division is: "+f);

            int g = a % b;
            Console.WriteLine("Mod is: "+g);
        }
    }
}
