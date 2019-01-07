using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            do
            {
                Console.WriteLine("Enter First Variable :");

            } while (!Int32.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.WriteLine("Enter Second Variable :");

            } while (!Int32.TryParse(Console.ReadLine(), out y));

            Helper.Swap(ref x, ref y);
            Console.WriteLine("First Variable Value : {0}",x);
            Console.WriteLine("Second Variable Value : {0}",y);
            Console.ReadKey(); 
        }
    }
}
