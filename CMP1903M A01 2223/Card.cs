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


        //methods to access the private fields
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
        

    }
}
