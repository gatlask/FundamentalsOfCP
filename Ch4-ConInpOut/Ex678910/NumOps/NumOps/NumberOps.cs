using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumOps
{
    /// <summary>
    /// Program to perform general num ops
    /// </summary>
    class NumberOps
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine($"The Greater of the first two numbers {arr[0]} and {arr[1]} is {Math.Max(arr[0], arr[1])}");

            //loop to find the greatest number entered
            int max = 0;
            for (int i = 0; i < num; i++)
            {
                max = max > arr[i] ? max : arr[i];
            }
            Console.WriteLine($"the Maximum Value of the numbers entered is {max}");

            Console.ReadKey();



        }
    }
}
