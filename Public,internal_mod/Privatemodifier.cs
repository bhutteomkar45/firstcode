using System;
using System.Collections.Generic;
using System.Text;

namespace Public_mod
{
    public class Car
    {

        public required string model;
        public required string Colour;
        public int Price;



        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Price:" + Price);
        }
    }
    internal class Car2
    {
        public required string model;
        public required string Colour;
        public int Price;


        public void PrintCarInformation2()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Price:" + Price);
        }
    }
}
