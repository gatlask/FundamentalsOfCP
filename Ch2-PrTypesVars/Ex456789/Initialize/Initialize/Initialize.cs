using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialize
{
    class Initialize
    {
        static void Main(string[] args)
        {
            //Ex4
            int i = 0x100; // i is given a value 256 which is 0x100 in hex format
            Console.WriteLine($"Value of is is {i}");

            //Ex5
            char ch= '\u0072';
            Console.WriteLine($"Value of Char ch is {ch}");


            //Ex6
            bool isMale = true;
            Console.WriteLine($"Value of bool is {isMale}");


            //Ex7
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + str2;
            Console.WriteLine($"The Value present in the Object is {obj}");

            //Ex8
            obj = str1 + " " + str2;
            string str3 = Convert.ToString(obj);
            Console.WriteLine($"this is the value of String through Object {str3}");


            //Ex9
            string qstr = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(qstr);




            Console.ReadKey();

        }
    }
}
