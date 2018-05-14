using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Deck
	{
		public List<Card> FullDeck { get; set; }

		public void NewDeck()
		{
			List<Card> AllCards = new List<Card>();
			AllCards.Add(new Card() { Value = 1 });
			AllCards.Add(new Card() { Value = 2 });
			AllCards.Add(new Card() { Value = 3 });
			AllCards.Add(new Card() { Value = 4 });
			AllCards.Add(new Card() { Value = 5 });
			AllCards.Add(new Card() { Value = 6 });
			AllCards.Add(new Card() { Value = 7 });
			AllCards.Add(new Card() { Value = 8 });
			AllCards.Add(new Card() { Value = 9 });
			AllCards.Add(new Card() { Value = 10 });

			FullDeck = AllCards;
		}
	}
}
