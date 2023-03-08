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
        public static List<Card> pack2 = new List<Card>();
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
                    pack.Add(new Card(valuee, suitt)); //initialising the objects into the list so setting with all the values needed to each object to make a deck of 52 cards
                    pack2.Add(new Card(valuee, suitt));// a seperate pack of cards for the riffle shuffle

                }
                
               
            }

        }



                                                
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            //fisher-yates shuffle
            if (typeOfShuffle == 1)
            {
                Random rnd = new Random();
                for (int i = pack.Count -1; i >= 0; i-- )
                {
                    int Chosen = rnd.Next(0,i);
                    (pack[Chosen] , pack[i]) = (pack[i] , pack[Chosen]);
                }
                return true;   
            }

            //riffle shuffle
            else if (typeOfShuffle == 2)
            {
                for (int i = 0; i < pack2.Count -1; i+=2)
                {
                    (pack2[i], pack[i+1]) = (pack2[i + 1], pack[i]);
                }
                
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

        //Deals one card
        public static Card deal()
        {


            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;                             //cant deal a card since there are no cards left so returns null

            }


        }
        /*public static List<Card> dealCard(int amount)
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
        