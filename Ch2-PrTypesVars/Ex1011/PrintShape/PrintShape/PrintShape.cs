using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintShape
{
    class PrintShape
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Ex10 ... multi line
            Console.Write(@"
                             00   00 
                            0  0 0  0
                            0   0   0
                             0     0
                              0   0
                                0");

            Console.WriteLine("");
            Console.ReadKey();

            //Ex 11 .. using copy right symbol
          
            char ch = '\u00AB';
            Console.Write("\uC2A9 {0:u} © ", ch);

            Console.ReadKey();
        }
    }
}
