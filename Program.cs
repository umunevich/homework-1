using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price of one copybook: ");
            double PriceCb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of them: ");
            int NumCb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of one pen: ");
            double PriceP = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of them: ");
            int NumP = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Total: {PriceCb*NumCb + PriceP*NumP}");
            Console.ReadKey(false);
        }
    }
}
