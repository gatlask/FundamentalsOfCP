using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAccuracy
{
    /// <summary>
    /// Program to compare accuracy between two variables
    /// </summary>
    class ReadAccuracy
    {
        static void Main(string[] args)
        {
            float a = 0f;// 0.000001f;
            float b = 1.0f;

            for(int i = 0; i < 1000000; i++)
            {
                a += 0.000001f;
            }
            //need more clarification

            bool acc = Math.Abs(a - b) < 0.000001;

            Console.WriteLine("The Accuracy of two real number is less than 0.000001: {0}", acc);
            Console.WriteLine($"Value of a {a} and value of b is {b}");
            Console.ReadKey();

        }
    }
}
