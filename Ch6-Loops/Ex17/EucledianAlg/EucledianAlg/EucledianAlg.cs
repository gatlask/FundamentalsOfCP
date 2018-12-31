using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EucledianAlg
{
    class EucledianAlg
    {
        static void Main(string[] args)
        {

            // functions to get GCD and LCM  for two given numbers
            decimal a = 1071, b = 462;
            decimal gcd = GreatestCommmonDivisor(a, b);
            decimal lcm = LeastCommonMultiple(a, b);

            Console.WriteLine(gcd +" "+ lcm);
            Console.ReadKey();

        }

        private static decimal LeastCommonMultiple(decimal a, decimal b)
        {
            decimal num1, num2;                         //taking input from user by using num1 and num2 variables
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;

        }

        private static decimal GreatestCommmonDivisor(decimal a, decimal b)
        {

            if (b == 0)
            {
                return a;
            }
            else
            {
                return GreatestCommmonDivisor(b, a % b);
            }

        }
    }
}
