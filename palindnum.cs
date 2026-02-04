using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class palindnum
    {
        public static void palnumber()
        {
            int num = Convert.ToInt32(Console.ReadLine());   
            int rem;
            int result=0;
            int temp = num;

            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            num = temp;
            if (num == result)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palinfrome");
            }
            Console.ReadLine();

        }
    }
}
