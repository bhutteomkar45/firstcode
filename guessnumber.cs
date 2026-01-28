using System;
using System.Collections.Generic;
using System.Text;

namespace basicodes1
{
    public class guessnumber
    {
        public static void findno()
        {
            Random rnd = new Random();
            int on = rnd.Next(1, 101);
            int un = 0;

            while (true)
            {
                Console.WriteLine("Guess the right number !");
                un = Convert.ToInt32(Console.ReadLine());
                if (un == on)
                {
                    Console.WriteLine("You guessed the right number !");
                    break;
                }
                else if (un < on)
                {
                    Console.WriteLine("you guess it to low");
                }
                else
                {
                    Console.WriteLine("you guessed it to high");
                }
            }
        }       
    }
}
