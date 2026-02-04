using System.Data;

namespace basicodes1
{
    public class countintegers
    {
        public static void countnumbers()
        {
            Console.WriteLine("Enter the number");

            int n=Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
                int digit = n / 10;
                Console.WriteLine(digit);
                n = n / 10;


            }


        }
    }
}
