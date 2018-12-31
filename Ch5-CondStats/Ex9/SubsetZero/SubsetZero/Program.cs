using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetZero
{
    class Program
    {
        /// <summary>
        /// Find subset of a given set whose sum is zero
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Get the set of values
            Console.WriteLine("please enter the number of digits you want to enter");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Please Enter number {i + 1} :");
                //arr[i] = Convert.ToInt32(Console.ReadLine()); // trying to get a valid number
                while (!(int.TryParse(Console.ReadLine(), out arr[i])))
                {
                    Console.WriteLine("Please enter a valid number !!");
                }
            }

            for(int i=0;i<arr.Length;i++)
            {

            }
        }
    }
}