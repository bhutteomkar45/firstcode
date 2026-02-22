using System.Xml.Schema;

namespace Accessmodifier
{
     class Car
    {

        string model;
        string Colour;
        int Price;

        void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Colour" + Colour);
            Console.WriteLine("Price" + Price);
        }
  
        
        static void Main(string[] args)
        {
            Console.WriteLine("We are in private Access Modifier!");
            Car myCar = new Car();
            myCar.model = "Farrari";
            myCar.Colour = "Velwet";
            myCar.Price = 30000000;
            myCar.PrintCarInformation();

        }
    }
}
