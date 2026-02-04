using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class reverseint
    {
        public static void reversenum()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
        }
    }
}
