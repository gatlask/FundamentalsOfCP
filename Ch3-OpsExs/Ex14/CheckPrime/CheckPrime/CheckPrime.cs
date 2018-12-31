using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    /// <summary>
    /// this program checks if a given number is prime or not
    /// </summary>
    class CheckPrime
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please enter a starting and ending number to check for primes");
            Console.WriteLine("Enter the start number");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number > than start");
            int end = Convert.ToInt32(Console.ReadLine());
            //double num = Convert.ToInt64(Console.ReadLine());

            for (double num = start; num < end; num++)
            {
                bool numIsPrime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        numIsPrime = false;
                        break;
                    }
                }

                if (numIsPrime)
                {
                    Console.WriteLine($"The Number {num} is a prime number");
                }
            }

            Console.ReadKey();


        }
    }
}
