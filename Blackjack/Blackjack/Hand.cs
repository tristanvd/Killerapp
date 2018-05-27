using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Hand
	{
		public List<Card> Cards = new List<Card>();
		public int Value { get; set; }

		public void ClearHand(Hand hand)
		{
			hand.Cards.Clear();
		}

		public Card GetCard(Deck deck)
		{
			
			Random rnd = new Random();
			int getal = rnd.Next(deck.FullDeck.Count);
			Card randomcard = deck.FullDeck[getal];

			return randomcard;
		}

		
	}
}
