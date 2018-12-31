using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTypes
{
    class VarTypes
    {
        static void Main(string[] args)
        {
            //short Byte
            sbyte mysByte;
            mysByte = 52;
            Console.WriteLine($" sByte value assigned is :{mysByte} \n min: {sbyte.MinValue} max: {sbyte.MaxValue}");

            //Byte
            byte myByte;
            myByte = 224;
            Console.WriteLine($" Byte value assigned is :{myByte} \n min: {byte.MinValue} max: {byte.MaxValue}");

            //Short
            short myShort;
            myShort = -10000;
            Console.WriteLine($" short value assigned is :{myShort} \n min: {short.MinValue} max: {short.MaxValue}");

            //UShort
            ushort myuShort;
            myuShort = 52130;
            Console.WriteLine($" uShort value assigned is :{myuShort} \n min: {ushort.MinValue} max: {ushort.MaxValue}");

            //Int
            int myInt;
            myInt = -115;
            Console.WriteLine($" int value assigned is :{myInt} \n min: {int.MinValue} max: {int.MaxValue}");

            //UInt
            uint myuInt;
            myuInt = 4825932;
            Console.WriteLine($" u Int value assigned is :{myuInt} \n min: {uint.MinValue} max: {uint.MaxValue}");

            //long
            long myLong;
            myLong = -1000000;
            Console.WriteLine($" Long value assigned is :{myLong} \n min: {long.MinValue} max: {long.MaxValue}");

            //ulong
            ulong myuLong;
            myuLong = 970700000;
            Console.WriteLine($" u Long value assigned is :{myuLong} \n min: {ulong.MinValue} max: {ulong.MaxValue}");

            //float
            float myFloat;
            myFloat = 52.0f;
            Console.WriteLine($" Float value assigned is :{myFloat} \n min: {float.MinValue} max: {float.MaxValue}");

            //double
            double myDouble;
            myDouble = 123456789123456789.123;
            Console.WriteLine($" Double value assigned is :{myDouble} \n min: {double.MinValue} max: {double.MaxValue}");

            //decimal
            decimal myDecimal;
            myDecimal = 5123412342.1234123m;
            Console.WriteLine($" Decimal value assigned is :{myDecimal} \n min: {decimal.MinValue} max: {decimal.MaxValue}");

            Console.ReadKey();


            
        }
    }
}
