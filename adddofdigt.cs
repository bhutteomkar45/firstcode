using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class adddofdigt
    {
        public static void adddig2()
        {
            Console.WriteLine("Write number for a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write number for b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The answer is: "+c);
        }
    }
}
