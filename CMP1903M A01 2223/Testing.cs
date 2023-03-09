﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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


            //Display original pack of cards
            Console.WriteLine("\n original pack of cards -------------\n");
            Pack.Display();


            //Different Shuffles
            // 1 - fisher-yates shuffle
            Console.WriteLine("\n fisher-yates shuffle on pack of cards -------------\n"); //prints true if shuffle is vaild
            Console.WriteLine(Pack.shuffleCardPack(1));
            Pack.Display();


            // 2 - riffle shuffle 
            Console.WriteLine("\n riffle shuffle on pack of cards -------------\n"); //prints true if shuffle is valid
            Console.WriteLine(Pack.shuffleCardPack(2));
            Pack.Display();


            // 3 - no shuffle
            Console.WriteLine("\n no shuffle on pack of cards -------------\n"); //prints true if shuffle is valid
            Console.WriteLine(Pack.shuffleCardPack(3));
            Pack.Display();

            // deal one card
            Console.WriteLine("\n Deal one card -------------\n");
            Pack.dealCard().ShowCurrentCard();

            // show cards in the deck
            Console.WriteLine("\n Show deck -------------\n");
            Pack.Display();

            // deal multiple cards
            Console.WriteLine("\n Deals multiple cards -------------\n");
            Pack.dealCard(5);
            foreach (Card card in Pack.dealtCards)
            {
                card.ShowCurrentCard();
            }
            Console.WriteLine("\n Show deck -------------\n");
            Pack.Display();

            // testing error handling with invalid type of shuffle
            Console.WriteLine("\n if false then error handling works -------------\n");
            Console.WriteLine(Pack.shuffleCardPack(4));



        }    

    }
}