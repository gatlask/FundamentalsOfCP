using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialUtil
{
    /// <summary>
    /// Program to calculate various factorial utilities
    /// </summary>
    class FactorialUtil
    {

        static void Main(string[] args)
        {
            // Calulate n!/k!;

            Console.WriteLine("Please enter the Value N to calculate n!/k!");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Value k");
            int k = Convert.ToInt32(Console.ReadLine());



    //        decimal d = Factorial(n) / Factorial(k);

         //   decimal d2 = Factorial(n) * Factorial(k) / Factorial(n - k);

    //        Console.WriteLine($"n!/k! is {d} and n!k!/(n-k)! {d2}");

            // for n the catalan number of n is 

            decimal cn = Factorial(2 * n) / (Factorial(n) * Factorial(n + 1));

            Console.WriteLine($"the Catalan number fo n is {cn}");


            decimal fs = FactorialSeries(n, k);

            Console.WriteLine($"the Factorial Series  number fo n is {fs}");

            Console.ReadKey();




        }

        private static decimal FactorialSeries(int n, int k)
        {
            decimal result = 0;

            for (int i=0;i < n; i++)
            {
                result += Factorial(i) / Convert.ToDecimal(Math.Pow(k, i));

                Console.WriteLine($"n is {i} and k is {k} result {result}");
            }
            

            return result;
        }

        private static decimal Factorial(int n)
        {
            decimal result = 1;

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
