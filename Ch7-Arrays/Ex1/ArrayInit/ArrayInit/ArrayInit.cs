using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInit
{
    class ArrayInit
    {
        static void Main(string[] args)
        {

            int[] arr = new int[20];

            for(int i=0;i< arr.Length;i++)
            {
                arr[i] = i * 5;
            }

            Console.WriteLine(arr);// writes the pointer

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine($" ith value is {arr[i]} ");

            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
