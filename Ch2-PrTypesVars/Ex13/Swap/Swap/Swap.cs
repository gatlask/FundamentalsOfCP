using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    /// <summary>
    /// Program for swapping integers
    /// </summary>
    class Swap
    {
        static void Main(string[] args)
        {
            int a = 5, b = 15;

            Console.WriteLine($"the Numbers before Swapping a:{a}  and b:{b}");

            int c = a;a = b; b = c;

            Console.WriteLine($"the Numbers after Swapping a:{a}  and b:{b}");

            Console.ReadKey();


        }
    }
}
