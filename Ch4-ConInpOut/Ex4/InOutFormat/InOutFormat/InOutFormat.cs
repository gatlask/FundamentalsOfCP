using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutFormat
{
    /// <summary>
    /// Program to Print out a formatted output
    /// </summary>
    class InOutFormat
    {
        static void Main(string[] args)
        {
            /* Write a program that prints three numbers in three virtual columns on the console.
             * Each column should have a width of 10 characters and the numbers should be left aligned.
             * The first number should be an integer in hexadecimal; the second should be fractional positive; 
             * and the third – a negative fraction.The last two numbers have to be rounded to the second decimal place.
             * */
            int i = 0;
            float ft = 0.0f, ft2 = 0.0f;

            i = 2345;
            ft = 23.45678f;
            ft2 = -345.4512f;

            Console.WriteLine("|{0,10}|{0,10}|{0,10}|"," ");
            Console.WriteLine("Right Aligned");
            Console.WriteLine("|{0,10:##########}|{1,10:0.00}|{2,10:0.00}|", i, ft, ft2);
            Console.WriteLine("|{0,10}|{0,10}|{0,10}|", " ");
            Console.WriteLine("Left Aligned");
            Console.WriteLine("|{0,-10:##########}|{1,-10:0.00}|{2,-10:0.00}|", i, ft, ft2);
            Console.WriteLine("|{0,10}|{0,10}|{0,10}|", " ");
            Console.ReadKey();



        }
    }
}
