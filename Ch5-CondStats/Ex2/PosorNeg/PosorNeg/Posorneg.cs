using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosorNeg
{
    class PosorNeg
    {
        /// <summary>
        /// 
        /// Program to check product of three numbers is positive or negative
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers with +/- sign");
            Console.Write("FirstNumber");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("SecondNumber");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ThirdNumber");
            int c = Convert.ToInt32(Console.ReadLine());

            // product is -ve if one or all three of the numbers are negative
            if ((a<0&&b<0&&c<0)||(a<0^b<0^c<0)) // using exclusive or
            {
                Console.WriteLine("The Number Product is negative");
            }
            else
            {
                Console.WriteLine("The Number Product is positive");
            }

            // biggest of three integers entered is 
            int max = 0;
            //max = a;
            //if(a>b)
            //{
            //    if (a > c)
            //    {
            //        max = a;
            //    }
            //    else
            //    {
            //        max = c;
            //    }
            //}
            //else
            //{
            //    if (b > c)
            //    {
            //        max = b;
            //    }
            //    else
            //    {
            //        max = c;
            //    }

            //}

            max = a>b ? a : b;
            max = max > c ? max : c;
            
            Console.WriteLine($"max of three numbers entered is {max}");

            //Sort hree numbers 
            int temp = 0;
            if(a<b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            if(b<c)
            {
                temp = b;
                b = c;
                c = temp;
                if(a<b)
                {
                    temp = b;
                    b = a;
                    a = temp;
                }
            }
            Console.WriteLine($"The sorted order is {a} {b} {c}");

            Console.WriteLine("Enter anything");
            string str = Console.ReadLine();
            double d = 0;
            if (double.TryParse(str,out d))
            {
                Console.WriteLine($"The Entered number Plus one is {d + 1}");

            }
            {
                Console.WriteLine($"The String Entered * is {str + "*"}");
            }
             //   Convert.ToInt64(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
