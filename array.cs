using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class array
    {
        public static void revarray()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Original array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            
            int temp;
            int n = a.Length;
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
            Console.WriteLine("\nReversed array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.ReadLine();
        }
    }
}