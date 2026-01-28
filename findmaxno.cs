using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class findmaxno
    {
        public static void Maxin3()
        {
            
            Console.WriteLine("Find biggest no in 3 !");
            Console.WriteLine("WRITE FIRST NUMBER:");
           int  a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("WRITE SECOND NUMBER:");
           int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("WRITE THIRD NUMBER:");
           int c=Convert.ToInt32(Console.ReadLine());

            int max = a;
           
            if(max< b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("greater number is:" + max);

        }
    }
}
