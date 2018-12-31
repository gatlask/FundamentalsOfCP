using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompArray
{
    /// <summary>
    /// Program to Compare two arrays
    /// </summary>
    class CompArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 , 6}; 

            bool b = CompareArray(arr1, arr2);
            Console.WriteLine($"Both the arrays are equal: {b}");
          

            bool bstr = CompareArray("Hello", "HelLo");
            Console.WriteLine($"Both the arrays are equal: {bstr}");

            int myOutput = string.Compare("L", "l");
            Console.WriteLine(myOutput.ToString());

            Console.ReadKey();
        }

        private static bool CompareArray(string v1, string v2)
        {
           if(v1.Length!=v2.Length)
            {
                Console.WriteLine("Both arrays are not equal, Finding out which is greater");
            }

            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] != v2[i])
                {
                    if (v1[i] < v2[i])
                    {
                        Console.WriteLine($"V1 is greater than v2 {i} {v1[i]} {v2[i]}");
                    }
                    else
                    {
                        Console.WriteLine("V2 is greater than v1");
                    }
                    return false;
                }
                
            }
            return true;

        }

        private static bool CompareArray(int[] arr1, int[] arr2)
        {
            if(arr1.Length!=arr2.Length)
            {
                return false;
            }

            for(int i=0;i<arr1.Length;i++)
            {
                if(arr1[i]!=arr2[i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
