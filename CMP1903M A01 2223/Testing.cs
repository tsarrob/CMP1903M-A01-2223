using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	//Additional Class for testing purposes
	class Testing 
	{
		public static void Test()
        {
            //Creates a pack object
            Pack Deck = new Pack();





            Console.WriteLine("Input the number for the shuffle desired, 1 - fisher-yates shuffle, 2 - riffle shuffle, 3 - no shuffle");



            //calls the shuffle card pack method 
            Pack.shuffleCardPack(Convert.ToInt32(Console.ReadLine()));
            
            Pack.Display();


            //calls the deal methods
            Pack.dealCard().ShowCurrentCard();

            Pack.dealCard(5);
            foreach (Card card in Pack.dealtCards)
            {
                card.ShowCurrentCard();
            }
            Pack.Display();
        }

    }
}
