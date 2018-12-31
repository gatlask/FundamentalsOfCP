using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Please Enter any number");
            num = Convert.ToInt32(Console.ReadLine());

            //Ex1 Check if number is odd or even
            if(num%2==0)
            {
                Console.WriteLine("The entered number is even");
            }
            else
            {
                Console.WriteLine("The entered number is odd");
            }

            
            //Ex2 
            // bool exp to check if number is divisible by 5 and 7
            bool b = (num%5==0)&&(num%7==0)?true:false;
            Console.WriteLine($"The Number is divisible by 5 and 7 :{b}");

            //Ex3
            // third digit right to left is 7
            string str = Convert.ToString(num);
            int len = str.Length;
            if(str[len-3]==7)
            {
                Console.WriteLine("the third digit is a 7");

            }
            else
            {
                Console.WriteLine("the third digit is not a 7");

            }

            //Ex4
            // check if the third number of boolean is 1 or 0
            //String number = "100";
            //int fromBase = 16;
            //int toBase = 10;
            //String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            // result == "256"
            string strb = Convert.ToString(num, 2);
            Console.WriteLine($"The Converted String is {strb}");
            b= (strb[2] == '1') ? true : false;
            Console.WriteLine($"The third character is 1:{b}");


            //Ex10
            int num4 = Convert.ToInt32(num.ToString().Substring(0, 4));
            Console.WriteLine($"the Choosen 4 digit number is {num4}");
            //int sumdigits = num4[0]+num4[1]+num4[2]+num4[3];

            //selecting individual digits
            int d4 = num4 % 10;
            int d3 = (num4 / 10) % 10;
            int d2 = (num4 / 100) % 10;
            int d1 = (num4 / 1000) % 10;

            int sumd = 0;
            //calculate sum 
            Console.WriteLine($"Sum of the digist is {d1+d2+d3+d4}");

            //reverse number
            Console.WriteLine($"Reversed Number: {d4*1000+d3*100+d2*10+d1}");

            //last digit first number
            Console.WriteLine($"Last digit first Number: {d4 * 1000 + d1 * 100 + d2 * 10 + d3}");

            //Exchange 2 and 3 digits
            Console.WriteLine($"Last digit first Number: {d1 * 1000 + d3 * 100 + d2 * 10 + d4}");
            



            Console.ReadKey();

        }
    }
}
