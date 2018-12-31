using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyHello
{
    /// <summary>
    /// Program Executing Ex 56789 in Chap1
    /// </summary>
    class ModifyHello
    {
        static void Main(string[] args)
        {

            //Ex 5 Print out a different Greeting
            Console.WriteLine("Hello this is Ex 5 Program for Ch1");


            //Ex6
            Console.WriteLine("Please enter your First and Last Name ");
            String name = Console.ReadLine();
            Console.WriteLine("{0}", name);

            //Ex7
            Console.WriteLine("\n 1 \n 100 \n 101");

            //Ex8
            Console.WriteLine("The Current Date and Time is ");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            //Ex9
            Console.WriteLine("The Square root of 12345 is ");
            Console.WriteLine(Math.Sqrt(12345));

            Console.ReadKey();

            //Ex10
            for(int i=0;i<100;i++)
            {
                Console.Write(" {0}  ", (i+2)*Math.Pow(-1,i));
            }

            //Ex11
            Console.WriteLine("\nEnter any Age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age after 10 years is {age + 10}");
            Console.ReadKey();



        }
    }
}
