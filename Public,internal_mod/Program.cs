namespace Public_mod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# We are in private Access Modifier!\n");
            Car myCar = new Car
            {
                model = "Farrari",
                Colour = "Velwet",
                Price = 30000000
            };
            myCar.PrintCarInformation();

            Console.WriteLine("\n\n# We are in Internal Access Modifier!\n");
            Car2 myCar2 = new Car2
            {
                model = "BMW",
                Colour = "maroon",
                Price = 2000000
            };
            myCar2.PrintCarInformation2();

        }
    }
}
