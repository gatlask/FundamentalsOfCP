using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOps
{
    /// <summary>
    /// Program Exploring the bitwise Operations
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 11 Print the bit in the pth position of n
            //number given n
            int n = 35; // 00100011 
            //position p
            int p = 2;
            // taking 1 to create a mask
            int i = 1; // 00000001 
            // mask is moving p by 6 positions
            int mask = i << p; // Move the 1-st bit left by p positions 
                               // If i & mask are positive then the p-th bit of n is 1 

            //the number in bit is 
            Console.WriteLine($"{Convert.ToString(Convert.ToInt32(n), 2)}");
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

            //new  mask
            mask = i << (p + 1);
            Console.WriteLine((n & mask) != 0 ? 1 : 0);


            /*We are given the number n, the value v(v = 0 or 1) and the position p. write a sequence 
             * of operations that changes the value of n, so the bit on the position p has the value of v. 
             * Example: n = 35, p = 5, v = 0->n = 3.
             * Another example: n = 35, p = 2, v = 1->n = 39.
             * */
            n = n & (~(1 << p));
            Console.WriteLine($"{Convert.ToString(Convert.ToInt32(n), 2)}");
            Console.WriteLine(n);


            n = n | (1 << p);
            Console.WriteLine($"{Convert.ToString(Convert.ToInt32(n), 2)}");
            Console.WriteLine(n);

            Console.ReadKey();

        }
    }
}
