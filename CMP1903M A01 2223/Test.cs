using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

	class Test 
	{
		static void Main(String[] args)
		{
			
			Pack Deck = new Pack();
			Pack.Display();
			Pack.deal().ShowCurrentCard();

			Console.WriteLine("Input the number for the shuffle desired, 1 - fisher-yates shuffle, 2 - riffle shuffle, 3 - no shuffle");
			Pack.shuffleCardPack(Convert.ToInt32(Console.ReadLine()));
			Pack.Display();

			
		}
		
	}
}
