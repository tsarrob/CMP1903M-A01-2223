using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {

        //my fields (encapsulation)
        private int _Value;
        private int _Suit;

        //array to use the value and suit as an index to have the coresponding string to print
        private readonly string[] faceArray = { "Ace", "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King" };
        private readonly string[] suitArray = { "Spades", "Hearts", "Diamonds", "Clubs" };




        //methods to access the private fields values
        public int Value
        {
            get 
            { return _Value; }

            set
            {
                if (value >= 1 || value <= 13)
                {
                    _Value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value has to be between or including 1-13");
                }
            }
        }


        public int Suit
        {
            get
            { return _Suit; }

            set
            {
                if (value >= 1 || value <= 4)
                {
                    _Suit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value has to be between or including 1-4");
                }
            }
        }
        


        //construct
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;    
        }

       //functions
       public void ShowCurrentCard()
        {
            Console.WriteLine(faceArray[Value-1] + " of " + suitArray[Suit-1]);
        }



    }
}
