using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FracSum
{
    /// <summary>
    /// Program to calculate sum of a given series
    /// 
    /// </summary>
    class FracSum
    {
        static void Main(string[] args)
        {
            // 
            decimal precision = 0.001m;

            decimal oldsum=1, newsum=1;
            int i = 0;
            i++;i++;
            do
            {
                oldsum = newsum;
                newsum = oldsum + (1.0m*(int)Math.Pow(-1,i))/i;
                i++;
                //Console.WriteLine($"{newsum}");                              
            }
            while (Math.Abs((newsum - oldsum)) > precision);

            Console.WriteLine($"the Sum with precision {precision} is {newsum} and {i}");
            Console.ReadKey();
        }
    }
}
