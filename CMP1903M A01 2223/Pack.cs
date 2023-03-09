using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        public static List<Card> tempPack = new List<Card>();
        public static List<Card> dealtCards = new List<Card>();

        //constructor
        public Pack()
        {

            for (int suitt = 1; suitt < 5; suitt++)
            {
                for (int valuee = 1; valuee < 14; valuee++)
                {
                    pack.Add(new Card(valuee, suitt)); //initialising the objects into the list so setting with all the values needed to each object to make a deck of 52 cards


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
                for (int i = pack.Count - 1; i >= 0; i--)
                {
                    int Chosen = rnd.Next(0, i);
                    (pack[Chosen], pack[i]) = (pack[i], pack[Chosen]);
                }
                return true;
            }

            //riffle shuffle
            else if (typeOfShuffle == 2)
            {

                int j = 0;//counter
                while (j < (pack.Count / 2))
                {

                    tempPack.Add(pack[j]);
                    tempPack.Add(pack[j + (pack.Count / 2)]);
                    j += 1;

                }
                pack = tempPack; //after while loop finishes the temp pack is built with each half of the pack and riffle shuffled and then gets set back to pack 

                return true;
            }

            //don't shuffle
            else if (typeOfShuffle == 3)
            {
                return true;


            }
            else { return false; }  // exception


        }

        //Deals one card
        public static Card dealCard()
        {


            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;                     //cant deal a card since there are no cards left so returns null

            }
            else
            {
                Card temp = pack[0];
                pack.RemoveAt(0);
                return temp;
            }


        }
        //Deals the number of cards specified by 'amount'
        public static List<Card> dealCard(int amount)
        {
            dealtCards.Clear();
            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }

            else if (pack.Count < amount)
            {
                Console.WriteLine("Cant deal {0} cards since there is only {1} cards remaining in the deck", amount, pack.Count);
                return null;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    dealtCards.Add(dealCard());

                }
                return dealtCards;
                
            }
        }
        public static void Display() //Additional method to display the pack of cards
        {
            int count = 1;
            foreach (Card card in pack)
            {
                Console.Write("{0}. ", count);
                card.ShowCurrentCard();
                count++;
            };

        }

    }    
        
   
}
        