using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWords
{
    /// <summary>
    /// Program to convert given number less than thousand to correcponding words
    /// </summary>
    class NumberWords
    {
        public static string NumberName(int number)
        {
            string result="";

            switch (number)
            {
                case 1:
                    result="One";
                    break;
                case 2:
                    result="Two";
                    break;
                case 3:
                    result="Three";
                    break;
                case 4:
                    result="Four";
                    break;
                case 5:
                    result="Five";
                    break;
                case 6:
                    result="Six";
                    break;
                case 7:
                    result="Seven";
                    break;
                case 8:
                    result="Eight";
                    break;
                case 9:
                    result="Nine";
                    break;
                case 10:
                    result="Ten";
                    break;
                case 11:
                    result="Eleven";
                    break;
                case 12:
                    result="Twelve";
                    break;
                case 13:
                    result="Thirteen";
                    break;
                case 14:
                    result="Fourteen";
                    break;
                case 15:
                    result="Fifteen";
                    break;
                case 16:
                    result="Sixteen";
                    break;
                case 17:
                    result="Seventeen";
                    break;
                case 18:
                    result="Eighteen";
                    break;
                case 19:
                    result="Nineteen";
                    break;
                case 20:
                    result="Twenty";
                    break;
                case 30:
                    result="Thirty";
                    break;
                case 40:
                    result="Forty";
                    break;
                case 50:
                    result="Fifty";
                    break;
                case 60:
                    result="Sixty";
                    break;
                case 70:
                    result="Seventy";
                    break;
                case 80:
                    result="Eighty";
                    break;
                case 90:
                    result="Ninety";
                    break;

                default:
                    break;
            }

            return result;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter and Number to Convert into words");
            int num = Convert.ToInt32(Console.ReadLine());

            //for the number get individual digits;
            int ones = num % 10;
            int tens = (num /10)% 10;
            int hundreds = (num / 100) % 10;

           // Console.WriteLine($"The Number you have entered is {num}");
            string numWord = "";
            // adding the number word
            if (hundreds != 0)
            {
                numWord += NumberName(hundreds) +" ";
                numWord += "Hundred" + " ";
                if (tens!=0 || ones !=0)
                {
                    numWord += "and" + " ";
                }
            }
            if (tens != 0)
            {
                //check if tens are between ten and 20 donot update num Word
                if(tens==1)
                {
                    ones = tens * 10 + ones;
                }
                else
                {
                    numWord += NumberName(tens * 10);
                }

            }
            if(ones!=0)
            {
                numWord += NumberName(ones) + " ";
            }

            Console.WriteLine($" The Number Entered is {num} is \"{numWord}\"");
            Console.ReadKey();
            

           

        }

      
    }
}
