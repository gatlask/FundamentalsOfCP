using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipFive
{
    /// <summary>
    /// Program to give out no of multiples of 5 in a given range
    /// </summary>
    class MultipFive
    {
        static void Main(string[] args)
        {
            // get range as input
            Console.WriteLine("Please enter the range to get multiples of \n5 Starting number:");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ending number > Starting:");
            int endRange = Convert.ToInt32(Console.ReadLine());


            // no of multiples of 5 present in between the two numbers is 
            int numFive = (endRange - startRange + endRange % 5 +startRange%5) / 5 ;
            Console.WriteLine($"The number of multiples are {numFive}");

            //and they are 
            for(int i=1;i<=numFive;i++)
            {
                // 5-startrange%5
                Console.Write($" {startRange - startRange % 5 + 5*i} ");
                Console.WriteLine();

            }
            Console.ReadKey();


        }
    }
}
