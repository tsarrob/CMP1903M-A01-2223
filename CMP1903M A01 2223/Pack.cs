using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        public static List<Card> packFirstHalf = new List<Card>();
        public static List<Card> packSecondHalf = new List<Card>();
        public static List<Card> dealtCards = new List<Card>();
        public static List<Card> recentlyDealtCards = new List<Card>();

        //constructor
        public Pack()
        {
            
            for (int suitt = 1; suitt < 5; suitt++)
            {
                for (int valuee = 1; valuee < 14; valuee++)
                {
                    pack.Add(new Card(valuee, suitt)); //initialising the objects into the list so setting the unique values for each object to make a deck of 52 cards
                   
                }
                
               
            }

        }



                                                
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            //fisher-yates shuffle
            if (typeOfShuffle == 1)
            {
                return true;
            }

            //riffle shuffle
            else if (typeOfShuffle == 2)
            {

                return true;
            }

            //don't shuffle
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("The pack was not shuffled");
                return true;


            }
            else { return false; }  // exception


        }
        /*public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
        */

        public static void Display()
        {
       

            int count = 1;
            foreach (Card card in pack )
            {
                Console.Write("{0}. ", count);
                card.ShowCurrentCard();
                count++;
            };
        }
    }
        
        
   
}
        