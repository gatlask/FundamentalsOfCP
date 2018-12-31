using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NumberWords;

namespace CardSuits
{
    class CardSuits
    {
        /// <summary>
        /// program to print out all the cards of the deck
        /// </summary>
        static void Main(string[] args)
        {
            //Print out values of the cards in the deck

            string[] suit = new string[] { "Clubs", "Hearts", "Spades", "Diamonds" };

            int numOfCards = 0;
            string nstr = "";

            foreach (string st in suit)
            {
                for (int i = 1; i < 14; i++)
                {

                    nstr = NumberWords.NumberName(i);
                  //  Console.WriteLine(nstr);

                    switch (i)
                    {
                        case 1:
                            nstr = "Ace";
                            break;
                        case 11:
                            nstr = "Jack";
                            break;
                        case 12:
                            nstr = "Queen";
                            break;
                        case 13:
                            nstr = "King";
                            break;
                        default:
                            break;               

                    }

                    nstr += " of " + st;

                    Console.WriteLine(nstr);

                }

               

            }

            Console.ReadKey();
        }

        
    }

}
    
