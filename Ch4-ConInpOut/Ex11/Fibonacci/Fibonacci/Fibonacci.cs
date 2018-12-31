using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    /// <summary>
    /// Program to print out Fibonacci digits for the requested Lenght, or max number
    /// </summary>
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number fibonacci numbers to print");
            int num = Convert.ToInt32(Console.ReadLine());

            // this program prints out the sequence of fibonacci numbers

            double fiba=1, fibb=1, fibc;


            if (num == 0)
            {
                Console.WriteLine("there are no numbers entered");
                return;
            }

            Console.Write($"the Series is {fiba}");
            if (num == 1) return;
            Console.Write($" {fibb}");
            if (num==2) return;

            for (int i = 2; i < num; i++)
            {
                fibc = fiba + fibb;
                Console.Write($" {fibc}");
                fiba = fibb; fibb = fibc; 
            }

            Console.ReadKey();
        }
    }
}
