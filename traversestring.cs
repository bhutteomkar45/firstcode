using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class traversestring
    {
        public static void travstr()
        { 
            string a= Console.ReadLine();
            string b = "";
            
            for (int j = a.Length - 1;j>=0; j--)
            {
                
                b = b + a[j];
            }
            if (b == a)
            {
                Console.WriteLine("given string is palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not palindrome");
            }
            Console.ReadLine();
        }
           
    }
}
